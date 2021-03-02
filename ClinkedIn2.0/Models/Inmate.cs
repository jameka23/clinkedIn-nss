using System;
using System.Collections.Generic;

namespace ClinkedIn2._0.Models
{
	public class Inmate
	{
        public int Id { get; set; }
		public List<Services> Services { get; set; } = new List<Services>();
		public List<Interest> Interests { get; set; } = new List<Interest>();
		public List<Inmate> Friends { get; set; } = new List<Inmate>();
        public List<Inmate> Enemies { get; set; } = new List<Inmate>();
        public DateTime IncarcerationDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Crime { get; set; }
        public string Name { get; set; }
    }


    public enum Interest
	{
        Reading,
        Lying,
        Stealing,
        Gambling,
        Running
	};

    public enum Services
	{
        Cooking,
        Teaching,
        Drawing
	};
}
