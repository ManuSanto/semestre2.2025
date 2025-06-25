using System;

[Serializable]
public class PersonagemBase
{
    // Variáveis privadas
    private string nome;
    private int energia;
    private int forca;
    private float velocidade;

    // Setters
    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public void AtribuirEnergia(int energia)
    {
        this.energia = energia;
    }

    public void AtribuirForca(int forca)
    {
        this.forca = forca;
    }

    public void AtribuirVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    // Getters
    public string Nome()
    {
        return this.nome;
    }

    public int Energia()
    {
        return this.energia;
    }

    public int Forca()
    {
        return this.forca;
    }

    public float Velocidade()
    {
        return this.velocidade;
    }

    // Comparação simples entre dois personagens
    public string CompararComOutro(PersonagemBase outro)
    {
        string resultado = $"{nome} VS {outro.Nome()}\n" +
                           $"{nome} - Energia: {energia}, Força: {forca}, Velocidade: {velocidade}\n" +
                           $"{outro.Nome()} - Energia: {outro.Energia()}, Força: {outro.Forca()}, Velocidade: {outro.Velocidade()}\n";

        if (forca > outro.Forca())
            resultado += $"{nome} é mais forte que {outro.Nome()}";
        else if (forca < outro.Forca())
            resultado += $"{outro.Nome()} é mais forte que {nome}";
        else
            resultado += $"{nome} e {outro.Nome()} têm a mesma força.";

        return resultado;
    }
}