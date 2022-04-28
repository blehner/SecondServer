using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondServer
{
    public class Asset
    {
        public int AssetId { get; set; }
        public string AssetName { get; set; }
        public string AssetLocation { get; set; }
        public int AssetMainCategory { get; set; }
        public int AssetSubCategory { get; set; }
    }
}
