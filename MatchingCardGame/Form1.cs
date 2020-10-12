using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingCardGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        List<string> icons = new List<string>()
        {
            "m", "m", "y", "y", "J", "J", "e", "e", "s", "s", "u", "u", "S", "S", ".", "."
        };
        public Form1()
        {
            InitializeComponent();
        }
    }
}
