using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codePractice
{
    public partial class Form1 : Form
    {

        List <BaseballPlayer> baseballPlayers = new List <BaseballPlayer> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string name= tbName.Text;
            string team= tbTeam.Text;
            string city= tbCity.Text;   
            string average= tbAverage.Text;
            string position = tbPosition.Text;

            BaseballPlayer bp= new BaseballPlayer(name, team, city, average, position);

           baseballPlayers.Add(bp);
            BaseballDisplay(baseballPlayers);

        }


        public void BaseballDisplay(List<BaseballPlayer> baseballPlayers)
        {
            rtbDisplay.Text = "";
            foreach(BaseballPlayer bp in baseballPlayers)
            {
                string message=( $"Name: {bp.Name}"+
                    $"\nTeam:{bp.Team}"+
                    $"\nCity:{bp.City}" +
                    $"\nAverage:{bp.Average}"+
                    $"\nPosition:{bp.Position}");


                rtbDisplay.Text+=message;
                rtbDisplay.Text += "\n\n";
            }
        }
    }
}
