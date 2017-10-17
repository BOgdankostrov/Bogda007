﻿using System;
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
      const  string  COLORTRUE = "#FF2E6C47";
      const  string COLORFALSE = "#FFE84B43";
        const string HIDDDEN = "Hidden";
        const string VISIBILITY = "Visibility";
     // const  string TRANSPARENT = "Transparent";

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
            setColorAndVisible();
            if(options[i].Win == true)
            {
                return true;
            }
            return false;
        }
        public void setColorAndVisible()
        {
            for (int i = 0; i < options.Count; i++)
            {
                if(options[i].Win==true)
                {
                    options[i].Color = COLORTRUE;
                    options[i].Visible = VISIBILITY;
                }
                else
                {
                    options[i].Color = COLORFALSE;
                }

            }
            
        }
        
        
    }
}
