using MeetingWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingWebsite.ModelsView.News
{
    public class AddNewView
    {
        public string Title { set; get; }

        public int UserId { set; get; }
        public string PhotoPath { get; set; }

        public string Text { get; set; }

        public long DateCreateUnix { get; set; }

        public DateTime DateCreate
        {
            get => DateTime.UnixEpoch.AddSeconds(DateCreateUnix);
            set => DateCreateUnix = (int)((value - DateTime.UnixEpoch).TotalSeconds);
        }
        
        public New ToDbModel()
        {
            return new New()
            {
                Title = Title,
                UserId= UserId,
                PhotoPath = PhotoPath,
                Text = Text,
                DateCreateUnix = DateCreateUnix,
                DateCreate = DateCreate,
            };
        }
    }
}
