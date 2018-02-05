using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace flappyBirdRikito
{
    public partial class Form1 : Form
    {

        // for database
        // here you must change your own location of mdf(connection String)
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kimki\Documents\databaseRanking.mdf;Integrated Security=True;Connect Timeout=30");
        

        // set some core value
        int pipeSpeed = 5;
        int gravity = 4;
        int inScore = 0;

        // counter
        int counterStart = 0;

        // create random number
        System.Random r = new System.Random(1000);

        int randomNumber;

        // pipetop place randomly
        int pipeTopNum;
        // pipebottom
        int pipeBottomNum;


        public Form1()
        {
            InitializeComponent();

            // set the end screen labels and set invisible them
            gameTimer.Stop();
            endText1.Text = "Game Over!!";

            endText1.Visible = false;
            endText2.Visible = false;
            gameDesigner.Visible = false;
            scoreText.Visible = false;
            dataGridView1.Visible = false;

            gameDesigner.Visible = false;

            label1.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;


            // ranking
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            name1.Visible = false;
            name2.Visible = false;
            name3.Visible = false;
            score1.Visible = false;
            score2.Visible = false;
            score3.Visible = false;




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // we need 3 function that will be triggered by various events
        // 1, timer function 
        // 2, keydown function
        // 3, keyup function 
        // and Gameover function

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // first, invisible someLabel
            Explain1.Visible = false;
            Explain2.Visible = false;

            // these values will scroll the pipes to the left and drop the bird
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            flappybird.Top += gravity;
            scoreText.Text = inScore.ToString();

            if (pipeBottom.Left < -20)
            {
                pipeBottom.Left = 500;
                pipeBottom.Top = (240 + pipeBottomNum);
                inScore += 1;
            }
            else if (pipeTop.Left < -20)
            {
                pipeTop.Left = 500;
                pipeTop.Top = (0 - pipeTopNum);
                inScore += 1;
            }
            //Bounds check for height and width of each of the picture box. 
            //Intersects with will check the height
            //and width of another picture against the first one and check to see if they are colliding. 
            if (flappybird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
            else if (flappybird.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                endGame();
            }
            else if (flappybird.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                endGame();
            }
            else if (flappybird.Top < 0)
            {
                endGame();
            }

        }

        public void endGame()
        {
            gameTimer.Stop();
            scoreText.Visible = false;

            endText2.Text = "Your final score : " + inScore.ToString();
            Explain1.Text = "Restart : Click Display";
            endText1.Visible = true;
            endText2.Visible = true;
            
            gameDesigner.Visible = true;

            


            // check this user break the record or not
            if (checkRanking() == 0)
            {
                // user couldnt break the record
                // just show Record 
                showRanking();

            }
            else
            {
                // user break the 3rd record
                // delete 3rd one, and add new 3rd
                // ====>> when user breaks record, always delete 3rd              

                label1.Visible = true;
                textBox1.Visible = true;
                button1.Visible = true;

                MessageBox.Show("YOU BREAK THE RECORD,PLEASE ENTER THE NAME");

            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -4;
            }

            // random integer
            randomNumber = r.Next(200);
            pipeTopNum = r.Next(100);
            pipeBottomNum = r.Next(100);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 4;
            }

            // random integer
            randomNumber = r.Next(200);

            pipeTopNum = r.Next(100);
            pipeBottomNum = r.Next(100);

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (counterStart == 0)
            {
                gameTimer.Start();
            }
            else
            {
                Restart();
            }

            counterStart++;
        }

        public static void Restart()
        {
            Application.Restart();
        }


        // ----------------- //
        // database(ranking) //
        // ----------------- //

        public int checkRanking()
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "select * from rankingtable";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            DataRow[] foundrow;
            string rank1 = "rank = 1";
            string rank2 = "rank = 2";
            string rank3 = "rank = 3";

            foundrow = dt.Select(rank1);
            string rank1score = foundrow[0][2].ToString();

            if (Convert.ToInt32(scoreText.Text) > Convert.ToInt32(rank1score))
            {
                cn.Close();
                endText2.Text = "You came 1st in this GAME!";
                return 1;
            }

            foundrow = dt.Select(rank2);
            string rank2score = foundrow[0][2].ToString();

            if (Convert.ToInt32(scoreText.Text) > Convert.ToInt32(rank2score))
            {
                cn.Close();
                endText2.Text = "You came 2nd in this GAME!";
                return 2;
            }

            foundrow = dt.Select(rank3);
            string rank3score = foundrow[0][2].ToString();

            if (Convert.ToInt32(scoreText.Text) > Convert.ToInt32(rank3score))
            {
                cn.Close();
                endText2.Text = "You came 3rd in this GAME!";
                return 3;
            }



            cn.Close();
            return 0;




            
        }



        public void addRecord(int rank)
        {

            string rankman = rank.ToString();
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "insert into rankingtable values('" + Convert.ToInt32(rankman) + "','" + textBox1.Text + "','" + Convert.ToInt32(scoreText.Text) + "')";
            cmd.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("BREAK THE RECORD!!!!!");
            
        }

        public void deleteRecord()
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "delete from rankingtable where rank = 3";
            cmd.ExecuteNonQuery();
            cn.Close();

        }

        public void modifyRecord(int rank)
        {
            string previousRank = rank.ToString();
            string newRank = (rank + 1).ToString();

            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "update rankingtable set rank = '"+Convert.ToInt32(newRank)+"' where rank = '"+Convert.ToInt32(previousRank)+"'";
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void showRanking()
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "select * from rankingtable";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            DataRow[] foundrow;
            string rank1 = "rank = 1";
            string rank2 = "rank = 2";
            string rank3 = "rank = 3";

            foundrow = dt.Select(rank1);
            name1.Text = foundrow[0][1].ToString();
            score1.Text = foundrow[0][2].ToString();

            foundrow = dt.Select(rank2);
            name2.Text = foundrow[0][1].ToString();
            score2.Text = foundrow[0][2].ToString();

            foundrow = dt.Select(rank3);
            name3.Text = foundrow[0][1].ToString();
            score3.Text = foundrow[0][2].ToString();

            cn.Close();

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            name1.Visible = true;
            name2.Visible = true;
            name3.Visible = true;
            score1.Visible = true;
            score2.Visible = true;
            score3.Visible = true;


        }


        // button
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkRanking() == 3)
            {
                deleteRecord();
                addRecord(3);
                showRanking();
            }
            else if (checkRanking() == 2)
            {
                deleteRecord();
                // 2nd record would go to 3rd
                // 2nd => 3rd
                // newRecord => 2nd
                modifyRecord(2);
                addRecord(2);
                showRanking();
            }else if (checkRanking() == 1)
            {
                deleteRecord();

                modifyRecord(2);
                modifyRecord(1);
                addRecord(1);
                showRanking();
            }

            button1.Visible = false;
            textBox1.Visible = false;
            label1.Visible = false;

        }
    }
}
