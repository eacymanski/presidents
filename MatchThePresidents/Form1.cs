using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchThePresidents
{
    public partial class presidentsForm : Form
    {
        private static bool first=true;
        private static Label firstTurned;
        private static Label secondTurned;
        private static List<Label> labels;
        private static List<President> presidentsToUse;
        private static Timer timer;

        public presidentsForm()
        {
            InitializeComponent();         
        }

        private void presidentsForm_Load(object sender, EventArgs e)
        {
            List<President>presidents = President.getPresidents();
            difficultyPanel.Visible = true;
            presidentsPanel.Visible = false;
            difficultyPanel.Location = presidentsPanel.Location;
            difficultyPanel.Size = presidentsPanel.Size;
            this.Height = 560;
            this.Width = 540;
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += new EventHandler(timerEvent);
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            difficultyPanel.Visible = false;
            presidentsPanel.Visible = true;
            presidentsToUse = GetPresidentsToUse();
            labels = new List<Label>(){label1,label2,label3,label4,label5,
                        label6,label7,label8,label9,label10,label11,label12,
                        label13,label14,label15,label16};
            Random rand = new Random();
            foreach (President pres in presidentsToUse)
            {
                FixImage(pres);
                SetLabel(labels, pres.Name, rand);
                SetLabel(labels, pres.Pic,rand);
            }
        }

        private void moderateButton_Click(object sender, EventArgs e)
        {
            difficultyPanel.Visible = false;
            presidentsPanel.Visible = true;
            presidentsToUse = GetPresidentsToUse();
            labels = new List<Label>(){label1,label2,label3,label4,label5,
                        label6,label7,label8,label9,label10,label11,label12,
                        label13,label14,label15,label16};
            Random rand = new Random();
            foreach (President pres in presidentsToUse)
            {
                FixImage(pres);
                SetLabel(labels, pres.Name,rand);
                Random randType = new Random();
                int num = randType.Next(4);
                if (num == 1)
                {
                    SetLabel(labels, pres.Dates,rand);
                }
                else if (num == 2)
                {
                    SetLabel(labels, pres.Number.ToString(), rand);
                }
                else
                {
                    if (pres.Vice.Equals(""))
                    {
                        SetLabel(labels, pres.Pic,rand);
                    }
                    else
                    {
                        string text = string.Format("VP: {0}",pres.Vice);
                        SetLabel(labels, text,rand);
                    }
                }
            }
        }

        private void difficultButton_Click(object sender, EventArgs e)
        {
            difficultyPanel.Visible = false;
            presidentsPanel.Visible = true;
            presidentsToUse = GetPresidentsToUse();
            labels = new List<Label>(){label1,label2,label3,label4,label5,
                        label6,label7,label8,label9,label10,label11,label12,
                        label13,label14,label15,label16};
            Random rand = new Random();
            foreach (President pres in presidentsToUse)
            {
                FixImage(pres);
                Random randType = new Random();
                int num = randType.Next(1,4);
                int num2 = randType.Next(1,4);
                while (num == num2 || num*num2>8)
                {
                    num = randType.Next(4);
                }
                if (num == 1||num2==1)
                {
                    SetLabel(labels, pres.Dates, rand);
                }
                if (num == 2||num2==2)
                {
                    SetLabel(labels, pres.Number.ToString(), rand);
                }
                if(num>2||num2>2)
                {
                    if (pres.Vice.Equals(""))
                    {
                        SetLabel(labels, pres.Pic, rand);
                    }
                    else 
                    {
                        string text = string.Format("VP: {0}", pres.Vice);
                        SetLabel(labels, text, rand);
                    }
                }
               // MessageBox.Show(pres.Name + " " + num + " " + num2);
            }
            foreach (Label l in labels)
            {
                if (l.Text.Equals("") && l.Image == null)
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            try
            {
                label.Text = (string)label.Tag;
            }
            catch
            {
               label.Image = (Image)label.Tag;              
            }
            if (first)
            {
                first = false;
                firstTurned = label;
            }
            else
            {
                secondTurned = label;
                foreach (Label l in labels)
                {
                    l.Enabled = false;
                }
                first = true;
                President p1 = GetMatchingPresident(firstTurned);
                President p2 = GetMatchingPresident(label);
                if (!p1.Name.Equals(p2.Name))
                {
                    timer.Start();
                }              
                foreach (Label l in labels)
                {
                    l.Enabled = true;
                }
            }
        }

        private static President GetMatchingPresident(Label label)
        {
            President p;
            if (!label.Text.Equals(""))
            {
                p=presidentsToUse.Where(x => x.Name.Equals(label.Text)).FirstOrDefault();
                if (p == null)
                {
                    p = presidentsToUse.Where(x => x.Dates.Equals(label.Text)).FirstOrDefault();
                    if (p == null)
                    {
                        p = presidentsToUse.Where(x => x.Number.ToString().Equals(label.Text)).FirstOrDefault();
                        if (p == null)
                        {
                            p = presidentsToUse.Where(x => x.Vice.Equals(label.Text.Substring(4))).FirstOrDefault();
                        }
                    }
                }
            }
            else          
            {
                p=presidentsToUse.Where(x => x.Pic.Equals(label.Image)).FirstOrDefault();
                if (p == null)
                {
                    throw new Exception(label.Text);
                }
            }
            return p;
        }

        private static void SetLabel(List<Label> labels, object toTag, Random rand)
        {
            int num = rand.Next(labels.Count);
            Label nameLabel = labels[num];
            labels.RemoveAt(num);
            nameLabel.Tag = toTag;
        }

        private static List<President> GetPresidentsToUse()
        {
            List<President> presidents = President.getPresidents();
            List<President> presidentsToUse = new List<President>();
            Random rand = new Random(23);
            for (int i = 0; i < 8; i++)
            {
                int num = rand.Next(44 - i);
                presidentsToUse.Add(presidents[num]);
                presidents.RemoveAt(num);
            }
                return presidentsToUse;
        }

        private void timerEvent(object sender, EventArgs e)
        {
            firstTurned.Text = null;
            firstTurned.Image = null;
            secondTurned.Image = null;
            secondTurned.Text = null;           
            timer.Stop();
        }

        private static void FixImage(President p)
        {
            Image pic = (Image)p.Pic;
            Image fittedPic = (Image)new Bitmap(pic, 100, 100);
            p.Pic = fittedPic;
        }

        
    }
}
