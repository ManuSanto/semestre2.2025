using System;

[Serializable]
public class Ladino : PersonagemBase
{
    private string armaPrincipal = "Adagas";
    private string habilidadeEspecial = "Ataque Furtivo";

    // Setters
    public void AtribuirArmaPrincipal(string arma)
    {
        this.armaPrincipal = arma;
    }

    public void AtribuirHabilidadeEspecial(string habilidade)
    {
        this.habilidadeEspecial = habilidade;
    }

    // Getters
    public string ArmaPrincipal()
    {
        return armaPrincipal;
    }

    public string HabilidadeEspecial()
    {
        return habilidadeEspecial;
    }

    // Método que simula usar a habilidade especial (retorna texto)
    public string UsarAtaqueFurtivo()
    {
        return $"{Nome()} usou a habilidade especial {habilidadeEspecial} com a arma {armaPrincipal}!";
    }
}