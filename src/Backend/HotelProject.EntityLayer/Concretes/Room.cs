namespace HotelProject.EntityLayer.Concretes
{
    using CoreLayer.Entity.Base;

    public class Room : EntityBase, IEntity
    {
        public string RoomNumber { get; set; }

        public string RoomCoverImage { get; set; }

        public double Price { get; set; }

        public string Title { get; set; }

        public int BedCount { get; set; }

        public int BathCount { get; set; }

        public bool Wifi { get; set; }

        public string Description { get; set; }

        public Room()
        {
        }

        public Room(int id, string roomNumber) : this()
        {
            Id = id;
            RoomNumber = roomNumber;
        }
    }
}