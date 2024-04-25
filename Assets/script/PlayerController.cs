using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static int moedas;

    Rigidbody2D rb;
    float velocidade = 5f;
    public float forcaPulo = 100;

    private void Awake()
    {
        moedaCollider.AoColetouMoeda += AumentarMoedas;
        //moedaCollider.AoColetouMoeda += () => {moedas++;};
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 movimentacao = new Vector2(horizontal * velocidade, rb.velocity.y );
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * forcaPulo);
        }
        rb.velocity = movimentacao;
    }

    void AumentarMoedas()
    {
        velocidade++;
    }

}
