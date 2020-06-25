using System;
namespace TFractCSharp_test1
{
    public class TFract
    {
        private int Num, Den;


        public TFract()
        {
            this.Num = 1;
            this.Den = 1;
        }

        public TFract(int a, int b)
        {
            if ((b < 0) && (a > 0)) 
            {
                a = -a;        
                b = Math.Abs(b);    
            }
            else               
            if ((a < 0) && (b < 0)) 
            {
                b = Math.Abs(b);    
            }
            else

            if (b == 0)        
            {
                Num = 0; Den = 1; 
                throw new TFractException("Попытка сделать нулевой знаменатель"); 
            }

            Num = a;   
            Den = b;   
        }

        public float ToFloat()
        {
            float x;
            x = ((float)this.Num) / this.Den;
            return x;
        }

        public TFract Reduce()  
        {
            int a, b, ta, tb, tmp, gcd; 

            a = ta = this.Num; 
            b = tb = this.Den; 

            if (a < 0) ta = Math.Abs(ta); 

            while (ta != 0)
            {
                if (ta < tb)
                {
                    tmp = ta; ta = tb; tb = tmp;
                }
                ta = ta - tb;
            }

            gcd = tb;
            a = a / gcd;
            b = b / gcd;

            this.Num = a;
            this.Den = b;
            TFract F = new TFract(a, b);

            return F;
        }

        public void SetNum(int n) 
        {
            this.Num = n;
        }

        public void SetDen(int n) 
        {
            this.Den = n;
        }

        public int GetIntNum()  
        {
            return this.Num;
        }

        public int GetIntDen()
        {
            return this.Den;
        }

        public string GetStrNum() 
        {
            string s = this.Num.ToString();
            return s;
        }

        public string GetStrDen() 
        {
            string s = this.Den.ToString();
            return s;
        }

        public override string ToString()  
        {
            string s;
            s = this.GetStrNum() + "/" + this.GetStrDen();

            return s;
        }

        public static TFract operator +(TFract a) => a;
        public static TFract operator -(TFract a) => new TFract(-a.Num, a.Den); 

        public static TFract operator +(TFract a, TFract b) 
        => new TFract(a.Num * b.Den + b.Num * a.Den, a.Den * b.Den);


        public static TFract operator + (TFract a, int n) 
        {
            TFract b = new TFract();
            TFract c = new TFract();
            b.SetNum(n); b.SetDen(1);
            c = a + b;
            return c;
        }

        public static TFract operator +(int n, TFract a) 
        {
            TFract b = new TFract();
            TFract c = new TFract();
            b.SetNum(n); b.SetDen(1);
            c = b + a;
            return c;
        }

        public static TFract operator -(TFract a, TFract b) 
        => a + (-b);

        public static TFract operator *(TFract a, TFract b) 
        => new TFract(a.Num * b.Num, a.Den * b.Den);

        public static TFract operator /(TFract a, TFract b) 
        {
            if (b.Num == 0) 
            {
                throw new TFractException("Деление на дробь, у которой числитель = 0"); 
            }
            return new TFract(a.Num * b.Den, a.Den * b.Num);
        }

        public static bool operator >(TFract a, TFract b) 
        {
            if ((a.Num * b.Den) > (a.Den * b.Num))
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator <(TFract a, TFract b) 
        {
            if ((a.Num * b.Den) < (a.Den * b.Num))
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator >=(TFract a, TFract b) 
        {
            if ((a.Num * b.Den) >= (a.Den * b.Num))
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator <=(TFract a, TFract b) 
        {
            if ((a.Num * b.Den) <= (a.Den * b.Num))
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator ==(TFract a, TFract b)  
        {
            if ((a.Num * b.Den) == (a.Den * b.Num))
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator !=(TFract a, TFract b)  
        {
            if ((a.Num * b.Den) != (a.Den * b.Num))
            {
                return true;
            }
            else
                return false;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;
            TFract t = (TFract)obj;
            return (Num == t.Num && Den == t.Den);
        }

        public override int GetHashCode()
        {
            return 0;
        }

    }
}

