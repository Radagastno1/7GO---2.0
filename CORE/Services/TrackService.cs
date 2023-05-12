using CORE.Entities;
using CORE.Interfaces;

namespace CORE.Services;

public class TrackService : Iservice<CORE.Entities.Track>
{
    private readonly IRepository<Track> _trackRepo;

    public TrackService(IRepository<Track> trackRepo)
    {
        _trackRepo = trackRepo;
    }

    public async Task<Track> add(Track obj)
    {
        var newTrack = await _trackRepo.Create(obj);
        return newTrack;
    }

    public async Task Delete(Track obj)
    {
        await _trackRepo.Delete(obj);
    }

    public async Task<List<Track>> Get()
    {
        List<Track> tracks = await _trackRepo.Get();
        return tracks;
    }

    public async Task<Track> GetById(int id)
    {
        var track = await _trackRepo.GetById(id);
        return track;
    }

    public async Task<Track> Put(Track obj)
    {
        var putTrack = await _trackRepo.Update(obj);
        return putTrack;
    }
}