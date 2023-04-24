namespace HotelProject.EntityLayer.Concretes.Identity
{
    using CoreLayer.Entity.Base;
    using Microsoft.AspNetCore.Identity;

    public class AppUser:IdentityUser<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? Picture { get; set; }

        public DateTime? BirthDay { get; set; }

        public int? Gender { get; set; }

        public int? City { get; set; }

        public string? YoutubeLink { get; set; }

        public string? TwitterLink { get; set; }

        public string? InstagramLink { get; set; }

        public string? FacebookLink { get; set; }

        public string? LinkedInLink { get; set; }

        public string? GitHubLink { get; set; }

        public string? WebsiteLink { get; set; }

    }
}
