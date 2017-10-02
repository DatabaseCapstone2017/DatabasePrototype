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
using MongoDB.Bson;
using MongoDB.Driver.Core;

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
            var ageText = textBoxCreateNewAge.Text.ToString();
            var xCordText = textBoxCreateNewXCord.Text.ToString();
            var yCordText = textBoxCreateNewYCord.Text.ToString();
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

        private async void buttonRefreshDb_Click(object sender, EventArgs e)
        {
            listBoxCitizenList.Items.Clear();
            //Mongo client that connects to the localhost database. Leave blank!
            MongoClient client = new MongoClient();
            //The name of the database you are connecting to.
            var db = client.GetDatabase("Prototype");
            //Gets the name of the collection we are reading and writing objects to
            var collection = db.GetCollection<Citizen>("Citizens");

            var list = await collection.Find(new BsonDocument()).ToListAsync();
            
            foreach (var person in list)
            {
                listBoxCitizenList.Items.Add(person);
            }
        }

        private void listBoxCitizenList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mongo client that connects to the localhost database. Leave blank!
            MongoClient client = new MongoClient();
            //The name of the database you are connecting to.
            var db = client.GetDatabase("Prototype");
            //Gets the name of the collection we are reading and writing objects to
            var collection = db.GetCollection<Citizen>("Citizens");

            // Enable all the textboxes
            textBoxChangeFirstName.Enabled = true;
            textBoxChangeLastName.Enabled = true;
            textBoxChangeAge.Enabled = true;
            textBoxChangeWorkPlace.Enabled = true;
            textBoxChangeXCord.Enabled = true;
            textBoxChangeYCord.Enabled = true;
            buttonChange.Enabled = true;

            // Displays the citizens information
            textBoxChangeFirstName.Text = ((Citizen)listBoxCitizenList.SelectedItem).FName;
            textBoxChangeLastName.Text = ((Citizen)listBoxCitizenList.SelectedItem).LName;
            textBoxChangeAge.Text = ((Citizen)listBoxCitizenList.SelectedItem).Age.ToString();
            textBoxChangeWorkPlace.Text = ((Citizen)listBoxCitizenList.SelectedItem).WorkPlace;
            textBoxChangeXCord.Text = ((Citizen)listBoxCitizenList.SelectedItem).XHome.ToString();
            textBoxChangeYCord.Text = ((Citizen)listBoxCitizenList.SelectedItem).YHome.ToString();

        }

        private async void buttonChange_Click(object sender, EventArgs e)
        {
            //Mongo client that connects to the localhost database. Leave blank!
            MongoClient client = new MongoClient();
            //The name of the database you are connecting to.
            var db = client.GetDatabase("Prototype");
            //Gets the name of the collection we are reading and writing objects to
            var collection = db.GetCollection<Citizen>("Citizens");

            int updatedAge;
            int updatedXcoord;
            int updatedYcoord;

            if (int.TryParse(textBoxChangeAge.Text.ToString(), out updatedAge))
            {
            }
            else
            {
                //It was not actually a number
                //It will be this default value
                updatedAge = 45;
            }

            if (int.TryParse(textBoxChangeXCord.Text.ToString(), out updatedXcoord))
            {
            }
            else
            {
                // Default value
                updatedXcoord = 32;
            }

            if (int.TryParse(textBoxChangeYCord.Text.ToString(), out updatedYcoord))
            {
            }
            else
            {
                // Default value
                updatedYcoord = 40;
            }
            var filter = Builders<Citizen>.Filter.Eq("_id", ((Citizen)listBoxCitizenList.SelectedItem).Id);
            var update = Builders<Citizen>.Update
                .Set("FName", textBoxChangeFirstName.Text)
                .Set("LName", textBoxChangeLastName.Text)
                .Set("Age", updatedAge)
                .Set("WorkPlace", textBoxChangeWorkPlace.Text)
                .Set("XHome", updatedXcoord)
                .Set("YHome", updatedYcoord);
            var result = await collection.UpdateOneAsync(filter, update);

            // disable all the textboxes
            textBoxChangeFirstName.Enabled = false;
            textBoxChangeLastName.Enabled = false;
            textBoxChangeAge.Enabled = false;
            textBoxChangeWorkPlace.Enabled = false;
            textBoxChangeXCord.Enabled = false;
            textBoxChangeYCord.Enabled = false;
            buttonChange.Enabled = false;
            textBoxChangeFirstName.Text = "";
            textBoxChangeLastName.Text = "";
            textBoxChangeAge.Text = "";
            textBoxChangeWorkPlace.Text = "";
            textBoxChangeXCord.Text = "";
            textBoxChangeYCord.Text = "";

        }
    }
}
