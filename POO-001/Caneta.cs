
public class Caneta
{
    public string modelo = "";
    public string cor = "";
    private float ponta;
    protected int carga;
    protected  bool tampada;

    public Caneta()
    {
        Tampar();
        cor = "azul";
    }

    public string GetModelo()
    {
        return  modelo;
    }
    public void SetModelo(string modelo)
    {
        this.modelo = modelo;
    }


    public void Status()
    {
        Console.WriteLine($"Modelo: {modelo}\n Cor: {cor}\n Ponta: {ponta}\n carga: {carga}%\n Tampada? {tampada}\n");
    }
    public void Rabiscar()
    {
        if (tampada == true)
        {
            Console.WriteLine("Não posso rabiscar");
            return;
        }

        Console.WriteLine("Rabiscando");
    }
    private void Tampar()
    {
        tampada = true;
    }
    private void Destampar()
    {
        tampada = false;
    }
}