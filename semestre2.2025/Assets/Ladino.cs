using UnityEngine;

public class Ladino : Personagem
{
    public string arma = "Adagas";
    public bool furtivo = true;
    public string habilidadeEspecial = "Ataque Furtivo";

    void Start()
    {
        AtribuirNome("Ladino");
        AtribuirForca(6);
        AtribuirAgilidade(9);
        AtribuirVida(100);
        AtribuirInteligencia(5);

        Debug.Log($"{nome} equipado com {arma}, habilidade especial: {habilidadeEspecial}");
        MostrarStatus();
    }
}