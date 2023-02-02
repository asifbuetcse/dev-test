using dev_test.DTOs;

namespace dev_test.Services.Contracts
{
    public interface IUserService
    {
        public IEnumerable<UserDto> GetUsers();
        public void PostUser(UserDto user);
    }
}
