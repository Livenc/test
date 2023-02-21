using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Organization
    {
        public Post[] doljnoist;
        public string NameOrganization;
        public decimal Budjet;

        public void VuplataZarplat()
        {
        //    for (int i = 0; i < doljnoist.Length - 1; i++)
        //    {
        //        Budjet -= doljnoist[i].zarplata;
        //    // doljnoist[i].zarplata = 0;
        //}
            foreach (var item in doljnoist)
            {
                Budjet -= item.zarplata;
            }

    }

        public int RabotaMasac(string project)
        {
            if(project == "Stan")
            {
                Budjet += 1000;
                return -1000;
            }else if (project == "-")
            {
                Budjet+= 1000;
                return +1000;
            }
            else
            {
                return 0;
            }
            
        }
        public Organization  (string NameOrganization,decimal Budjet, Post post)
        {
            this.NameOrganization = NameOrganization;
            this.Budjet = Budjet;
            doljnoist[0] = post;
        }
    }
}
