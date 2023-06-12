using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeTask.Models
{
    public class MembersModel
    {
        public string Name { get; set; }
        public string Developer_Lang { get; set; }

        public MembersModel(string name, string devLang)
        {
            Name = name;
            Developer_Lang = devLang;
        }
    }

}