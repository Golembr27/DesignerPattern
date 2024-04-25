using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    private void Awake()
    {
        moedaCollider.AoColetouMoeda += atualizarMoedas;
        //moedaCollider.AoColetouMoeda += () => {GameObject.Find("Canvas").transform.Find("moeda").transform.Find("pontos").GetComponent<TextMeshProUGUI>().text = $"{PlayerController.moedas}";};
    }
    public static void atualizarMoedas()
    {
        GameObject.Find("Canvas").transform.Find("moeda").transform.Find("pontos").GetComponent<TextMeshProUGUI>().text = $"{PlayerController.moedas}";
    }
}
