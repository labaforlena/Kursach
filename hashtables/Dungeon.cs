using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hashtables
{
    public class Dungeon
    {
        public int id;
        public string mainText;
        public int type;
        public string answ1, answ2, answ3;
        public string reaction1, reaction2, reaction3;
        public int complexity;
    }

   public class Type1 : Dungeon
    {
      public Type1()
         {
           
         }

        public void checkAnswer(ref TextBox textBox, ref Label label)
        {
            if(textBox.Text == answ1 || textBox.Text == answ2 || textBox.Text == answ3)
            {
                label.Text = "well done, stranger. you're safe by now. get your prize and continue";
            }
            else
            {

            }
        }
    }

    public class Type2:Dungeon
    {

    }

    public class Type3:Dungeon
    {

    }

}
