using UnityEngine;

public class Personagem : MonoBehaviour
{
    [SerializeField] private string nome;
    [ SerializeField ] private int energia;
    [ SerializeField ] private int forca_ataque;
    [ SerializeField ] private float velocidade;
    
    
    
    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public string Nome()
    {
        return this.nome;
    }
    public void AtribuirEnergia(int energia)
    {
        this.energia = energia;
    }

    public int Energia()
    {
        return this.energia;
    }
 
    public void AtribuirForca_Ataque(int forca_ataque)
    {
        this.forca_ataque = forca_ataque;
    }

    public int Forca_Ataque()
    {
        return this.forca_ataque;
    }

    public void AtribuirVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    public float Velocidade()
    {
        return this.velocidade;
    }
    
    
    void Start()
    {
        
    }
    void Update()
    {
        
    }
        
    
}

