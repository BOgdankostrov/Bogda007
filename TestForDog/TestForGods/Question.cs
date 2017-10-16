using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForGods
{
   public class Question:INotifyPropertyChanged
    {
        public string question { get; set; }
        public List<Option> options { get; set; }
        public Question(string question, List<Option> listOptions)
        {
            this.question = question;
            this.options = listOptions;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void DoPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name) );
        }
        public bool CheckAnswer(int i)
        {
            if(options[i].Win =true)
            {
                return true;
            }
            return false;
        }
        
    }
}
