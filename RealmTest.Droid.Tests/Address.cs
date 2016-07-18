using System;
//using PropertyChanged;
using System.Linq;
using Realms;
using System.Runtime.Serialization;
//using SQLite.Net.Attributes;
//using Newtonsoft.Json;
using System.ComponentModel;

namespace RealmTest.Droid.Tests {

	public class Address : RealmObject, /*ILocation,*/ INotifyPropertyChanged {
	
		public event PropertyChangedEventHandler PropertyChanged;
	
		public int id{ get; set; }
		public string name { get; set;}
		public string kind { get; set;}
		public string street { get; set;}
		public string city { get; set;}
		public string state { get; set;}
		public string country { get; set;}
		public int postal_code { get; set;}
		public double lon { get; set;}
		public double lat { get; set;}
		//[Ignored] // realm
		//public ILocation gps_location {
		//	get {
		//		return this as ILocation;
		//	}
	 //		set {
		//		lon = value.Longitude;
		//		lat = value.Latitude;
		//	}
		//}
		public string person { get; set;}
		//public Person owner { get; set;}

		public override string ToString() {
			return String.Join(", ", new string[] { street, city, state, country }.OfType<string>().ToArray());
			//return $"{street}, {city}, {state}, {country}";
		}
				
		//[IgnoreDataMember]
		//[Ignore]
		//[JsonIgnore]
		//double ILocation.Latitude {
		//	get {
		//		return lat;
		//	}
		//}
		//[IgnoreDataMember]
		//[Ignore]
		//[JsonIgnore]
		//double ILocation.Longitude {
		//	get {
		//		return lon;
		//	}
		//}
	}
}
