namespace HotelProject.EntityLayer.Concretes
{
    using CoreLayer.Entity.Base;

    public class Testimonial : EntityBase, IEntity
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }
    }
}
