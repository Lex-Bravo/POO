using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nombre: Alejandra Bravo Ayala
//Materia: Programación Orientada a Objetos
//Profesor: Josue Israel Rivas Diaz
//Fuente: Script reciclado del proyecto final de Estructura de datos 2020, aumentando los puntos de partida con el código complementario
//Descripción: Script dedicado al movimiento de las plataformas

public class Platformsmov : MonoBehaviour
{
    public float speed = 0.5f;
    public float startWaitTime = 2f;
    public Transform[] moveSpots;

    private int i = 0;
    private float waitTime;

    //Tiempo para regresar a su posicion inicial
    void Start()
    {
        waitTime = startWaitTime;
    }


    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, moveSpots[i].transform.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, moveSpots[i].transform.position) < 0.1f)
        {
            if (waitTime <= 0)
            {
                //importante saber donde esta el move spot para poder estar delimitado 

                if (moveSpots[i] != moveSpots[moveSpots.Length - 1])
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
}
