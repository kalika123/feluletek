using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Task
    {

        public Task() { }

        public string title { get; set; }


        public string descript { get; set; }
        
        public void setPriority(int p){
            switch(p){
                case 1: 
                    priority = "Low";
                    break;
                case 2:
                    priority = "Medium";
                    break;
                case 3:
                    priority = "High";
                    break;
                default:
                    priority = "Low";
                    break;
            }
        }

        public string priority { get; set; }


    }
}
