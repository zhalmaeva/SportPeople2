using MeetingWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingWebsite.ModelsView.UserModels
{
    public class UserView
    {
        public UserView() { }


        public UserView(User user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Age = user.Age;
            Sex = user.Sex;
            City = user.City;
            Nickname = user.Nickname;
            Email = user.Email;
            PhoneNumber = user.PhoneNumber;
            Photos = user.Photos.Select(p => p.Path).ToList();
            BriefInformation = user.BriefInformation;
            _user = user;
        }
        private User _user {get;set;}
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string BriefInformation { get; set; }

        public List<string> Photos { get; set; }

        public User ToDbModel()
        {
            _user.FirstName = FirstName;
            _user.LastName = LastName;
            _user.Sex = Sex;
            _user.Nickname = Nickname;
            _user.Email = Email;
            _user.PhoneNumber = PhoneNumber;
            _user.City = City;
            _user.BriefInformation = BriefInformation;
            return _user;
        }
    }
}
