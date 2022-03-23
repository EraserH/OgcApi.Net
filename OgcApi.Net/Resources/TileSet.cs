﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgcApi.Net.Resources
{
    public class TileSet
    {
        public string Title { get; set; }
        public Uri TileMatrixSetURI { get; set; }
        public string DataType { get; set; }
        public Uri Crs { get; set; }
        public List<Link> Links { get; set; }
        public List<TileMatrixLimits> TileMatrixSetLimits { get; set; }
    }
}
