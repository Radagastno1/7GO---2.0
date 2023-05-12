using CORE.Entities;
using CORE.Interfaces;

namespace INFRASTRUCTURE.Repositories;

public class UserRepository : IRepository<CORE.Entities.User>
{
    public async Task<User> Create(User obj)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<User>> Get()
    {
        throw new NotImplementedException();
    }

    public async Task<User> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<User> Update(User obj)
    {
        throw new NotImplementedException();
    }
}