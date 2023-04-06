namespace HotelProject.EntityLayer.Concretes
{
    using CoreLayer.Entity.Base;

    public class Staff : EntityBase, IEntity
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public string YoutubeLink { get; set; }

        public string TwitterLink { get; set; }

        public string InstagramLink { get; set; }

        public string FacebookLink { get; set; }

        public string LinkedInLink { get; set; }

    }
}
