using UnityEngine;

public class TesteLadino : MonoBehaviour
{
    void Start()
    {
        Ladino ladino1 = new Ladino();
        ladino1.AtribuirNome("Shadow");
        ladino1.AtribuirEnergia(100);
        ladino1.AtribuirForca(40);
        ladino1.AtribuirVelocidade(9.5f);
        ladino1.AtribuirArmaPrincipal("Adagas");
        ladino1.AtribuirHabilidadeEspecial("Ataque Furtivo");

        Ladino ladino2 = new Ladino();
        ladino2.AtribuirNome("Silent");
        ladino2.AtribuirEnergia(90);
        ladino2.AtribuirForca(35);
        ladino2.AtribuirVelocidade(8.8f);
        ladino2.AtribuirArmaPrincipal("Adagas");
        ladino2.AtribuirHabilidadeEspecial("Ataque Furtivo");

        Debug.Log(ladino1.CompararComOutro(ladino2));
        Debug.Log(ladino1.UsarAtaqueFurtivo());
        Debug.Log(ladino2.UsarAtaqueFurtivo());
    }
}