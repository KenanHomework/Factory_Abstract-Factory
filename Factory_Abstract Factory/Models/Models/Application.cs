using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Abstract_Factory.Models.Models
{
    public class Application
    {
        public IGUIFactor Factory { get; set; }

        public Button Button { get; set; }

        public Application(IGUIFactor factory)
        {
            Factory = factory;
        }

        public void CreateUI() { }

        public void Paint() { }
    }
}
