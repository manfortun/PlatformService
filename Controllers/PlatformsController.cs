using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.DataAccess.Interfaces;
using PlatformService.DTOs;

namespace PlatformService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlatformsController : ControllerBase
{
    private readonly IPlatformRepository _repository;
    private readonly IMapper _mapper;

    public PlatformsController(
        IPlatformRepository platformRepository,
        IMapper mapper)
    {
        _repository = platformRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public ActionResult<IEnumerable<PlatformReadDto>> GetPlatforms()
    {
        Console.WriteLine("Getting platforms...");

        var platformItem = _repository.GetAll();

        return Ok(_mapper.Map<IEnumerable<PlatformReadDto>>(platformItem));
    }
}
