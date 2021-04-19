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
    public float jump_Force;

    Rigidbody2D rb2D;

    bool doublejump;
    public float FallMultiplier = 0.5f;

    public SpriteRenderer spriterender;
    public Animator animator;
    bool isGrounded;
    public Transform groundcheck;
    public LayerMask groundlayer;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                Jump();
                doublejump = true;
            }
            else if (doublejump)
            {
                jump_Force = jump_Force / 2;
                Jump();
                doublejump = false;

                jump_Force = jump_Force * 2;
            }
        }
    }

    void Jump()
    {
        rb2D.velocity = Vector2.up * jump_Force;
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

        //checkground

        isGrounded = Physics2D.OverlapCircle(groundcheck.position, 0.2f, groundlayer);
    }
    
}
