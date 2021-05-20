using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace zombie_shooter
{
    class DAN
    {
        public string direction; 
        public int speed = 30;
        PictureBox Bullet = new PictureBox(); 
        Timer tm = new Timer(); 

        public int bulletLeft;
        public int bulletTop;
      

        // end of the variables

        public void mkBullet(Form form)
        {
            Bullet.BackColor = Color.White; 
            Bullet.Size = new Size(5, 5); 
            Bullet.Tag = "bullet"; // set the tag to bullet
            Bullet.Left = bulletLeft; 
            Bullet.Top = bulletTop; 
            Bullet.BringToFront(); 
            //thêm đạn vào form
            form.Controls.Add(Bullet); // add the bullet to the screen

            tm.Interval = speed; // set the timer interval to speed
            //thời gian đạn bắn ra
            tm.Tick += new EventHandler(tm_Tick); // assignment the timer with an event
            tm.Start(); // start the timer

        }

        public void tm_Tick(object sender, EventArgs e)
        {
            // if direction equals to left
            if (direction == "left")
            {
                Bullet.Left -= speed; // move bullet towards the left of the screen
            }
            // if direction equals right
            if (direction == "right")
            {
                Bullet.Left += speed; // move bullet towards the right of the screen
            }
            // if direction is up
            if (direction == "up")
            {
                Bullet.Top -= speed; // move the bullet towards top of the screen
            }
            // if direction is down
            if (direction == "down")
            {
                Bullet.Top += speed; // move the bullet bottom of the screen
            }

            //tỉ lệ khung hình khi player lại gần khung viền
            if (Bullet.Left < 16 || Bullet.Left > 860 || Bullet.Top < 10 || Bullet.Top > 616)
            {
                tm.Stop(); // stop the timer
                tm.Dispose(); // dispose the timer event and component from the program
                Bullet.Dispose(); // dispose the bullet
                tm = null; // nullify the timer object
                Bullet = null; // nullify the bullet object
            }
        }
    }
}
