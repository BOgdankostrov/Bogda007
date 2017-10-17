using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForGods
{
    
    class TestViewModel : INotifyPropertyChanged
    {
        const int QUESTIONSAMOUNT=10;
        private Question currentquestion;
        private List<Question> questions;
       private int index=0;

        int countTrueAnser = 0;


          
        public TestViewModel()
        {
            
            questions = new List<Question>();
            move();

        }
         public void move()
        {
            index++;
            currentquestion = questions[index];

        }
         
        public void choose(int i)
        {
            //if(currentquestion.)
        }
        public Question Question
        {
            get
            {
                return currentquestion;
            }
            set
            {
                this.currentquestion = value;
                DoPropertyChanged("Question");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void DoPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
