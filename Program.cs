﻿using Entities_;
using 
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace EntityPersonel1
{
    static void Main(string[] args)
    {
        Birimler_Manager bm = new Birimler_Manager();
        Personel_Manager pm = new Personel_Manager();
        viewPersonelBirim_Manager vpbm = new viewPersonelBirim_Manager();
        // PersonellerManager pm = new PersonellerManager();
        // ViewPersonelBirimManager vpm = new ViewPersonelBirimManager();
        // Birimler b = new Birimler();
        //b.BirimID = 3;
        // b.BirimAdi = "Satın Alma";
        // bm.BLUpdate(b);
        // foreach (var item in bm.GetAll())
        // {
        //    Console.WriteLine("ID:  " + item.BirimID + " - Birim Adı: " + item.BirimAdi + " - Aciklama: " + item.Aciklama);

        // }
        //  foreach (var item in pm.GetAll())
        //{
        //    Console.WriteLine("ID:  " + item.PersonelID + " - Birim ID: " + item.BirimID + " - Adı Soyadı " + item.AdiSoyadi + " - Telefon: " + item.Telefon
        //   + " - Adres: " + item.Adres + " - Tarih: " + item.Tarih + " - Aktif mi: " + item.IsActive);
        // }
        //Console.WriteLine();
        //Console.WriteLine();
        //Console.WriteLine();
        //string personelname = "barış kıray";
        //
        /* foreach (var item in pm.GetByName(personelname)) {
            Console.WriteLine("ID:  " + item.PersonelID + " - Birim ID: " + item.BirimID + " - Adı Soyadı " + item.AdiSoyadi + " - Telefon: " + item.Telefon
               + " - Adres: " + item.Adres + " - Tarih: " + item.Tarih + " - Aktif mi: " + item.IsActive);
        }
        Console.WriteLine();
        Console.WriteLine();
        foreach (var item in vpm.GetAll())
        {
            Console.WriteLine("ID:  " + item.PersonelID + " - Birim ID: " + item.BirimID + " - Adı Soyadı " + item.AdiSoyadi + " - Telefon: " + item.Telefon
               + " - Adres: " + item.Adres + " - Tarih: " + item.Tarih + " - Aktif mi: " + item.IsActive + " - Birim Adı: " + item.BirimAdi);
        } */




        foreach (var item in pm.GetAll())
        {
            Console.WriteLine("ID:  " + item.PersonelID + " - Birim ID: " + item.BirimID + " - Adı Soyadı " + item.AdiSoyadi + " - Telefon: " + item.Telefon
               + " - Adres: " + item.Adres + " - Tarih: " + item.Tarih + " - Aktif mi: " + item.IsActive);
        }
        Console.WriteLine();
        Console.WriteLine();

        /* foreach (var item in vpbm.GetAll())
            {
                Console.WriteLine("ID:  " + item.PersonelID + " - Birim ID: " + item.BirimID + " - Adı Soyadı " + item.AdiSoyadi + " - Telefon: " + item.Telefon
       + " - Adres: " + item.Adres + " - Tarih: " + item.Tarih + " - Aktif mi: " + item.IsActive + " - Birim Adı: " + item.BirimAdi);
            } */
        //string personelname = "barış kıray";
        /* foreach (var item in pm.GetByName(personelname))
         {
             Console.WriteLine("ID:  " + item.PersonelID + " - Birim ID: " + item.BirimID + " - Adı Soyadı " + item.AdiSoyadi + " - Telefon: " + item.Telefon
                + " - Adres: " + item.Adres + " - Tarih: " + item.Tarih + " - Aktif mi: " + item.IsActive); */
        foreach (var item in pm.GetByName("barış kıray"))
        {
            Console.WriteLine("ID:  " + item.PersonelID + " - Birim ID: " + item.BirimID + " - Adı Soyadı " + item.AdiSoyadi + " - Telefon: " + item.Telefon
                   + " - Adres: " + item.Adres + " - Tarih: " + item.Tarih + " - Aktif mi: " + item.IsActive);
        }
        Console.WriteLine();
        Console.WriteLine();

        foreach (var item in pm.GetByName("asya arifoğlu"))
        {
            Console.WriteLine("ID:  " + item.PersonelID + " - Birim ID: " + item.BirimID + " - Adı Soyadı " + item.AdiSoyadi + " - Telefon: " + item.Telefon
                   + " - Adres: " + item.Adres + " - Tarih: " + item.Tarih + " - Aktif mi: " + item.IsActive);
        }





    }

}
