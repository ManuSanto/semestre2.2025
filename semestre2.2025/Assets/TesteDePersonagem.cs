using UnityEngine;

public class TestePersonagem : MonoBehaviour
{
    public Personagem personagemUm;
    public Personagem personagemDois;

    void Start()
    {
        if (personagemUm != null && personagemDois != null)
        {
            personagemUm.MostrarStatus();
            personagemDois.MostrarStatus();
            personagemUm.CompararForca(personagemDois);
        }
        else
        {
            Debug.LogWarning("Atribua os dois personagens no Inspector.");
        }
    }
}

