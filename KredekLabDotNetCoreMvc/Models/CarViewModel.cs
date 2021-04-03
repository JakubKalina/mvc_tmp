using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KredekLabDotNetCoreMvc.Models
{
    public class CarViewModel
    {
        /// <summary>
        /// Konstruktor z parametrami
        /// </summary>
        /// <param name="model"></param>
        /// <param name="manufacturer"></param>
        /// <param name="price"></param>
        /// <param name="photo"></param>
        public CarViewModel(string model, string manufacturer, decimal price, string photo)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Photo = photo;
        }
        /// <summary>
        /// Model
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Marka
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// Cena
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Zdjęcie
        /// </summary>
        public string Photo { get; set; }
    }
}
