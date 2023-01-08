using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forditoprog
{
    public partial class Form1 : Form 
    {
        public string[,] table;
        Stack stack;

        int tableY;
        int tableX;
        string y;
        string x;
        string state;
        string output;

        public Form1(string[,] tabla)
        {
            this.table = tabla;
        }


        public Form1()
        {
            this.Text = "Beadandó";
            InitializeComponent();
            helpbox1.ReadOnly = true;
            table = returnDefaultTable();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if (kifejezes.Text == string.Empty)
            {
                MessageBox.Show("A bemenet nem lehet üres!");
                return;
            }
            Initialize();
            string input = kifejezes.Text;
            int index = 0;
            richTextBox1.Text += input + "\n";
            input = Regex.Replace(input, "[0-9]+", "i"); //Számokat lecserélem a szabálytáblázatnak megfelelő karakterekre.
            if (checkInputLastChar(input)) input += "#";
            kifejezes.Text = input;

            do
            {

                y = input[index].ToString();
                x = stack.Pop().ToString();


                switchY(y);
                switchX(x);

                switch (table[tableX, tableY])
                {
                    /*
                     * Ha a cella üres, az azt jelenti, hogy a kifejezésben hibát találtunk. 
                     * Ha a cella az elfogad szót tartalmazza, akkor a végére értünk az elemzésnek, és a kifejezés helyes.
                     * 
                     * Ha a pop szó található a cellában, akkor el kell távolítani a verem tetején található elemet (egy karaktert, ami lehet terminális, vagy nemterminális jel),
                     * és az indexet léptetni kell, vagyis megnövelni az index változó értékét eggyel.
                     */
                    case "":
                        state = "hiba";
                        break;
                    case "elfogad":
                        state = "Sikeres";
                        break;
                    case "pop":
                        if (index + 1 <= input.Length) index++;
                        richTextBox1.Text += string.Format("({0}, ", input.Remove(0, index));
                        foreach (var item in stack)
                        {
                            richTextBox1.Text += string.Format("{0}", item);
                        }
                        richTextBox1.Text += string.Format(", {0})\n", output);
                        break;
                    default:
                        try
                        {
                            string[] karakterek = table[tableX, tableY].Split(',');
                            karakterek[0] = karakterek[0].Remove(0, 1);
                            karakterek[1] = karakterek[1].Remove(1, 1);
                            char[] szabaly = karakterek[0].ToArray();
                            output += karakterek[1];
                            for (int i = szabaly.Length - 1; i >= 0; i--)
                            {
                                if (szabaly[i] == 'e') // Nem teszek semmit
                                {
                                }
                                else if (szabaly[i] == '\'')
                                {
                                    stack.Push(szabaly[i - 1].ToString() + szabaly[i].ToString());
                                    i--;
                                }
                                else stack.Push(szabaly[i]);
                            }
                            richTextBox1.Text += string.Format("({0}, ", input.Remove(0, index));
                            foreach (var item in stack)
                            {
                                richTextBox1.Text += string.Format("{0}", item);
                            }
                            richTextBox1.Text += string.Format(", {0})\n", output);
                            break;
                        }
                        catch (Exception)
                        {
                            state = "Error";
                            break;
                        }
                }


            }
            while (state == "");
            richTextBox1.Text += string.Format("\n{0}", state);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var szabalyzat = new Form2(table, this);
            szabalyzat.Show();
        }

        private void deleteOutput_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
        /// <summary>
        /// Beállítom a tábla alapbeállítását.
        /// </summary>
        /// <returns>string[,] alapbeállítás</returns>
        private string[,] returnDefaultTable()
        {
            return new string[,]
                {
                {
                    "E", "", "", "(TE',1)", "", "(TE',1)", ""
                },

                {
                    "E'", "(+TE',2)", "", "", "(e,3)", "", "(e,3)"
                },

                {
                    "T", "", "", "(FT',4)", "", "(FT',4)", ""
                },

                {
                    "T'", "(e,6)", "(*FT',5)", "", "(e,6)", "", "(e,6)"
                },

                {
                    "F", "", "", "((E),7)", "", "(i,8)", ""
                },

                {
                    "+", "pop", "", "", "", "", ""
                },

                {
                    "*", "", "pop", "", "", "", ""
                },

                {
                    "(", "", "", "pop", "", "", ""
                },

                {
                    ")", "", "", "", "pop", "", ""
                },

                {
                    "i", "", "", "", "", "pop", ""
                },

                {
                    "#", "", "", "", "", "", "elfogad"
                },
            };
        }
        /// <summary>
        /// Kezdőállapotba helyezi az általunk használt változókat.
        /// És inicializálja a stacket.
        /// (tableY,tableX,x,y,state,output,rtb.text)
        /// </summary>
        private void Initialize()
        {
            tableY = 0;
            tableX = 0;
            y = "";
            x = "";
            state = "";
            output = "";
            richTextBox1.Text = "";
            stack = new Stack();
            stack.Push("#");
            stack.Push("E");
        }
        /// <summary>
        /// Megnézi az input utolsó karakterét, hogy elfogadó állapotban vagyunk-e.
        /// </summary>
        /// <param name="input"></param>
        /// <returns> true, ha elfogadó állapot, false ha nem.</returns>
        private bool checkInputLastChar(string input)
        {
            return input.Last<char>() != '#';
        }

        private void switchX(string x)
        {
            switch (x)
            {
                case "E":
                    tableX = 0;
                    break;
                case "E'":
                    tableX = 1;
                    break;
                case "T":
                    tableX = 2;
                    break;
                case "T'":
                    tableX = 3;
                    break;
                case "F":
                    tableX = 4;
                    break;
                case "+":
                    tableX = 5;
                    break;
                case "*":
                    tableX = 6;
                    break;
                case "(":
                    tableX = 7;
                    break;
                case ")":
                    tableX = 8;
                    break;
                case "i":
                    tableX = 9;
                    break;
                case "#":
                    tableX = 10;
                    break;
                default:
                    break;
            }
        }

        private void switchY(string y)
        {
            switch (y)
            {
                case "+":
                    tableY = 1;
                    break;
                case "*":
                    tableY = 2;
                    break;
                case "(":
                    tableY = 3;
                    break;
                case ")":
                    tableY = 4;
                    break;
                case "i":
                    tableY = 5;
                    break;
                case "#":
                    tableY = 6;
                    break;
                default:
                    break;
            }
        }
    }
}
