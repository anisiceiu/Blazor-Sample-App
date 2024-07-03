using UAM.DAL;
using UAM.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace UAM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Hose21mFittingVolumeController : ControllerBase
    {
        private readonly DataAppsContext context  ;
        public Hose21mFittingVolumeController(DataAppsContext _context) {
            context= _context ;
        }

        [HttpGet]
        [Route("GetPagination")]
        public async Task<Pagination> GetPagination()
        {
            var pagination = new Pagination { CurrentPage = 1, PageSize = 10 , TotalRecord =0 };
            pagination.TotalRecord = await context.Hose21mFittingVolume.CountAsync();

            return pagination;
        }

        [HttpGet]
        [Route("Index")]
        [AllowAnonymous]
        public async Task<IEnumerable<Hose21mFittingVolume>> Index(int pageNo=1)
        {
            int pageSize = 10;
            return await context.Hose21mFittingVolume.OrderByDescending(b=> b.Hose21mFittingVolumeID)
                .Skip((pageNo-1)*pageSize).Take(pageSize).ToListAsync();
        }

        [HttpPost]
        [Route("Create")]
        public async Task<Hose21mFittingVolume> Create([FromBody] Hose21mFittingVolume hose21mFittingVolume)
        {
            if (ModelState.IsValid)
            {
                context.Hose21mFittingVolume.Add(hose21mFittingVolume);
                context.SaveChanges();
            }

            return hose21mFittingVolume;
        }
    }
}
