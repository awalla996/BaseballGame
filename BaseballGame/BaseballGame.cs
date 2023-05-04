using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseballGame
{
    public partial class BaseballGame : Form
    {
        Baseball game;
        public BaseballGame()
        {
            InitializeComponent();
            game = new Baseball();

            //HIDES ALL THINGS BEFORE THE PLAYER BEGINS BY HITTING PLAY BUTTON--------
            picBaseballField.Hide();
            picScoreboard.Hide();
            lblCompName.Hide();
            lblPlayerName.Hide();
            btnFullGame.Hide();
            btnInning.Hide();
            btnInningSwing.Hide();
            btnFullSwing.Hide();
            btnEnd.Hide();
            
            txtPlayer1st.Hide();
            txtPlayer2nd.Hide();
            txtPlayer3rd.Hide();
            txtPlayer4th.Hide();
            txtPlayer5th.Hide();
            txtPlayer6th.Hide();
            txtPlayer7th.Hide();
            txtPlayer8th.Hide();
            txtPlayer9th.Hide();
            txtPlayerFinal.Hide();

            txtComp1st.Hide();
            txtComp2nd.Hide();
            txtComp3rd.Hide();
            txtComp4th.Hide();
            txtComp5th.Hide();
            txtComp6th.Hide();
            txtComp7th.Hide();
            txtComp8th.Hide();
            txtComp9th.Hide();
            txtCompFinal.Hide();

            //MAKES TEXTBOXES ON SCOREBOARD READONLY--------
            txtPlayer1st.ReadOnly = true;
            txtPlayer2nd.ReadOnly = true;
            txtPlayer3rd.ReadOnly = true;
            txtPlayer4th.ReadOnly = true;
            txtPlayer5th.ReadOnly = true;
            txtPlayer6th.ReadOnly = true;
            txtPlayer7th.ReadOnly = true;
            txtPlayer8th.ReadOnly = true;
            txtPlayer9th.ReadOnly = true;
            txtPlayerFinal.ReadOnly = true;

            txtComp1st.ReadOnly = true;
            txtComp2nd.ReadOnly = true;
            txtComp3rd.ReadOnly = true;
            txtComp4th.ReadOnly = true;
            txtComp5th.ReadOnly = true;
            txtComp6th.ReadOnly = true;
            txtComp7th.ReadOnly = true;
            txtComp8th.ReadOnly = true;
            txtComp9th.ReadOnly = true;
            txtCompFinal.ReadOnly = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Hide();
            btnFullGame.Show();
            btnInning.Show();
            btnEnd.Show();
            MessageBox.Show("\t\tBaseball Game\n\n" +
                "The program will allow the user to simulate the entire game all at once or play the game simulating half an inning at a time. " +
                "There are 9 innings in a game of baseball. Each inning, both teams will take turns at bat and try to score as many runs as possible. " +
                "The game will simulate a half inning by allowing the team at bat to score as many runs as possible until they earn 3 outs.");

            picBaseballField.Show();
            picScoreboard.Show();
            lblCompName.Show();
            lblPlayerName.Show();

            txtPlayer1st.Show();
            txtPlayer2nd.Show();
            txtPlayer3rd.Show();
            txtPlayer4th.Show();
            txtPlayer5th.Show();
            txtPlayer6th.Show();
            txtPlayer7th.Show();
            txtPlayer8th.Show();
            txtPlayer9th.Show();
            txtPlayerFinal.Show();

            txtComp1st.Show();
            txtComp2nd.Show();
            txtComp3rd.Show();
            txtComp4th.Show();
            txtComp5th.Show();
            txtComp6th.Show();
            txtComp7th.Show();
            txtComp8th.Show();
            txtComp9th.Show();
            txtCompFinal.Show();
        }

        private void btnInning_Click(object sender, EventArgs e)
        {
            btnInningSwing.Show();
            btnInning.Hide();
            btnFullGame.Hide();
        }

        private void btnFullGame_Click(object sender, EventArgs e)
        {
            btnFullGame.Hide();
            btnInning.Hide();
            btnFullSwing.Hide();
        }

        private void btnInningSwing_Click(object sender, EventArgs e)
        {
            txtPlayer1st.Text = game.PlayerSwing.ToString();
            txtComp1st.Text = game.ComputerSwing.ToString();
        }

        private void btnFullSwing_Click(object sender, EventArgs e)
        {
            //NOT CODED YET
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            //HIDES ALL THINGS BEFORE THE PLAYER BEGINS BY HITTING PLAY BUTTON--------
            picBaseballField.Hide();
            picScoreboard.Hide();
            lblCompName.Hide();
            lblPlayerName.Hide();
            btnFullGame.Hide();
            btnInning.Hide();
            btnInningSwing.Hide();
            btnFullSwing.Hide();
            btnPlay.Show();
            btnEnd.Hide();

            txtPlayer1st.Hide();
            txtPlayer2nd.Hide();
            txtPlayer3rd.Hide();
            txtPlayer4th.Hide();
            txtPlayer5th.Hide();
            txtPlayer6th.Hide();
            txtPlayer7th.Hide();
            txtPlayer8th.Hide();
            txtPlayer9th.Hide();
            txtPlayerFinal.Hide();

            txtComp1st.Hide();
            txtComp2nd.Hide();
            txtComp3rd.Hide();
            txtComp4th.Hide();
            txtComp5th.Hide();
            txtComp6th.Hide();
            txtComp7th.Hide();
            txtComp8th.Hide();
            txtComp9th.Hide();
            txtCompFinal.Hide();

            //MAKES TEXTBOXES ON SCOREBOARD READONLY--------
            txtPlayer1st.Text = "";
            txtPlayer2nd.Text = "";
            txtPlayer3rd.Text = "";
            txtPlayer4th.Text = "";
            txtPlayer5th.Text = "";
            txtPlayer6th.Text = "";
            txtPlayer7th.Text = "";
            txtPlayer8th.Text = "";
            txtPlayer9th.Text = "";
            txtPlayerFinal.Text = "";

            txtComp1st.Text = "";
            txtComp2nd.Text = "";
            txtComp3rd.Text = "";
            txtComp4th.Text = "";
            txtComp5th.Text = "";
            txtComp6th.Text = "";
            txtComp7th.Text = "";
            txtComp8th.Text = "";
            txtComp9th.Text = "";
            txtCompFinal.Text = "";
        }
    }
}
