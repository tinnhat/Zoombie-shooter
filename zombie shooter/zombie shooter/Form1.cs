using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace zombie_shooter
{
    public partial class Form1 : Form
    {
        DAN dan = new DAN();
        bool goup; 
        bool godown; 
        bool goleft;
        bool goright;
        string facing = "up"; //khi bắt đầu hướng của nhân vật hướng lên
        double playerHealth = 100; //máu của nhân vật
        int speed = 10; //tốc độ của gameplay
        int ammo = 10; //số lượng đạn
        int zombieSpeed = 3;//tốc dộ di chuyển và xuất hiện cuả zombie
        int score = 0;
        bool gameOver = false; 
        Random rnd = new Random();

        //tạo ra danh sách mấy cái hình zombie
        List<PictureBox> zombieList = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
            //restart_game();
            //start_game();
            //Game_menu.Hide();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1) // if player health is greater than 1
            {
                progressBarHeal.Value = Convert.ToInt32(playerHealth); // assign the progress bar to the player health integer
            }
            else
            {
                // if the player health is below 1
                player.Image = Properties.Resources.dead; // show the player dead image
                player.SendToBack();
                timerGame.Stop(); // stop the timer
                gameOver = true; // change game over to true
                SoundPlayer splayer = new SoundPlayer(@"E:\C#\project game\zombie shooter\gameover.wav");
                splayer.Play();
                labelGame.Hide();
                labelGameOver.Show();
                labelRestart.Show();
                labelStart.Hide();
                Game_menu.Show();
            }

            labelAmmo.Text = "   Ammo:  " + ammo; 
            labelKill.Text = "Kills: " + score; 

           
            if (playerHealth < 20)
            {
                progressBarHeal.ForeColor = System.Drawing.Color.Red; // change the progress bar colour to red. 
            }

            if (goleft && player.Left > 0)
            {
                player.Left -= speed;
                
            }
            if (goright && player.Left + player.Width < 930)
            {
                player.Left += speed;
                
            }
            if (goup && player.Top > 60)
            {
                player.Top -= speed;
               
            }

            if (godown && player.Top + player.Height < 700)
            {
                player.Top += speed;
               
            }


            if (godown && player.Top + player.Height < 700)
            {
                player.Top += speed;
               
            }
            foreach(Control x in this.Controls)
            {
                //nhặt được đạn r cộng thêm 
                if(x is PictureBox && (string)x.Tag=="ammo")
                {
                    if(player.Bounds.IntersectsWith(x.Bounds)) //giới hạn đụng vào cảu hình player và hình hộp đạn
                    {
                        //cộng đạn và bỏ hình hộp đạn
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;

                    }    
                }
              
                if(x is PictureBox &&(string)x.Tag=="zombie")
                {
                    //trừ máu khi chạm trúng zombie
                    if(player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                     
                    }    
                    if(x.Left>player.Left)
                    {
                        //hiện ra bên trái player
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (x.Left < player.Left)
                    {
                        //hiện ra bên phải player
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top > player.Top)
                    {
                      
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (x.Top < player.Top)
                    {
                       
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                }  
                //kiểm tra đạn có trúng zom ko 
                foreach(Control j in this.Controls)
                {
                    if(x is PictureBox &&(string)j.Tag=="bullet"&&x is PictureBox && (string)x.Tag=="zombie")
                    {
                        if(x.Bounds.IntersectsWith(j.Bounds))
                        {
                            //bị bắn trúng xóa hình zom và cộng điểm
                            score++;
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            zombieList.Remove(((PictureBox)x));
                            tao_zombie();
                        }    
                    }    
                }    
            }    
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameOver) return; 

            
            if (e.KeyCode == Keys.Left)
            {
                goleft = true; 
                facing = "left"; 
                player.Image = Properties.Resources.left; 

            }

            
            if (e.KeyCode == Keys.Right)
            {
                goright = true; 
                facing = "right"; 
                player.Image = Properties.Resources.right; 

            }
            
           
            if (e.KeyCode == Keys.Up)
            {
                facing = "up"; // change facing to up
                goup = true; // change go up to true
                player.Image = Properties.Resources.up; // change the player image to up

            }

            // end of up key selection

            // if the down key is pressed then do the following
            if (e.KeyCode == Keys.Down)
            {
                facing = "down"; // change facing to down
                godown = true; // change go down to true
                player.Image = Properties.Resources.down; //change the player image to down

            }
            // end of the down key selection

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (gameOver) return; 
            if (e.KeyCode == Keys.Left)
            {
                goleft = false; 
            }

           
            if (e.KeyCode == Keys.Right)
            {
                goright = false; // change the go right boolean to false
            }
            // below is the key up selection for the up key
            if (e.KeyCode == Keys.Up)
            {
                goup = false; // change the go up boolean to false
            }
            // below is the key up selection for the down key
            if (e.KeyCode == Keys.Down)
            {
                godown = false; // change the go down boolean to false
            }

           
            if (e.KeyCode == Keys.Space && ammo>0) 
            {
                ammo--;
                shoot(facing);
                if (ammo<1)
                {
                    //nếu như còn dưới 1 viên đạn thì sẽ drop đạn thêm
                    dropAmmo();
                }    

                
            }
        }
        private void shoot(string direct)
        {
          

            DAN shoot = new DAN(); // create a new instance of the bullet class
            shoot.direction = direct; // assignment the direction to the bullet
            shoot.bulletLeft = player.Left + (player.Width / 2); // place the bullet to left half of the player
            shoot.bulletTop = player.Top + (player.Height / 2); // place the bullet on top half of the player
            shoot.mkBullet(this); // run the function mkBullet from the bullet class. 
            SoundPlayer splayer = new SoundPlayer(@"E:\C#\project game\zombie shooter\shoot.wav");
            splayer.Play();

        }
        private void tao_zombie()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            //tọa độ xuất hiện zombie
            zombie.Left = rnd.Next(0,850);
            zombie.Top = rnd.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombieList.Add(zombie);
            this.Controls.Add(zombie);
            player.BringToFront();


        }
        private void dropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = rnd.Next(10,this.ClientSize.Width-ammo.Width); //vị trí xuất hiện đạn random
            ammo.Top = rnd.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            //lúc nhặt đạn là hình đi xuyên qua 
            ammo.BringToFront();
            player.BringToFront();
        }
        private void start_game()
        {
            zombieList.Clear();
            for (int i = 0; i < 3; i++)
            {
                //vòng lặp tạo zom
                tao_zombie();
            }
            goup = false;
            godown = false;
            goleft = false;
            goright = false;
            gameOver = false;
            //reset máu lại ban đầu
            playerHealth = 100;
            score = 0;
            ammo = 10;
            timerGame.Start();
        }
        private void restart_game()
        {
            player.Image = Properties.Resources.up;
            foreach(PictureBox x in zombieList)
            {
                this.Controls.Remove(x);
            }
            //reset lại list zom
            zombieList.Clear();
            for(int i=0;i<3;i++)
            {
                //vòng lặp tạo zom
                tao_zombie();
            }
            goup = false;
            godown = false;
            goleft = false;
            goright = false;
            gameOver = false;
            //reset máu lại ban đầu
            playerHealth = 100;
            score = 0;
            ammo = 10;
            timerGame.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerGame.Stop();
            labelRestart.Hide();
            labelGameOver.Hide();
        }

        private void labelStart_Click(object sender, EventArgs e)
        {
            start_game();
          
            Game_menu.Hide();
        }

        private void labelQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelRestart_Click(object sender, EventArgs e)
        {
            restart_game();
            Game_menu.Hide();
        }
    }
}
