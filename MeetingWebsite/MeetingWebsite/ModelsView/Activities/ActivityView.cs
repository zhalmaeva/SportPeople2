using MeetingWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingWebsite.ModelsView
{
    public class ActivityView
    {
        public ActivityView(Activity activity)
        {
            Id = activity.Id;
            UserId = activity.UserId;
            SportKind = activity.SportKind;
            level = activity.level;
            Date = activity.Date;
            City = activity.City;
            Count = activity.Count;
            ActivityUsers = activity.ActivityUsers;
            Address = activity.Address;
            Description = activity.Description;
            Description = activity.Description;
            Price = activity.Price;
            DateCreateUnix = activity.DateCreateUnix;
            CountUser = activity.CountUser;
            dateTime = activity.dateTime;
        }

        public int Id { get; set; }

        public int UserId { get; set; }
        /// <summary>
        /// Содержимое заявки
        /// </summary>
        public SportKind SportKind { get; set; }

        public Level level { get; set; }

        public string Date { get; set; }

        public DateTime dateTime { get; set; }

        public List<ActivityUsers> ActivityUsers { get; set; } = new List<ActivityUsers>();

        public string Address { get; set; }

        public string City { get; set; }

        public int Count { get; set; }

        public int CountUser { get; set; }

        public List<User> Users { get; set; }

        public uint Price { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Дата создания сообщения
        /// </summary>
        public long DateCreateUnix { get; set; }

        public DateTime DateCreate
        {
            get => DateTime.UnixEpoch.AddSeconds(DateCreateUnix);
            set => DateCreateUnix = (int)((value - DateTime.UnixEpoch).TotalSeconds);
        }
    }
}
