using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForGods
{
   public class Option:INotifyPropertyChanged
    {
        private string value;
        private bool win;
        private string visible="Hidden";
        private string explanation;
        private string color = "Transparent";
        public Option(string value, string explanation, bool win)
        {
            this.Value = value;
            this.explanation = explanation;
            this.win = win;
            
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                this.color = value;
                DoPropertyChanged("Color");
            }
        }
        public bool Win
        {
            get
            {
                return win;
            }
            set
            {
                this.win = value;
                DoPropertyChanged("Win");
            }
        }
        public string Visible
        {
            get
            {
                return visible;
            }
            set
            {
                this.visible = value;
                DoPropertyChanged("Visible");
            }
        }
        public string Explanation
        {
            get
            {
                return explanation;
            }
            set
            {
                this.explanation = value;
                DoPropertyChanged("Explanation");
            }
        }
        public string Value {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
                DoPropertyChanged("Value");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void DoPropertyChanged(string name)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this, new  PropertyChangedEventArgs(name));
            }
        }
    }
}
