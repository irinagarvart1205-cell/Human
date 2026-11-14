using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human.Classes
{
    public class Phrase
    {
        public string _Phrase { get; set; }
        public string Scr {  get; set; }
        public Phrase(string Phrase, string Scr) { 
            this._Phrase = Phrase;
            this.Scr = Scr;
                    
        }
    }
}
