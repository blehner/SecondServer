using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondServer
{
    public class SubCategory
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public int SubCategoryLevel { get; set; }
        public int SubMainId { get; set; }
        public int SubCategoryWorkMinutes { get; set; }
        public int SubCategoryOccupation { get; set; }
        public int SubCategoryOpId { get; set; }

        //Forigner keys
        //subMainId
        //SubOccupation


    }
}
