public class Consolo
{
    public string modelo;
    public string cor;
    public float tamanho;
    public float diametro;
    private bool vibrando;
    private string textura;

    public Consolo (string m, string c, string tex, float t, float d)
    {
        vibrando = false;
        modelo = m;
        cor = c;
        tamanho = t;
        diametro = d;
        textura = tex;
    }

    public void Status()
    {
        Console.WriteLine($@"Modelo: {modelo}
        Cor: {cor}
        Textura: {textura}
        Tamanho: {tamanho}cm
        Diametro: {diametro}cm
        Vibrando: {vibrando}");
    }
}