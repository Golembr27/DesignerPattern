using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moedaCollider : MonoBehaviour
{

    public static event Action AoColetouMoeda;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if ( collision.CompareTag("Player"))
        if (collision.TryGetComponent<PlayerController>(out PlayerController playerController))
        {
            //AoColetouMoeda?.Invoke();
            //AoColetouMoeda(); chamar o evento da moeda

            playerController.LevarDano();
            Destroy(gameObject);
        }
    }
}
