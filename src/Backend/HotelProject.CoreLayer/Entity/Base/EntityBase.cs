namespace HotelProject.CoreLayer.Entity.Base
{
    public abstract class EntityBase
    {
        // Base sinifimiz, tablolarimizdaki ortak alanlari tutar ve miras alan siniflar degisiklik isterlerse override anahtari ile degisiklik yapabilirler.

        // public int Id { get; set; }
        // public DateTime CreatedDate { get; set; }
        // public DateTime UpdatedDate { get; set; }

        //public virtual Guid Id { get; set; } = Guid.NewGuid();
        public virtual int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;
        public virtual string CreatedByName { get; set; } = "Admin"; //Olusturan kullanici degilse admin olarak default deger atanacak
        public virtual string ModifiedByName { get; set; } = "Admin";
        public virtual string Note { get; set; }

        public EntityBase()
        {
            CreatedDate = ModifiedDate = DateTime.Now;
            IsActive = true;
            IsDeleted = false;
            CreatedByName = "Admin";
            ModifiedByName = "Admin";
            Note = "null";
        }

        public EntityBase(int id) : this() //Varsa, ilk deger atamalari ya constructor üzerinden ya da property üzerinden yapilir.
        {
            Id = id;
            //if (id == Guid.Empty) Id = Guid.NewGuid();
            CreatedDate = ModifiedDate = DateTime.Now;

        }
    }
}
