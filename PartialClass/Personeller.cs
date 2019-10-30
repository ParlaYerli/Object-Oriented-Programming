using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    public partial class Personeller
    {
        // ctor partial classı
        public Personeller()
        {

        }
        public Personeller(Personeller personel)
        {
            PersonelEkle(personel);
        }
    }

    public partial class Personeller
    {// propertyleri tanımlama partial classı
        private string adi;
        private string soyadi;
        private int yas;
        private List<Personeller> personel = new List<Personeller>();
    }

    public partial class Personeller
    {//propertyler tanımlama classı
        public string Adi
        {
            get { return adi; }
            set { adi = value; }
        }

        public string Soyadi
        {
            get { return soyadi; }
            set { soyadi = value; }
        }

        public int Yas
        {
            get { return yas; }
            set { yas = value; }
        }

        public List<Personeller> Personel
        {
            get
            {
                return personel;
            }
        }
        public Personeller PersonelKayit
        {
            set
            {
                personel.Add(value);
            }
        }
    }
    
    public partial class Personeller
    {
        public void PersonelEkle(Personeller pers)
        {
            PersonelKayit = pers;
        }
    }
}
