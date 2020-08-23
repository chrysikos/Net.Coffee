using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net.Coffee.Domain;
using Net.Coffee.Server.Model;
using Net.Coffee.Server.Persistence;
using psv.SFP.ApiSpecification;

namespace Net.Coffee.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : RJesController
    {
        readonly UnitOfWork unitOfWork;
        readonly IMapper mapper;
        readonly IUsersRepository usersRepository;
        readonly UserService userService;

        public UserController(
            UnitOfWork unitOfWork,
            IUsersRepository usersRepository,
            IMapper mapper,
            UserService userService)
        {
            this.userService = userService;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.usersRepository = usersRepository;
        }

        [HttpGet]
        public async Task<RJesObjectResult> Get()
        {
            var users = await usersRepository.GetAllAsync();
            var result = mapper.Map<IEnumerable<UserDTO>>(users);
            return RJesOK(result, $"Rows:{result.Count()}");
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<RJesObjectResult> Get(Guid id)
        {
            var user = await usersRepository.GetByIdAsync(id);
            var result = mapper.Map<UserDTO>(user);
            return RJesOK(result, "User retrieved.");
        }

        [HttpPost]
        public async Task<RJesObjectResult> Post([FromBody] UserDTO userDTO)
        {
            var user = mapper.Map<User>(userDTO);
            if (!(await userService.EnsureUserCredentialsUniquenessAsync(user)))
                return RJesBadRequest(null, $"Username:{user.Credentials.Username} already exists.");
            var entry = await this.usersRepository.AddAsync(user);
            await unitOfWork.SaveChangesAsync();
            return RJesOK(entry.ID, "User created.");
        }

        [HttpPut]
        public async Task<RJesObjectResult> Put([FromBody] UserDTO userDTO)
        {
            var existedUser = await usersRepository.GetByIdAsync(userDTO.ID);
            var user = mapper.Map(userDTO, existedUser);
            if (!(await userService.EnsureUserCredentialsUniquenessAsync(user)))
                return RJesBadRequest(null, $"Username: {user.Credentials.Username} already exists.");
            await unitOfWork.SaveChangesAsync();
            return RJesOK(user.ID, "User updated.");
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<RJesObjectResult> Delete(Guid id)
        {
            var user = await usersRepository.GetByIdAsync(id);
            usersRepository.Remove(user);
            await unitOfWork.SaveChangesAsync();
            return RJesOK(user.ID, "User removed.");
        }
    }
}
