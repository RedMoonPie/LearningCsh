using System;
namespace SerializacionComp
{
    //con esto indicamos que la clase que estamos definiendo acontinuacion es una clase serializable
    // si queremos clases serializables debemos ponerlos 
    [Serializable]
    public class CAuto
    {
        private double costo;
        private string modelo;
        private CMotor motor;

        public double Costo { get { return costo; } set { costo = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }

        // es importnte colocar la propiedad del objeto que ahce composicion 
        public CMotor Motor { get { return motor; } set { motor = value; } }


        public CAuto()
        {
            costo = 1000000;
            modelo = "volvo";
            motor = new CMotor();

        }
        public CAuto(string pModelo, double pCosto, int pCilindros, int pHP)
        {
            modelo = pModelo;
            costo = pCosto;
            motor = new CMotor(pCilindros, pHP);


        }
        public void MuestraInformacion()
        {
            // Mostramos la informacion necesaria 
            Console.WriteLine("Tu Automovil {0}", modelo);
            Console.WriteLine("Costo {0}", costo);
            Console.WriteLine("-----------");
            Motor.MuestraMotor();
        }
    }
}
