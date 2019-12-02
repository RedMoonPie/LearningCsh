using System;
namespace SerializacionComp
{
    [Serializable]
    public class CMotor
    {
        private int cilindros;
        private int hp;

        public int Cilindros { get { return cilindros; } set { cilindros = value; } }
        public int Hp { get { return hp; } set { hp = value; } }

        public CMotor()
        {
            cilindros = 4;
            hp = 200;
        }
        public CMotor(int pCilindros, int pHP)
        {
            cilindros = pCilindros;
            hp = pHP;

        }
        public void MuestraMotor()
        {
            Console.WriteLine("=== Cilindros: {0}, HP:{1}", cilindros,hp);
        }
    }
}
