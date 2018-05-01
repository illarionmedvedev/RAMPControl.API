using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RAMPControl.API.Data;
using RAMPControl.API.Dtos;

namespace RAMPControl.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class ReportController : Controller
    {
        private readonly IReportRepository _repo;
        private readonly IMapper _mapper;
        public ReportController(IReportRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetReports()
        {
            var reports = await _repo.GetUsers();

            var usersToReturn = _mapper.Map<IEnumerable<UserForListDto>>(reports);

            return Ok(usersToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _repo.GetUser(id);

            var userToReturn = _mapper.Map<UserForListDto>(user);

            return Ok(userToReturn);
        }
    }
}