using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace DatabasePrototype {
    /// <summary>
    /// Citizen class. Used to store a citizen in the Database.
    /// </summary>
    public class Citizen {
        public ObjectId Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public string WorkPlace { get; set; }
        public int XHome { get; set; }
        public int YHome { get; set; }

        public override string ToString() {
            return FName + " " + LName;
        }
    }
}
