using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW.Models
{
    public class SimpleModel
    {
        private string Name { get; set; }

        public SimpleModel(string name)
        {
            this.Name = name;
        }
    }
}