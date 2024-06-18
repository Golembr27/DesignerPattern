using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    public HUDController instancia;

    Canvas canvas;
    TextMeshProUGUI textoVida;

    private void Start()
    {
        textoVida = transform.Find("vidas").transform.Find("pontos").GetComponent<TextMeshProUGUI>();
    }

    public void AtualizarVida(int vida)
    {
        textoVida.text = vida.ToString();
    }

}
