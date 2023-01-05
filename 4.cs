using System;
namespace program
{
    class karmand
    {
        private string ID;
        private string Name;
        private string Date;
        private double Money;
        
        public string ID
        {
            get {return ID;}
            set {ID=value;}
        }
         public string Name
        {
            get {return Name;}
            set {Name=value;}
        }
         public double Date
        {
            get {return Date;}
            set {Date=value;}
        }
         public double Money
        {
            get {return Money;}
            set {Money=value;}
        }

        public static void karmand(){}
        
        public static void karmand(string id, string name, string date,string money)
        {
            ID = id;
            Name = name;
            Date=date;
            Money=money;
        }
        public double Bime()
        { 
          return (money*7/100);
        }
         public double task()
        { 
          if (money>=6500000)
          {
            return (money*10/100);
          }
          else
          {
            return (money*0);
          }
        }
         public double money()
        { 
            return(money-(task()+Bime()));
        }
         
        
    }
    
}