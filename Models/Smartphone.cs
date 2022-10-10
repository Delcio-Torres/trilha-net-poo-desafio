namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(){

        }

        public Smartphone(string numero, string modelo, string imei, int memoria){
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine($"Telefone {Modelo} ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Telefone {Modelo} recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}