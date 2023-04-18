using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.CoreLayer.Entity.Base
{
    public abstract class DtoGetBase
    {
       // public virtual ResultStatus ResultStatus { get; set; } // Burada ResultStatus dönmemizin nedeni Frontend tarafindan jquery ajax kullanirsak orada da sonuc kümesi dönmek isteyebiliriz

        public virtual string Message { get; set; }

        public virtual int CurrentPage { get; set; } = 1;  //Sayfalama yapisi icin ilk deger atamasi

        public virtual int PageSize { get; set; } = 6; // Sayfalama basina düsecek degerler

        public virtual int TotalCount { get; set; } //Toplam Entity sayisi

        public virtual int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalCount, PageSize));  //Toplam Sayfa Sayisi

        public virtual bool ShowPrevious => CurrentPage > 1; // Geri tusu

        public virtual bool ShowNext => CurrentPage < TotalPages; // Ileri tusu

        public virtual bool IsAscending { get; set; } = false;
    }
}
