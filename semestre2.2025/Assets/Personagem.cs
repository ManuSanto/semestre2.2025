using UnityEngine;

public class Personagem : MonoBehaviour
{
    public string nome;
    public int forca;
    public int agilidade;
    public int vida;
    public int inteligencia;

    public void AtribuirNome(string novoNome)
    {
        nome = novoNome;
    }

    public void AtribuirForca(int novaForca)
    {
        forca = novaForca;
    }

    public void AtribuirAgilidade(int novaAgilidade)
    {
        agilidade = novaAgilidade;
    }

    public void AtribuirVida(int novaVida)
    {
        vida = novaVida;
    }

    public void AtribuirInteligencia(int novaInteligencia)
    {
        inteligencia = novaInteligencia;
    }

    public void MostrarStatus()
    {
        Debug.Log($"Nome: {nome}, Força: {forca}, Agilidade: {agilidade}, Vida: {vida}, Inteligência: {inteligencia}");
    }

    public void CompararForca(Personagem outro)
    {
        if (forca > outro.forca)
        {
            Debug.Log($"{nome} é mais forte que {outro.nome}");
        }
        else if (forca < outro.forca)
        {
            Debug.Log($"{outro.nome} é mais forte que {nome}");
        }
        else
        {
            Debug.Log($"{nome} e {outro.nome} têm a mesma força");
        }
    }
}