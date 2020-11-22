using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RK2MIR.Models
{
    public class Partners//-News(m-m)
    {
        [Key]
        public int PartnerID { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }


        public void setPartnerID(int ID)
        {
            this.PartnerID = ID;
        }
        public int getPartnerID()
        {
            return this.PartnerID;
        }

        public void setCompanyName(string name)
        {
            this.CompanyName = name;
        }
        public string getCompanyName()
        {
            return this.CompanyName;
        }

        public void setDescription(string desc)
        {
            this.Description = desc;
        }
        public string getDescription()
        {
            return this.Description;
        }

        public void setLink(string link)
        {
            this.Link = link;
        }
        public string getLink()
        {
            return this.Link;
        }
    }
}
