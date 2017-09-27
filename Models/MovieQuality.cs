using System;
using System.Collections.Generic;
using System.Text;
using MediaBrowser.Controller.Entities.Movies;
using Statistics.Enum;

namespace statistics.Models
{
    public class MovieQuality
    {
        public List<Movie> Movies { get; set; }
        public VideoQuality Quality { get; set; }
    }
}
