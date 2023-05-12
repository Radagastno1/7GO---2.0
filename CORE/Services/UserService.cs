using CORE.Entities;
using CORE.Interfaces;

namespace CORE.Services;

public class UserService : Iservice<CORE.Entities.User>
{
    private readonly IRepository<User> _userRepo;

    public UserService(IRepository<User> userRepo)
    {
        _userRepo = userRepo;
    }
    public async Task<User> add(User obj)
    {
        var newUser = await _userRepo.Create(obj);
        return newUser;
    }

    public async Task Delete(User obj)
    {
        await _userRepo.Delete(obj);
    }

    public async Task<List<User>> Get()
    {
        List<User> getUsers = await _userRepo.Get();
        return getUsers;
    }

    public async Task<User> GetById(int id)
    {
        var user = await _userRepo.GetById(id);
        return user;
    }

    public async Task<User> Put(User obj)
    {
        var putUser = await _userRepo.Update(obj);
        return putUser;
    }
}
