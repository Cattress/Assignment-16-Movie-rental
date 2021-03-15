using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_16_Movie_rental
{
    public partial class Form1 : Form   //inheritance from form class
    {
        Movie[] movies;

        public Form1() //constructor 
        {
            InitializeComponent();
            movies = new Movie[5];
            {
                new Movie("m1", 120);
                new Movie("m2", 60);
                new Movie("m3", 15);
                new Movie("m4", 20);
                new Movie("m5", 145);
            }
        }

        public void AddMovies()
        { 
        
            for(int i =0; i < movies.Length; i++)
            {
                string name = movies[i].GetName();
                MoviePicker.Items.Add(name); //adds to the dropdown box
            }
        }

        private void MoviePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = MoviePicker.SelectedIndex;

            MessageBox.Show(i.ToString());

            Movie ChosenMovie = movies[i];

            // MessageBox.Show(ChosenMovie.GetName()); for testing

            MovieNameLabel.Text = ChosenMovie.GetName();
            MovieLengthLabel.Text = ChosenMovie.GetLength();


        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {
            int i = MoviePicker.SelectedIndex;
            MessageBox.Show(i.ToString());

            ChosenMovie.BorrowMovie();
            MovieAvailableLabel.Text = ChosenMovie.isAvailable().ToString();


        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {

            int i = MoviePicker.SelectedIndex;
            MessageBox.Show(i.ToString());


        }
    }
}
