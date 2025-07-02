using UnityEngine;
using TMPro;

public class TextoRabdomizado : MonoBehaviour
{
    public string novoTexto;

    public TextMeshProUGUI UITexto;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UITexto.text = novoTexto;

        }
    }

    
    
}  





























