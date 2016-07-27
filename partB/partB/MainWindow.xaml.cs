using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThinkLib;

namespace partB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int lenght(string s)
        {
            
            int i = 0;
            foreach (char c in s)
            {
                i++;
            }
            return i;

        }
        bool contains(string s, string subs)
        {
          List<char> c = new List<char>(lenght(s));
            List<char> x = new List<char>(lenght(subs));
            
            for (int i = 0; i < lenght(s); i++)
            {
                c[i] = s[i];
            }
            for (int i = 0; i < lenght(subs); i++)
            {
                x[i]= subs[i];
            }
            int cnt = 0;
            for (int i = 0; i < lenght(subs); i++)
            {
                if (c[i]==x[i])
                {
                    cnt++;
                }
                else
                {
                    cnt = 0;
                }
            }
            if (cnt==lenght(subs))
            {
                return true;
            }
            return false;
        }
        int indexOf(string s, string subs)
        {
            int len = lenght(subs);
            int lenS = lenght(s);
            int cnt = 0;
            for (int i = 0; i < lenS; i++)
            {
                if (subs[i] == s[i])
                {
                    cnt++;
                    if (cnt == len)
                    {
                        return i;
                    }
                }
                else
                {
                    cnt = -1;
                }

            }
            return cnt;

        }
        string insertSubstring(string s, string x, int pos)
        {
            int len = lenght(s);
            string New = "";
            for (int i = 0; i < len; i++)
            {
                New += s[i];
                if (i==(pos-1))
                {
                    New += x;
                }
            }

            return New;

        }
        string deleteSubstring(string s,string subs)
        {
            int len = lenght(s);
            string New = "";
           
            if (subs=="")
            {
                return s;
            }

            for (int i = 0; i < len; i++)
            {
                if (subs[i]==s[i])
                {
                    

                }
            }

            return "";
        }
        string replaceSubstring(string s, string New, string old)
        {
            string[] arrS = new string[] { };
            int[] arrIndex = new int[] { };
            int cnt = 0;
            for (int i = 0; i < lenght(s); i++)
            {
                arrS[i] = s[i] + "";
                if (arrS[i] == old[i] + "")
                {
                    cnt++;
                    arrIndex[i] = i;
                    if (cnt == lenght(old))
                    {
                        break;

                    }

                }
                else
                {
                    cnt = -1;
                }
            }

            if (cnt ==-1)
            {
                return "";
            }
            int j = 0;
            foreach (int y in arrIndex)
            {
                if (j < lenght(New))
                {
                    arrS[y] = New[j] + "";
                }
                else
                {
                    arrS[y] = "";
                }
                j++;


            }
            string newS = "";
            foreach (string x in arrS)
            {
                newS = s + x;
            }
            return newS;

        }
        string toLower(string s)
        {
            char c = ' ';
            string snew = "";
            for (int i = 0; i < lenght(s); i++)
            {
                switch (s[i])
                {
                    case 'A' : c = 'a';
                        break;
                    case 'B':
                        c = 'b';
                        break;
                    case 'C':
                        c = 'c';
                        break;
                    case 'D':
                        c = 'd';
                        break;
                    case 'E':
                        c = 'e';
                        break;
                    case 'F':
                        c = 'f';
                        break;
                    case 'G':
                        c = 'g';
                        break;
                    case 'H':
                        c = 'h';
                        break;
                    case 'I':
                        c = 'i';
                        break;
                    case 'J':
                        c = 'j';
                        break;
                    case 'K':
                        c = 'k';
                        break;
                    case 'L':
                        c = 'l';
                        break;
                    case 'M':
                        c = 'm';
                        break;
                    case 'N':
                        c = 'n';
                        break;
                    case 'O':
                        c = 'o';
                        break;
                    case 'P':
                        c = 'p';
                        break;
                    case 'Q':
                        c = 'q';
                        break;
                    case 'R':
                        c = 'r';
                        break;
                    case 'S':
                        c = 's';
                        break;
                    case 'T':
                        c = 't';
                        break;
                    case 'U':
                        c = 'u';
                        break;
                    case 'V':
                        c = 'v';
                        break;
                    case 'W':
                        c = 'w';
                        break;
                    case 'X':
                        c = 'x';
                        break;
                    case 'Y':
                        c = 'y';
                        break;
                    case 'Z':
                        c = 'z';
                        break;

                    default: c=s[i];
                        break;
                }
                snew += c;
            }
            return snew;
        }
        string toUpper(string s)
        {
            char c = ' ';
            string snew = "";
            for (int i = 0; i < lenght(s); i++)
            {
                switch (s[i])
                {
                    case 'a':
                        c = 'A';
                        break;
                    case 'b':
                        c = 'B';
                        break;
                    case 'c':
                        c = 'C';
                        break;
                    case 'd':
                        c = 'D';
                        break;
                    case 'e':
                        c = 'E';
                        break;
                    case 'f':
                        c = 'F';
                        break;
                    case 'g':
                        c = 'G';
                        break;
                    case 'h':
                        c = 'H';
                        break;
                    case 'i':
                        c = 'I';
                        break;
                    case 'j':
                        c = 'J';
                        break;
                    case 'k':
                        c = 'K';
                        break;
                    case 'l':
                        c = 'L';
                        break;
                    case 'm':
                        c = 'M';
                        break;
                    case 'n':
                        c = 'N';
                        break;
                    case 'o':
                        c = 'O';
                        break;
                    case 'p':
                        c = 'P';
                        break;
                    case 'q':
                        c = 'Q';
                        break;
                    case 'r':
                        c = 'R';
                        break;
                    case 's':
                        c = 'S';
                        break;
                    case 't':
                        c = 'T';
                        break;
                    case 'u':
                        c = 'U';
                        break;
                    case 'v':
                        c = 'V';
                        break;
                    case 'w':
                        c = 'W';
                        break;
                    case 'x':
                        c = 'X';
                        break;
                    case 'y':
                        c = 'Y';
                        break;
                    case 'z':
                        c = 'Z';
                        break;

                    default:
                        c = s[i];
                        break;
                }
                snew += c;
            }
            return snew;
        }
        int stringCompare(string s1,string s2)
        {
            int cnt = 0;
            if (s1=="" && s2!=""||s2=="" && s1!="")
            {
                return -1;
            }
            if (lenght(s1)!=lenght(s2))
            {
                if (s1[0]>s2[0])
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            for (int i = 0; i < lenght(s2); i++)
            {
                if (s1[i]==s2[i])
                {
                    cnt++;
                }
            }
            if (cnt ==lenght(s2))
            {
                return 0;
            }
            return -1;

        }

        private void Lenght_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(lenght("straws"),6);
            Tester.TestEq(lenght(""), 0);
            Tester.TestEq(lenght("apples"), 6);
            Tester.TestEq(lenght("straw"), 5);
            Tester.TestEq(lenght("234"), 3);
        }

        private void btncontains_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(contains("xxyxx","y"),true);
        }

        private void indexof_Click(object sender, RoutedEventArgs e)
        {
            //Tester.TestEq(indexOf("straws","aws"), 3);
            //Tester.TestEq(indexOf("straws", "ra"),2);
            //Tester.TestEq(indexOf("straws", "l"), -1);
            //Tester.TestEq(indexOf("straws", ""), -1);
            
        }

        private void InsertSub4_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(insertSubstring("xxxx","y", 2), "xxyxx");
        }

        private void replaceSub_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(replaceSubstring("newproject","old","new"),"oldproject");
            Tester.TestEq(replaceSubstring("find","ound","ind"),"found");
        }

        private void deleteSub_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Split_Click(object sender, RoutedEventArgs e)
        {

        }

        private void comparestring_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(stringCompare("xxx","xxx"),0);
            Tester.TestEq(stringCompare("apples", "pineapples"), 1);
            Tester.TestEq(stringCompare("pineapples", "apples"), -1);
            Tester.TestEq(stringCompare("", ""), 0);
            Tester.TestEq(stringCompare("xxx", ""), -1);
        }

        private void btntoUpper_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(toUpper("compsci"),"COMPSCI");
            Tester.TestEq(toUpper("ComPuterSci"), "COMPUTERSCI");
            Tester.TestEq(toUpper("compsci"), "COMPSCI");
            Tester.TestEq(toUpper("Csc101"), "CSC101");
        }

        private void btntoLower_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(toLower("COMPSCI"), "compsci");
            Tester.TestEq(toLower("ComPuterSci"), "computersci");
            Tester.TestEq(toLower("CSC101"), "csc101");
         
        }
    }
}
