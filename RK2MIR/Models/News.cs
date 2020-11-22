using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RK2MIR.Models
{
    public class News//-Partners(m-m). Food(1-1)
    {
        //add image + also in food model
        public int NewsID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        //add link to the food/company

        public void setNewsID(int ID)
        {
            this.NewsID = ID;
        }
        public int getID()
        {
            return this.NewsID;
        }

        public void setTitle(string Title)
        {
            this.Title = Title;
        }
        public string getTitle()
        {
            return this.Title;
        }

        public void setText(string Text)
        {
            this.Text = Text;
        }
        public string getText()
        {
            return this.Text;
        }
    }
}
