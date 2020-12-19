﻿/****************************************************************************
**				   SAKARYA ÜNİVERSİTESİ
**				   BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				   BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**				   2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje
**				ÖĞRENCİ ADI............: Ahmet Sefa Güver
**				ÖĞRENCİ NUMARASI.......: G181210042
**              DERSİN ALINDIĞI GRUP...: 2-A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndp_proje1
{
    public interface IAtik
    {
        int Hacim { get; }
        System.Drawing.Image Image { get; }
    }
    public interface IDolabilen
    {
        int Kapasite { get; set; }
        int DoluHacim { get; set; }
        int DolulukOrani { get; set; }
    }
    public interface IAtikKutusu : IDolabilen
    {
        /// <summary>
        /// Atık kutusu boşaltıldığında oyun puanına kaç puan ekleneceğini döndürür.
        /// </summary>
        int BosaltmaPuani { get; set; }
        /// <summary>
        /// Atık kutusunda gönderilen atığı alacak kadar boş yer varsa atığı kutuya ekler.
        /// </summary>
        /// <param name = "atik" > Eklenecek Atık</param>
        /// <returns>Atığın kutuya eklenip eklenmediğini döndürür.</returns>
        bool Ekle(IAtik atik);

        /// <summary>
        /// Atık kutusunun doluluk oranı %75'in üstündeyse atık kutusunu boşaltır.
        /// </summary>
        /// <returns>Atık kutusunun boşaltılıp boşaltılmadığını döndürür.</returns>
        bool Bosalt();
    }

}
