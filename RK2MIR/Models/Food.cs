using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RK2MIR.Models
{
    public class Food//-Order(m-1). News(1-1)
    {
        public Food(int FoodID, string Title, int Cost)
        {
            this.FoodID = FoodID;
            this.Title = Title;
            this.Cost = Cost;
        }

        public Food()
        {
        }

        public int FoodID { get; set; }
        public string Title { get; set; }
        public int Cost { get; set; }


        public void setFoodID(int ID)
        {
            this.FoodID = ID;
        }
        public int getFoodID()
        {
            return this.FoodID;
        }

        public void setTitle(string title)
        {
            this.Title = title;
        }
        public string getTitle()
        {
            return this.Title;
        }

        public void setCost(int cost)
        {
            this.Cost = cost;
        }
        public int getCost()
        {
            return this.Cost;
        }
    }
}
