using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingWebsite.Models
{
    public class Activity : BaseEntity
    {
        public Activity()
        {
            DateCreate = DateTime.UtcNow;
        }
        /// <summary>
        /// Создатель сообщения
        /// </summary>
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        /// <summary>
        /// Содержимое заявки
        /// </summary>
        public SportKind SportKind { get; set; }

        public string City { get; set; }

        public int Count { get; set; }

        public int CountUser { get; set; }

        public List<ActivityUsers> ActivityUsers { get; set; } = new List<ActivityUsers>();

        public Level level  { get; set; }

        public string Date { get; set; }
        
        public DateTime dateTime { get; set; }

        public string Address { get; set; }

        public uint Price { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Дата создания сообщения
        /// </summary>
        public long DateCreateUnix { get; set; }

        [NotMapped]
        public DateTime DateCreate
        {
            get => DateTime.UnixEpoch.AddSeconds(DateCreateUnix);
            set => DateCreateUnix = (int)((value - DateTime.UnixEpoch).TotalSeconds);
        }
    }

    public enum SportKind
    {
        /// <summary>
        /// Парень 
        /// </summary>
        [Display(Name = "Волейбол")]
        Volleyball = 0,

        /// <summary>
        /// Деушки 
        /// </summary>
        [Display(Name = "Футбол")]
        Football = 1,


        /// <summary>
        /// Другое 
        /// </summary>
        [Display(Name = "Бег")]
        Runnng = 2,
    }

    public enum Level
    {
        /// <summary>
        /// Парень 
        /// </summary>
        [Display(Name = "*")]
        First = 0,

        /// <summary>
        /// Деушки 
        /// </summary>
        [Display(Name = "**")]
        Second = 1,


        /// <summary>
        /// Другое 
        /// </summary>
        [Display(Name = "***")]
        Еhird = 2,

        /// <summary>
        /// Другое 
        /// </summary>
        [Display(Name = "****")]
        fourth = 3,

        /// <summary>
        /// Другое 
        /// </summary>
        [Display(Name = "*****")]
        fifth = 4,
    }
    public class ActivityUsers
    {
        public ActivityUsers() { }
        public ActivityUsers(int userId, int activityId)
        {
            UserId = userId;
            ActivityId = activityId;
        }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Activity")]
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }

    }
}
