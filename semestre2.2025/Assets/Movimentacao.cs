using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    public float velocidade = 5f;
    public int vida = 100;
    public string nomePersonagem = "Ladino";

    private CharacterController controller;
    private Vector3 direcao;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        direcao = new Vector3(horizontal, 0f, vertical);
        controller.Move(direcao * velocidade * Time.deltaTime);
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Inimigo"))
        {
            int dano = Random.Range(10, 21); // Dano aleatório entre 10 e 20
            vida -= dano;

            Debug.Log($" Interação: {nomePersonagem} colidiu com {hit.gameObject.name} e perdeu {dano} de vida.");
            Debug.Log($"Vida restante de {nomePersonagem}: {vida}");

            if (vida <= 0)
            {
                Debug.Log($"{nomePersonagem} foi derrotado.");
            }
        }
    }
}