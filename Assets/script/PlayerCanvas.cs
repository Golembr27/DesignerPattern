using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        PlayerController.AoMudarVida += MostrarDano;
    }

    void MostrarDano()
    {
        GameObject dano = new GameObject();
        dano.name = "TextoDano";

        TextMeshProUGUI texto = dano.AddComponent<TextMeshProUGUI>();
        texto.text = "-1";
        texto.fontSize = 0.8f;
        texto.alignment = TextAlignmentOptions.Center;
        texto.color = Color.red;

        Instantiate(dano, transform);
        
        Destroy(dano, 1.5f);
    }
}
