using Factory_Abstract_Factory.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Abstract_Factory.Interfaces
{
    public interface IGUIFactory
    {
        public Button CreateButton();
        public Checkbox CreateCheckBox();


    }
}
