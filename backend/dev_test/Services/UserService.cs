using AutoMapper;
using dev_test.DTOs;
using dev_test.Entities;
using dev_test.Repositories.Contracts;
using dev_test.Services.Contracts;

namespace dev_test.Services
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public IEnumerable<UserDto> GetUsers()
        {

            var user = _userRepository.GetUsers();
            var userDtos = _mapper.Map<IEnumerable<UserDto>>(user);
            return userDtos;
        }

        public void PostUser(UserDto user)
        {
            _userRepository.PostUser((User?)_mapper.Map<User>(user));
        }
    }
}
