using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel; 

namespace ConsoleApplication1
{
    class Quetion
    {
        public string question { get; set; }
        public List<Option> options { get; set; }
        public Quetion(string question, List<Option> listOptions)
        {
            this.question = question;
            this.options = listOptions;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void DoPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public bool CheckAnswer(int i)
        {
            if (options[i].Win = true)
            {
                return true;
            }
            return false;
        }

    }
}
