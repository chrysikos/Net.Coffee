using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net.Coffee.Server.Domain;
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

        public UserController(
            UnitOfWork unitOfWork,
            IUsersRepository usersRepository,
            IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.usersRepository = usersRepository;
        }
        [HttpGet]
        public async Task<RJesObjectResult> Get()
        {
            var users = await usersRepository.GetAllAsync();
            var result = mapper.Map<IEnumerable<UserDTO>>(users);
            return await Task.FromResult(RJesOK(result, $"Rows:{result.Count()}"));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var user = await usersRepository.GetByIdAsync(id);
            var result = mapper.Map<UserDTO>(user);
            return await Task.FromResult(Ok(result));
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserDTO newUser)
        {
            var user = mapper.Map<User>(newUser);
            var entry = await this.usersRepository.AddAsync(user);
            await unitOfWork.SaveChangesAsync();
            return await Task.FromResult(Ok(entry.ID));
        }
    }
}
