﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    /*
     KATMANLI MIMARI de projenşn iş yükünün parçalara ayrıldıgını soylemıstık
     Entity'de code fırst yaklasımına göre classlarla tablolarımızı olusturduk
     İlişkiler , primary key etc de buna dahil...
    
     */
    public class product
    {

        [Key]
        public int productid { get; set; }
        [StringLength(50)]
        public string productname { get; set; }

        public int stok { get; set; }

        public virtual categories Kategoriler { get; set; }



    }
}
