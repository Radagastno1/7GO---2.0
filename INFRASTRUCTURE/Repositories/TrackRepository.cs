using CORE.Entities;
using CORE.Interfaces;

namespace INFRASTRUCTURE.Repositories;

public class TrackRepository : IRepository<CORE.Entities.Track>
{
    public async Task<Track> Create(Track obj)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Track>> Get()
    {
        throw new NotImplementedException();
    }

    public async Task<Track> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Track> Update(Track obj)
    {
        throw new NotImplementedException();
    }

    public async Task Delete(Track obj)
    {
        throw new NotImplementedException();
    }
}