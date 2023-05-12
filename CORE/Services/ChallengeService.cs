using CORE.Entities;
using CORE.Interfaces;

namespace CORE.Services;

public class ChallengeService : Iservice<CORE.Entities.Challenge>
{
    private readonly IRepository<Challenge> _challengeRepo;

    public ChallengeService(IRepository<Challenge> challengeRepo)
    {
        _challengeRepo = challengeRepo;
    }

    public async Task<Challenge> add(Challenge obj)
    {
        var newChallenge = await _challengeRepo.Create(obj);
        return newChallenge;
    }

    public async Task Delete(Challenge obj)
    {
        await _challengeRepo.DeleteById(obj.challengeId);
    }

    public async Task<List<Challenge>> Get()
    {
       List<Challenge> Challenges = await _challengeRepo.Get();
       return Challenges;
    }

    public async Task<Challenge> GetById(int id)
    {
        var challenge = await _challengeRepo.GetById(id);
        return challenge;
    }

    public async Task<Challenge> Put(Challenge obj)
    {
        var putChallenge = await _challengeRepo.Update(obj);
        return putChallenge;
    }
}