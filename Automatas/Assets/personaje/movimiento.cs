using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    Rigidbody2D jugador;
    public int velocidad;
    public int velSalto;
    Animator animator;

    void Start()
    {
        jugador = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        jugador.velocity = new Vector2(Input.GetAxis("Horizontal") * velocidad, jugador.velocity.y);

        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.rotation = Quaternion.AngleAxis(180, Vector3.up);
        }
        else
        {
            transform.rotation = Quaternion.AngleAxis(0, Vector3.up);
        }

        if (jugador.velocity.x != 0)
        {
            animator.SetBool("Corriendo", true);
        }
        else
        {
            animator.SetBool("Corriendo", false);
        }

        if (Input.GetKeyDown("w"))
        {
            jugador.velocity = new Vector2(jugador.velocity.x, velSalto);
        }

        if(jugador.velocity.y > 0.1)
        {
            animator.SetBool("Saltando", true);
        }
        else if(jugador.velocity.y < 0)
        {
            animator.SetBool("Callendo", true);
        }
        else
        {
            animator.SetBool("Saltando", false);
            animator.SetBool("Callendo", false);
        }

    }
}
