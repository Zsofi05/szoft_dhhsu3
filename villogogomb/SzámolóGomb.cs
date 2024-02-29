using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace villogogomb
{
    internal class SzámolóGomb:Button
    {
        int szám;
        public SzámolóGomb()
        {
            Height = 20;
            Width = 20;
            szám = 0;
            MouseClick += SzámolóGomb_MouseClick;
        }

        private void SzámolóGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            szám++;
            Text=szám.ToString();
            if (szám==5 ) { szám = 0; };
        }
    }
}
