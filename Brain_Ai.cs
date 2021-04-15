//Nombre: Alejandra Bravo Ayala
//Materia: Programación Orientada a Objetos
//Profesor: Josue Israel Rivas Diaz
//Fuente: Script reciclado del proyecto final de Estructura de datos 2020, aumentando los puntos de partida con el código complementario
//Descripción: Script dedicado al movimiento del enemigo con un AI brain

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain_Ai : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer spriterenderer;
    public float speed = 0.5f;
    public float startWaitTime = 2f;
    public Transform[] moveSpots;

    private int i = 0;
    private float waitTime;
    private Vector2 ActualPos;

    //Tiempo para regresar a su posicion inicial
    void Start()
    {
        waitTime = startWaitTime;   
    }


    void Update()
    {
        StartCoroutine(CheckEnemyMoving());

        transform.position = Vector2.MoveTowards(transform.position, moveSpots[i].transform.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, moveSpots[i].transform.position) < 0.1f)
        {
            if (waitTime <= 0)
            {
                //importante saber donde esta el move spot para poder estar delimitado 

                if(moveSpots[i]!= moveSpots[moveSpots.Length - 1])
                {
                    i++;
                }
                else
                {
                    i = 0;
                }

                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }

    }

    //nos ayuda a saber la posición del sprite, con esto podemos hacer que cambie de direccion.
    IEnumerator CheckEnemyMoving()
    {
        ActualPos = transform.position;

        yield return new WaitForSeconds(0.5f);

        if (transform.position.x > ActualPos.x)
        {
            spriterenderer.flipX = true;
            animator.SetBool("Idle", false);
        }
        else if (transform.position.x < ActualPos.x)
        {
            spriterenderer.flipX = false;
        }
        if (transform.position.x < ActualPos.x)
        {
            animator.SetBool("Idle", false);
        }
        else if (transform.position.x == ActualPos.x)
        {
            animator.SetBool("Idle",true);
        }
    }

}
