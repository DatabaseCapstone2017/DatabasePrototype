using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace DatabasePrototype {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        /// <summary>
        /// Purpose: Writes the inputs on the form to the database.
        /// Author: Michael
        /// Date: 2017-10-01
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateNewSubmit_Click(object sender, EventArgs e) {
            //Mongo client that connects to the localhost database. Leave blank!
            MongoClient client = new MongoClient();
            //The name of the database you are connecting to.
            var db = client.GetDatabase("Prototype");
            //Gets the name of the collection we are reading and writing objects to
            var collection = db.GetCollection<Citizen>("Citizens");
            var fNameTemp = textBoxCreateNewFirstName.Text.ToString();
            var lNameTemp = textBoxCreateNewLastName.Text.ToString();
            var workTemp = textBoxCreateNewWorkPlace.Text.ToString();
            var ageText = textBoxChangeAge.Text.ToString();
            var xCordText = textBoxChangeXCord.Text.ToString();
            var yCordText = textBoxChangeYCord.Text.ToString();
            int xTemp;
            int yTemp;
            int ageTemp;

            if (int.TryParse(ageText, out ageTemp)) {
                // It was a number and it has been already assigned to the variable "<code>number</code>"
            } else {
                //It was not actually a number
                //It will be this default value
                ageTemp = 45;
            }

            if(int.TryParse(xCordText, out xTemp)) {
                // Doesn't seem to work
            } else {
                // Default value
                xTemp = 32;
            }

            if(int.TryParse(yCordText, out yTemp)) {
                // Please work :'(
            } else {
                // Default value
                yTemp = 40;
            }

            //Writes the textbox information to the database
            collection.InsertOne(new Citizen {
                FName = fNameTemp,
                LName = lNameTemp,
                Age = ageTemp,
                WorkPlace = workTemp,
                XHome = xTemp,
                YHome = yTemp
            });
        }
    }
}
