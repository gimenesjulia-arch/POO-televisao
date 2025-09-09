public class Televisao
{
    private const int VOL_MAX = 100;
    private const int VOL_MIN = 0;
    private const int TOTAL_CANAIS = 520;

    private int ultimoCanalAssistido = 1;

    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
        Volume = 10; 
        Canal = 1;  
        Estado = false; 
    }

    public float Tamanho { get; }
    public int Resolucao { get; set; }
    public int Volume { get; private set; }
    public int Canal { get; private set; }
    public bool Estado { get; private set; }

    
    public void Ligar()
    {
        Estado = true;
        Canal = ultimoCanalAssistido; 
    }

    public void Desligar()
    {
        Estado = false;
        ultimoCanalAssistido = Canal; 
    }

    
    public void AumentarVolume()
    {
        if (Volume < VOL_MAX)
            Volume++;
        else
            Console.WriteLine("TV já está no volume máximo.");
    }

    public void DiminuirVolume()
    {
        if (Volume > VOL_MIN)
            Volume--;
        else
            Console.WriteLine("TV já está no volume mínimo.");
    }


    public void ProximoCanal()
    {
        if (Canal < TOTAL_CANAIS)
            Canal++;
        else
            Canal = 1; 
    }

    public void CanalAnterior()
    {
        if (Canal > 1)
            Canal--;
        else
            Canal = TOTAL_CANAIS; 
    }

    public void MudarParaCanal(int novoCanal)
    {
        if (novoCanal < 1)
            Console.WriteLine("Número de canal inválido. Não pode ser negativo ou zero.");
        else if (novoCanal > TOTAL_CANAIS)
            Console.WriteLine($"Número de canal inválido. Máximo permitido: {TOTAL_CANAIS}");
        else
            Canal = novoCanal;
    }
}