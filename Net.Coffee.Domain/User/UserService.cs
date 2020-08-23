using System.Threading.Tasks;

namespace Net.Coffee.Domain
{
    public class UserService
    {
        readonly IUsersRepository usersRepository;
        public UserService(
            IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public async  Task<bool> EnsureUserCredentialsUniquenessAsync(User user)
        {
            var actualUser = await this.usersRepository.GetByCredentialsUsernameAsync(user.Credentials.Username);
            if (actualUser == null)
                return true;

            if (user.ID == actualUser.ID)
                return true;

            return false;
        }
    }
}
