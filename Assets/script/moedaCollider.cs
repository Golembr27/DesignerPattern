using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moedaCollider : MonoBehaviour
{

    public static event Action AoColetouMoeda;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.CompareTag("Player"))
        {
            //AoColetouMoeda?.Invoke();
            AoColetouMoeda();
            Destroy(gameObject);
        }
    }
}
