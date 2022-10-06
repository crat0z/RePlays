using RePlays.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RePlays.Classes.Services.Hotkeys
{
    public class ObsHotKey : Hotkey
    {

        

        public ObsHotKey(string name) : base(name) { }

        public override void Action()
        {
            
        }

        protected override void SetKeybind()
        {
            string[] keybind;
            SettingsService.Settings.keybindings.TryGetValue(key, out keybind);
            _keybind = ParseKeys(key, keybind);
        }
    }
}
