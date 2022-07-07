using Factory_Abstract_Factory.Interfaces;
using Factory_Abstract_Factory.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Abstract_Factory.Factories
{
    public class MacFactory : IGUIFactory
    {
        public Button CreateButton() => new MacButton();

        public Checkbox CreateCheckBox() => new MacCheckbox();
    }
}
