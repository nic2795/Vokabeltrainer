using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Diagnostics.Eventing.Reader;

namespace Vokabeltrainer
{
    public partial class Form1 : Form
    {
        string selectedTranslation;
        string[] vocabularyArray;
        Dictionary<string, string> woerterbuch = new Dictionary<string, string>();
        KeyValuePair<string, string> activeVoc = new KeyValuePair<string, string>();
        int rightCounter, wrongCounter = 0;

        public Form1()
        {
            InitializeComponent();
            lblErgebnis.Text = "";
        }
       



        private void WahlCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                woerterbuch.Clear();

                //gewählte übersetzung 
                selectedTranslation = cboSelectLanguage.Text;

                //Vokabelliste laden
                if (cboSelectLanguage.Text.Contains("EN"))
                {
                    vocabularyArray = File.ReadAllLines($"{AppDomain.CurrentDomain.BaseDirectory}//VokaleblisteDE_EN.txt");
                }
                if (cboSelectLanguage.Text.Contains("FR"))
                {
                    vocabularyArray = File.ReadAllLines($"{AppDomain.CurrentDomain.BaseDirectory}//VokaleblisteDE_FR.txt");
                }
                if (cboSelectLanguage.Text.Contains("SP"))
                {
                    vocabularyArray = File.ReadAllLines($"{AppDomain.CurrentDomain.BaseDirectory}//VokaleblisteDE_SP.txt");
                }

                //Dic. mit Vokablen befüllen
                if (vocabularyArray != null)
                {
                    foreach (var line in vocabularyArray)
                    {
                        var entry = line.Split(';');
                        woerterbuch.Add(entry[0], entry[1]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnWeiter_Click(object sender, EventArgs e)
        {
            string input = txtVokabelAntwort.Text;
            if (!string.IsNullOrWhiteSpace(input))
            {
                if ($"{activeVoc.Key}{activeVoc.Value}".Contains(input.Trim()))
                {
                    lblErgebnis.Text = "Richtig :)";
                    lblErgebnis.ForeColor = Color.Green;
                    rightCounter += 1;
                }
                else
                {
                    lblErgebnis.Text = "Falsch :(";
                    lblErgebnis.ForeColor = Color.Red;
                    wrongCounter += 1;
                }

                activeVoc = GetRadomWordFromDic();

                ShowWord();
                txtVokabelAntwort.Text = string.Empty;
                
            }
        }

        private void cmdBeenden_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Richtig: {rightCounter.ToString()} \r\nFalsch: {wrongCounter.ToString()}", "Ergebnis");
            cboSelectLanguage.Text = "";
            txtVokabelVorgabe.Text = "";
            rightCounter = 0;
            wrongCounter = 0;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            activeVoc = GetRadomWordFromDic();

            ShowWord();
        }

        private KeyValuePair<string, string> GetRadomWordFromDic()
        {
            if (woerterbuch != null && woerterbuch.Count > 0)
            {
                Random rnd = new Random();
                var randomEntry = woerterbuch.ElementAt(rnd.Next(0, woerterbuch.Count));

                return randomEntry;
            }
            else
                throw new Exception("Kein Wörterbuch ausgewählt.");
        }

        private void ShowWord()
        {
            //Zufallswert anzeigen
            if (selectedTranslation.StartsWith("DE"))
            {
                txtVokabelVorgabe.Text = activeVoc.Key;
            }
            else
            {
                txtVokabelVorgabe.Text = activeVoc.Value;
            }
        }
    }
}
