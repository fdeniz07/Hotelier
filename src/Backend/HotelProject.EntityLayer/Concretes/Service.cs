namespace HotelProject.EntityLayer.Concretes
{
    using CoreLayer.Entity.Base;

    public class Service : EntityBase, IEntity
    {
        public string ServiceIcon { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
