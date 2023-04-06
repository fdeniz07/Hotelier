namespace HotelProject.CoreLayer.Entity.Base
{
    public class EntityBase
    {
        // Base sinifimiz, tablolarimizdaki ortak alanlari tutar ve miras alan siniflar degisiklik isterlerse override anahtari ile degisiklik yapabilirler.

        // public int Id { get; set; }
        // public DateTime CreatedDate { get; set; }
        // public DateTime UpdatedDate { get; set; }

        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;

        public virtual string CreatedByName { get; set; } =
            "Admin"; //Olusturan kullanici degilse admin olarak default deger atanacak

        public virtual string ModifiedByName { get; set; } = "Admin";
        public virtual string Note { get; set; }

        public EntityBase()
        {
        }

        public EntityBase(int id) :
            this() //Varsa, ilk deger atamalari ya constructor üzerinden ya da property üzerinden yapilir.
        {
            //Id = id;
            Id = Guid.NewGuid();
            CreatedDate = ModifiedDate = DateTime.Now;
        }
    }
}
