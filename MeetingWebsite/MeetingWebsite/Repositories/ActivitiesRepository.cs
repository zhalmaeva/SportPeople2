using MeetingWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MeetingWebsite.Repositories
{
    public class ActivitiesRepository: BaseRepository<Activity>
    {
        public ActivitiesRepository(DBContext db) : base(db)
        {
        }

        public override IQueryable<Activity> GetList()
        {
            return base.GetList().OrderByDescending(p => p.DateCreateUnix);
        }

        public async Task<bool> AddUsers(List<ActivityUsers> users)
        {
            try
            {
                await _db.AddRangeAsync(users);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
