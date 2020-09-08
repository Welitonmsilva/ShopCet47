using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCet47.Web.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DisplayFormat(DataFormatString ="{0:C2}",ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name="Image")]
        public string ImageUrl { get; set; }

        [Display(Name= "Last Purchase")]
        public DateTime LastPurchase { get; set; } 

        // como se ver na tabela
        [Display(Name = "Last Sale")]
        public DateTime Lastsale { get; set; }

        [Display(Name = "Is Availble")]
        public bool Isavailble { get; set; }

        //Forma como guarda a tabela duas casas decimais
        [DisplayFormat(DataFormatString ="{0:N2}",ApplyFormatInEditMode = false)]        
        public Double Stock { get; set; }




    }
}
