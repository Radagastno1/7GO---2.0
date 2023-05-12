using CORE.Entities;
using CORE.Interfaces;

namespace CORE.Services;

public class RewardService : Iservice<CORE.Entities.Reward>
{
    private readonly IRepository<Reward> _rewardRepo;

    public RewardService(IRepository<Reward> rewardRepo)
    {
        _rewardRepo = rewardRepo;
    }
    public async Task<Reward> add(Reward obj)
    {
        var newReward = await _rewardRepo.Create(obj);
        return newReward;
    }

    public async Task Delete(Reward obj)
    {
        await _rewardRepo.Delete(obj);
    }

    public async Task<List<Reward>> Get()
    {
        List<Reward> rewards = await _rewardRepo.Get();
        return rewards;
    }

    public async Task<Reward> GetById(int id)
    {
        var reward = await _rewardRepo.GetById(id);
        return reward;
    }

    public async Task<Reward> Put(Reward obj)
    {
        var putChallenge = await _rewardRepo.Update(obj);
        return putChallenge;
    }
}