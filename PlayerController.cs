//Nombre: Alejandra Bravo Ayala
//Materia: Programación Orientada a Objetos
//Profesor: Josue Israel Rivas Diaz
//Fuente: Script retomado del curso actual de POO, examen bimestral, script reciclado del proyecto final de Estructura de datos 2020
//Descripción: Script dedicado al movimiento del personaje

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float run_speed;
    public float jump_speed;

    Rigidbody2D rb2D;

    public bool better_jump = false;
    public float FallMultiplier = 0.5f;
    public float low_jumpMultiplier = 1f;

    public SpriteRenderer spriterender;
    public Animator animator;


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //Movimiento a los lados 

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2D.velocity = new Vector2(run_speed, rb2D.velocity.y);
            spriterender.flipX = false;
            animator.SetBool("run", true);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2D.velocity = new Vector2(-run_speed, rb2D.velocity.y);
            spriterender.flipX = true;
            animator.SetBool("run", true);
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            animator.SetBool("run", false);
        }

        //Salto

        if (Input.GetKey("w") || Input.GetKey("space") && Checkground.isGrounded)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jump_speed);
            animator.SetBool("jump", true);
            animator.SetBool("run", false);
        }
        else
        {
           
            animator.SetBool("jump", false);
        }

        if (better_jump)
        {
            if (rb2D.velocity.y < 0)
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (FallMultiplier) * Time.deltaTime;
            }
            if (rb2D.velocity.y > 0 && !Input.GetKey("w"))
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (low_jumpMultiplier) * Time.deltaTime;
            }
        }

    }
    
}
