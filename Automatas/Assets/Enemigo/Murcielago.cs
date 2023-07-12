using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Murcielago : MonoBehaviour
{
    public Transform jugador;
    private float distancia;
    public Vector2 puntoInicial;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    public void Start()
    {
        animator = GetComponent<Animator>();
        puntoInicial = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Update()
    {
        distancia = Vector2.Distance(transform.position, jugador.position);
        animator.SetFloat("Distancia", distancia);
    }

    public void Girar(Vector2 objetivo)
    {
        if(transform.position.x < objetivo.x) 
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }
}
