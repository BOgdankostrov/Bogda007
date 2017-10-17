﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForGods
{
    
    public class TestViewModel : INotifyPropertyChanged
    {
        
        
        private Question currentquestion;
        private List<Question> questions;
       private int index;
       private int countTrueAnser;

        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                this.index = value;
                DoPropertyChanged("Index");
            }
        }
        public int CountTrueAnser
        {
            get
            {
                return countTrueAnser;
            }
            set
            {
                this.countTrueAnser = value;
                DoPropertyChanged("CountTrueAnser");
            }
        }


        public TestViewModel()
        {

            newTest();

        }

        private void newTest()
        {
            Index = 0;
            countTrueAnser = 0;
            LoadAsk t = new LoadAsk();
            questions = t.GetListQuestion();
            move();
            
        }

         public void move()
        {
            Index++;
            if (index<11)
            {
                CurrentQuestion = questions[index-1];
            }
            else
            {
                newTest();
                //открытие результатов 
            }


        }
         
        public void choose(int i)
        {
            if(currentquestion.CheckAnswer(i))
            {
                countTrueAnser++;
            }
        }

        public Question CurrentQuestion
        {
            get
            {
                return currentquestion;
            }
            set
            {
                this.currentquestion = value;
                DoPropertyChanged("CurrentQuestion");
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
                      int  ans = int.Parse( obj.ToString());
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
