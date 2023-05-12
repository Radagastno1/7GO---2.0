using CORE.Entities;
using CORE.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace INFRASTRUCTURE.Repositories;

public class ChallengeRepository : IRepository<CORE.Entities.Challenge>
{
    private readonly INFRASTRUCTURE.Data.SevenGoContext _sevenGoContext;

    public ChallengeRepository(INFRASTRUCTURE.Data.SevenGoContext sevenGoContext)
    {
        _sevenGoContext = sevenGoContext;
    }

    public async Task<Challenge> Create(Challenge obj)
    {
        try
        {
            await _sevenGoContext.challenge.AddAsync(obj);
            await _sevenGoContext.SaveChangesAsync();

            var recentlyAddedChallenge = await _sevenGoContext.challenge
                .OrderByDescending(c => c.challengeId)
                .FirstOrDefaultAsync();

            return recentlyAddedChallenge;
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task DeleteById(int id)
    {
        try
        {
            var challengeToDelete = await _sevenGoContext.challenge.FindAsync(id);
            var deletedChallenge = challengeToDelete;
            if (challengeToDelete != null)
            {
                _sevenGoContext.challenge.Remove(challengeToDelete);
                await _sevenGoContext.SaveChangesAsync();
            }
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public async Task<List<Challenge>> Get()
    {
        try
        {
            if (_sevenGoContext.challenge.Count() < 1)
            {
                return new List<Challenge>();
            }
            return await _sevenGoContext.challenge.ToListAsync();
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<Challenge> GetById(int id)
    {
        try
        {
            if (_sevenGoContext.challenge.Count() < 1)
            {
                return new Challenge();
            }
            var challenge = await _sevenGoContext.challenge.FirstAsync();

            return challenge;
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<Challenge> Update(Challenge obj)
    {
          try
        {
            var challengeToUpdate = await _sevenGoContext.challenge.FindAsync(obj.challengeId);
            if (challengeToUpdate == null)
            {
                return null;
            }
            // movieToUpdate.Title = movie.Title ?? movieToUpdate.Title;
            // movieToUpdate.Description = movie.Description ?? movieToUpdate.Description;
            // movieToUpdate.AmountOfScreenings = movie.AmountOfScreenings;
            // movieToUpdate.MaxScreenings = movie.MaxScreenings;
            // movieToUpdate.Language = movie.Language ?? movieToUpdate.Language;
            // movieToUpdate.ReleaseYear = movie.ReleaseYear;
            // movieToUpdate.DurationMinutes = movie.DurationMinutes;
            // movieToUpdate.ImageUrl = movie.ImageUrl ?? movieToUpdate.ImageUrl;
            // movieToUpdate.Price = movie.Price;
            // movieToUpdate.TrailerId = movie.TrailerId;

            // movieToUpdate.Actors = movie.Actors;

            // movieToUpdate.Directors = movie.Directors;

            _sevenGoContext.challenge.Update(challengeToUpdate);

            await _sevenGoContext.SaveChangesAsync();
            return challengeToUpdate;
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task Delete(Challenge obj)
    {
        throw new NotImplementedException();
    }
}
