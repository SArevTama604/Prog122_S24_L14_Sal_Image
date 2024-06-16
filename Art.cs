using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prog_122_S24_L14_Sal
{
    public class Art
    {
        // Enum definition
        public enum STYLE { Abstract, Impressionism, Cubism }

        private STYLE _style;
        private string _name;

        public STYLE Style
        {
            get => _style;
            set => _style = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Art(string name, STYLE style)
        {
            _name = name;
            _style = style;
        }

        public override string ToString()
        {
            return $"{_name} - {_style}";
        }
    }
}