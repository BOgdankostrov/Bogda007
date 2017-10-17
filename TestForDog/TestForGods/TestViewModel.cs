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
        string COLORTRUE = "#FF2E6C47";
        string COLORFALSE = "#FFE84B43";
        string TRANSPARENT = "Transparent";


        
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
            if(currentquestion.CheckAnswer(i))
            {
                countTrueAnser++;
            }
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
        //переход
        private RelayCommand next;
        public RelayCommand Next
        {
            get
            {
                return next ??
                  (next = new RelayCommand(obj =>
                  {
                      move();
                  }));
            }
        }

        // выбор ответа 
        private RelayCommand click;
        public RelayCommand Click
        {
            get
            {
                return click ??
                  (click = new RelayCommand(obj =>
                  {
                      int  ans = (int)obj;
                      choose(ans);
                      
                  }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void DoPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
