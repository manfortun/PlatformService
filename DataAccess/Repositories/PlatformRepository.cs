using Microsoft.EntityFrameworkCore;
using PlatformService.DataAccess.Interfaces;
using PlatformService.Models;

namespace PlatformService.DataAccess.Repositories;

public class PlatformRepository : IPlatformRepository
{
    private readonly AppDbContext _context;

    public PlatformRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Platform> GetAll()
    {
        return _context.Platforms.ToList();
    }

    public Platform? GetById(int id)
    {
        return _context.Platforms.Find(id);
    }

    public void Insert(Platform entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        _context.Platforms.Add(entity);
    }

    public bool Save()
    {
        return _context.SaveChanges() >= 0;
    }
}
