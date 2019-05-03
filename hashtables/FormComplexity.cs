using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hashtables
{
    public partial class FormComplexity : Form
    {
        public FormComplexity()
        {
            InitializeComponent();
        }


        int complexity;
        int[] levelIDs;

        public int[] generateDungeon(int playerLevel, int hardness)
        {
            Random rand = new Random();

            int formula = (playerLevel % 3) + hardness + 3;//формула на количество уровней

            int[] levelIDs = new int[formula];//создание массива

            for (int i = 0; i < levelIDs.Length; i++)
            {//назначаем каждому уровню айди
                do
                {
                    levelIDs[i] = rand.Next(); //в параметр некст нужно вставить колличество вариантов
                } while (Array.Exists(levelIDs, element => element == levelIDs[i]));//проверка на повторы

            }

            return levelIDs;
            //в таблице квестов будет айди, текст квестика, тип: монстр/развилка/загадка, в зависимости от типа будут разные кнопки                                             
        }
        //тут только предметы в подземелье
        private void btnEasy_Click(object sender, EventArgs e)
        {
            complexity = 1;
            int[] levelIDs = generateDungeon(1/*Player llevel*/, complexity);
        }
        //предметы и монстры
        private void btnHard_Click(object sender, EventArgs e)
        {
            complexity = 2;
            int[] levelIDs = generateDungeon(1/*Player llevel*/, complexity);
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            complexity = 3;
            int[] levelIDs = generateDungeon(1/*Player llevel*/, complexity);
        }
        private void btnLeave_Click(object sender, EventArgs e)
        {
            Close();
            FormStartQuest formStartQuest = new FormStartQuest();
            formStartQuest.Show();
        }


    }
}
