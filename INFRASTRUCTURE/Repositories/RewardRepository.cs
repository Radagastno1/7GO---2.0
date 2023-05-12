using CORE.Entities;
using CORE.Interfaces;

namespace INFRASTRUCTURE.Repositories;

public class RewardRepository : IRepository<CORE.Entities.Reward>
{
    public async Task<Reward> Create(Reward obj)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Reward>> Get()
    {
        throw new NotImplementedException();
    }

    public async Task<Reward> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Reward> Update(Reward obj)
    {
        throw new NotImplementedException();
    }

    public async Task Delete(Reward obj)
    {
        throw new NotImplementedException();
    }
}