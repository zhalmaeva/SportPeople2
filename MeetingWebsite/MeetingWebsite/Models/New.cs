using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingWebsite.Models
{
    public class New : BaseEntity
    {
        public New()
        {
            DateCreate = DateTime.UtcNow;
        }
        [ForeignKey("User")]
        public int UserId { set; get; }

        public string Title { set; get; }

        public string PhotoPath { get; set; }

        public string Text { get; set; }

        public long DateCreateUnix { get; set; }

        [NotMapped]
        public DateTime DateCreate
        {
            get => DateTime.UnixEpoch.AddSeconds(DateCreateUnix);
            set => DateCreateUnix = (int)((value - DateTime.UnixEpoch).TotalSeconds);
        }
    }
}
