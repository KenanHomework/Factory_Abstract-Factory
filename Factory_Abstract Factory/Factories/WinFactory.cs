using Factory_Abstract_Factory.Interfaces;
using Factory_Abstract_Factory.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Abstract_Factory.Factories
{
    public class WinFactory : IGUIFactory
    {
        public Button CreateButton() => new WinButton();

        public Checkbox CreateCheckBox() => new WinCheckbox();
    }
}
