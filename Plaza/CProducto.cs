using System;
namespace Plaza
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class CProducto: IComparable
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        private double calorias;
        private double hierro;
        private double grasa;
     
        public CProducto(double pCalorias, double pHierro, double pGrasa )
        {
            calorias = pCalorias;
            hierro = pHierro;
            grasa = pGrasa;
        }
        public double Calorias { get { return calorias; } set { calorias = value; } }
        public double Hierro { get { return hierro; } set { hierro = value; } }
        public double Grasa { get { return grasa; } set { grasa = value; } }

        public override string ToString()
        {
            string tmp = string.Format("Calorias:{0}, Hierro: {1}, Grasa: {2}",calorias,hierro,grasa);
            return tmp;
        }

        public static CProducto operator + (CProducto p1, CProducto p2)
        {
            double rh = p1.Hierro + p2.Hierro;
            double rg = p1.Grasa + p2.Grasa;
            double rc = p1.Calorias + p2.Calorias;

            CProducto tmp = new CProducto(rc, rh, rg);

            return tmp;
        }
        public static CProducto operator - (CProducto p1, CProducto p2) {

            double rh = p1.Hierro - p2.Hierro;
            double rg = p1.Grasa - p2.Grasa;
            double rc = p1.Calorias - p2.Calorias;

            CProducto tmp = new CProducto(rc, rh, rg);

            return tmp;

        }
        // si es un operador binario se puedo sobrecargar y poner el propio metodo 

        //sobrecarga de operadores unuarios -- ++

        public static CProducto operator ++ (CProducto p1)
        {
            CProducto temp = new CProducto(p1.Calorias + 100, p1.Grasa + 50, p1.Hierro + 50);

            return temp;
        }
        public static CProducto operator -- (CProducto p2)
        {
            CProducto temp = new CProducto(p2.Calorias - 100, p2.Grasa - 50, p2.Calorias - 50);

            return temp;
        }
        //sobrecarga operador de igualada y desigualdad
        //override funcion Equals
        public override bool Equals(object obj)
        {
            //verificamos que sea del tipo correcto

            if(obj is CProducto)
            {
                CProducto temp = (CProducto)obj;

                //comparamos por igualdad
                if(hierro == temp.Hierro && calorias == temp.Calorias)
                {
                    return true;
                }

            } 
            return false;

        }
        public static bool operator == (CProducto p1, CProducto p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(CProducto p1, CProducto p2)
        {
            return !(p1.Equals(p2));
        }
        // sobrecarga de < y > es encesario IComparable 
        // comparator
        // el metodo saludable es para tener como comparar
        public double saludable()
        {
            double k = 0;
            k = ((hierro + grasa + calorias)/3);
            return k;
        }


        public int CompareTo(object obj)
        {
            if(obj is CProducto)
            {
                CProducto temp = (CProducto)obj;

                if(saludable() > temp.saludable())
                {
                    return 1;
                }
                if(saludable() < temp.saludable())
                {
                    return -1;
                }
            }
            return 0;
        }
        public static bool operator  < (CProducto p1 , CProducto p2)
        {
            if (p1.CompareTo(p2) < 0)
            {
                return true;
            }
            else
                return false;
        }
        public static bool operator > ( CProducto p1 , CProducto p2)
        {
            if (p1.CompareTo(p2) > 0)
            {
                return true;
            }
            else
                return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
