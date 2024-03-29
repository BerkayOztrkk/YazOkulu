﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dene;
using DataAccesLayer;

namespace BusinessLogicLayer
{
    public class BLLogrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.Ad != null && p.Soyad!=null && p.Numara!=null && p.Sifre!=null && p.Fotograf!=null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
        public static List<EntityOgrenci> BllListele()
        {
            return DALOgrenci.OgrenciListesi();

        }
        public static bool OgrenciSilBLL(int s)
        {
            if (s >= 0)
            {
                return DALOgrenci.OgrenciSil(s);
            }
            return false;
        }
        public static List<EntityOgrenci> BllDetay(int d)
        {
            return DALOgrenci.OgrenciDetay(d);

        }
        public static bool OgrenciGuncelleBLL(EntityOgrenci p)
        {
            if (p.Ad != null && p.Soyad!=null && p.Numara!=null && p.Sifre!=null && p.Fotograf!=null && p.Id>0)
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
    }
}
