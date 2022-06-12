using MeetingWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingWebsite.ModelsView.Activities
{
    public class NewActivityModel
    {
        /// <summary>
        /// Содержимое заявки
        /// </summary>
        public SportKind SportKind { get; set; }

        public Level level { get; set; }

        public string Date { get; set; }

        public DateTime dateTime { get; set; }

        public string City { get; set; }

        public int Count { get; set; }

        public string Address { get; set; }
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

        public Activity ToDbModel()
        {
            return new Activity()
            {
                SportKind = SportKind,
                level = level,
                Date = Date,
                Address = Address,
                dateTime = dateTime,
                Count = Count,
                City = City,
                Description = Description,
                Price = Price,
                DateCreateUnix = DateCreateUnix,
            };
        }
    }
}
