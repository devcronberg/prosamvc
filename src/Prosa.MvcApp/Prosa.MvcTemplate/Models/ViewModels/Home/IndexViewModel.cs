using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prosa.MvcTemplate.Models.ViewModels.Home
{
    public class IndexViewModel
    {
        public DateTime Nu { get; set; }
        public List<Person> Personer { get; set; }

        public string SettingAVærdi { get; set; }

    }
}
