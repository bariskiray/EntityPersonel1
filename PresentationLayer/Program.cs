using BusinessLayer_;
using BusinessLayer_.BL_Abstract;
using DataAccessLayer_;
using DataAccessLayer_.DA_Abstract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;


namespace PresentationLayer
{
    public class Program
    {
        readonly IBirimlerService_ birimlerService;

        static void Main(string[] args)
        {

           


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




            foreach (var item in vpbm.GetAll())
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
            




        }
    }
}
