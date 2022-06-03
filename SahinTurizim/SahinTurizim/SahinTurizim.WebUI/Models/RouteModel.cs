using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SahinTurizim.Entity;

namespace SahinTurizim.WebUI.Models
{
    public class RouteModel
    {

        public int RouteId { get; set; }

        [Required(ErrorMessage = "Lütfen başlangıç noktasını seçiniz!")]
        public string StartTerminal { get; set; }

        [Required(ErrorMessage = "Lütfen ilk durağı seçiniz!")]
        public string FirstTerminal { get; set; }

        [Required(ErrorMessage = "Lütfen ikinci durağı seçiniz!")]
        public string SecondTerminal { get; set; }

        [Required(ErrorMessage = "Lütfen üçüncü durağı seçiniz!")]
        public string ThirdTerminal { get; set; }

        [Required(ErrorMessage = "Lütfen bitiş noktasını seçiniz!")]
        public string EndTerminal { get; set; }

        [Required(ErrorMessage = "Lütfen tarih seçiniz!")]
        public string Date { get; set; }

        [Required(ErrorMessage = "Lütfen saat bilgisini giriniz!")]
        public string Hour { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat bilgisini giriniz!")]
        public double Price { get; set; }
        public List<City> Cities { get; set; }

    }
}
