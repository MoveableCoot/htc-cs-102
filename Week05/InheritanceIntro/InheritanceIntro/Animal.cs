using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class Animal
    {
        public string Name;
        public int Height;
        public string IsPoisonous;

        public void SayName()
        {
            MessageBox.Show("My name is " + Name);
        }



    }
}
