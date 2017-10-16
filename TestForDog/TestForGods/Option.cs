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
        private bool visible;
        private string explanation;
        public Option(string value, string expanation, bool win)
        {
            this.Value = value;
            this.explanation = explanation;
            this.win = win;
            visible = false;
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
            }
        }
        public bool Visible
        {
            get
            {
                return visible;
            }
            set
            {
                this.visible = value;
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
