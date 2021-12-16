using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_ulamkowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            //do wyniku
            int wynikCalosci;
            int wynikLicznik;
            int wynikMianownik;

            //do NWW
            int pom;
            int a = int.Parse(mianownik1.Text);
            int b = int.Parse(mianownik2.Text);
            int NWW;

           

            while (b != 0)
            {
                pom = b;
                b = a % b;
                a = pom;
            }

            NWW = int.Parse(mianownik1.Text) /a * int.Parse(mianownik2.Text);

            //do licznika

            int licznik1;
            int licznik2;


            //Do liczb całych

            int liczbaCala1;
            int liczbaCala2;

            if(liczba1cala.Text == "")
            {
                liczbaCala1 = 0;
            }
            else
            {
                liczbaCala1 = int.Parse(liczba1cala.Text);
            }

            if (liczba2cala.Text == "")
            {
                liczbaCala2 = 0;
            }
            else
            {
                liczbaCala2 = int.Parse(liczba2cala.Text);
            }



            


            //dodawanie
            if (addButton.Checked)
            {

                licznik1 = NWW / int.Parse(mianownik1.Text);
                licznik1 = licznik1 * int.Parse(liczebnik1.Text);
                licznik2 = NWW / int.Parse(mianownik2.Text);
                licznik2 = licznik2 * int.Parse(liczebnik2.Text);

                wynikLicznik = licznik1 + licznik2;
                wynikCalosci = liczbaCala1 + liczbaCala2;
                while (wynikLicznik >= NWW)
                {
                    wynikLicznik = wynikLicznik - NWW;
                    wynikCalosci += 1;
                }

                if (wynikLicznik == 0)
                {
                    wynikMianownikTxt.Text = 0.ToString();
                    wynikLicznikTxt.Text = wynikLicznik.ToString();
                    wynikCala.Text = wynikCalosci.ToString();
                }
                else
                {


                    while (NWW % a == 0 && wynikLicznik % a == 0)
                    {
                        NWW = NWW / a;
                        wynikLicznik = wynikLicznik / a;
                    }
                    

                    wynikCala.Text = wynikCalosci.ToString();


                    wynikMianownikTxt.Text = NWW.ToString();


                    wynikLicznikTxt.Text = wynikLicznik.ToString();
                }
            }
            //odejmowanie
            else if (substractButton.Checked)
            {
                licznik1 = NWW / int.Parse(mianownik1.Text);
                licznik1 = licznik1 * int.Parse(liczebnik1.Text);
                licznik2 = NWW / int.Parse(mianownik2.Text);
                licznik2 = licznik2 * int.Parse(liczebnik2.Text);


                wynikLicznik = licznik1 - licznik2;
                wynikCalosci = liczbaCala1 - liczbaCala2;
                while (wynikLicznik >= NWW)
                {
                    wynikLicznik = wynikLicznik - NWW;
                    wynikCalosci += 1;
                }

                if(wynikLicznik < 0)
                {
                    wynikCalosci = wynikCalosci - 1;
                    wynikLicznik = wynikLicznik + NWW;
                }

                if (wynikLicznik == 0)
                {
                    wynikMianownikTxt.Text = 0.ToString();
                    wynikLicznikTxt.Text = wynikLicznik.ToString();
                    wynikCala.Text = wynikCalosci.ToString();
                }
                else
                {

                    wynikCala.Text = wynikCalosci.ToString();


                    wynikMianownikTxt.Text = NWW.ToString();


                    wynikLicznikTxt.Text = wynikLicznik.ToString();
                }
            }
            //mnożenie
            else if (timesButton.Checked)
            {
                licznik1 = int.Parse(liczebnik1.Text);
                licznik2 = int.Parse(liczebnik2.Text);



                licznik1 = licznik1 + liczbaCala1 * int.Parse(mianownik1.Text);
                licznik2 = licznik2 + liczbaCala2 * int.Parse(mianownik2.Text);
                wynikLicznik = licznik1 * licznik2;
                wynikMianownik = int.Parse(mianownik1.Text) * int.Parse(mianownik2.Text);
                wynikCalosci = 0;
                while (wynikLicznik >= wynikMianownik)
                {
                    wynikLicznik = wynikLicznik - wynikMianownik;
                    wynikCalosci += 1;
                }

                if (wynikLicznik == 0)
                {
                    wynikMianownikTxt.Text = 0.ToString();
                    wynikLicznikTxt.Text = wynikLicznik.ToString();
                    wynikCala.Text = wynikCalosci.ToString();
                }
                else
                {

                    wynikCala.Text = wynikCalosci.ToString();


                    wynikMianownikTxt.Text = wynikMianownik.ToString();


                    wynikLicznikTxt.Text = wynikLicznik.ToString();
                }
            }
            //dzielenie
            else if (divideButton.Checked)
            {
                licznik1 = int.Parse(liczebnik1.Text);
                licznik2 = int.Parse(liczebnik2.Text);



                licznik1 = licznik1 + liczbaCala1 * int.Parse(mianownik1.Text);
                licznik2 = licznik2 + liczbaCala2 * int.Parse(mianownik2.Text);
                wynikLicznik = licznik1 * int.Parse(mianownik2.Text);
                wynikMianownik = licznik2 * int.Parse(mianownik1.Text);
                wynikCalosci = 0;
                while (wynikLicznik >= wynikMianownik)
                {
                    wynikLicznik = wynikLicznik - wynikMianownik;
                    wynikCalosci += 1;
                }

                if (wynikLicznik == 0)
                {
                    wynikMianownikTxt.Text = 0.ToString();
                   wynikLicznikTxt.Text = wynikLicznik.ToString();
                    wynikCala.Text = wynikCalosci.ToString();
                }
                else
                {

                    wynikCala.Text = wynikCalosci.ToString();


                    wynikMianownikTxt.Text = wynikMianownik.ToString();


                    wynikLicznikTxt.Text = wynikLicznik.ToString();
                 }
            }
            //Nie wybrano działania
            else
            {
                MessageBox.Show("Wybierz działanie");
            }
        }
    }
}
