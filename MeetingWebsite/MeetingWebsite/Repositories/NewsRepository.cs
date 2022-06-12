using MeetingWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingWebsite.Repositories
{
    public class NewsRepository : BaseRepository<New>
    {
        public NewsRepository(DBContext db) : base(db)
        {

        }
        public override IQueryable<New> GetList()
        {
            return base.GetList().OrderByDescending(p => p.DateCreateUnix);
        }
    }
}
