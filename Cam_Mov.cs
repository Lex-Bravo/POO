//Nombre: Alejandra Bravo Ayala
//Materia: Programación Orientada a Objetos
//Profesor: Josue Israel Rivas Diaz
//Fuente: Script reciclado del proyecto final para Estructura de datos 2020 e implementeción de screen boundaries con el código de unity Assets "Camera Follow"
//Descripción: Script dedicado al seguimiento del personaje con la cam

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Mov : MonoBehaviour
{
    [SerializeField]
    GameObject Player;
    private Vector3 velocity_f;

    [SerializeField]
    float timeOffset;

    [SerializeField]
    Vector2 position_Offset;

    [SerializeField]
    float LeftLimit;
    [SerializeField]
    float RightLimit;
    [SerializeField]
    float BottomLimit;
    [SerializeField]
    float TopLimit;

    // Update is called once per frame
    void Update()
    {
        //Posiciones actuales de cámara y de jugador
        Vector3 start_Position = transform.position;
        Vector3 end_Position = Player.transform.position;

        end_Position.x += position_Offset.x;
        end_Position.y += position_Offset.y;
        end_Position.z = -10;

        //Movimiento smooth de la camara 
        //Lerp funciona para interpolacion linear funciona para encontrar un vector que sea el porcentaje de trayectoria entre dos vectores

        transform.position = Vector3.Lerp(start_Position, end_Position, timeOffset * Time.deltaTime);


        transform.position = new Vector3
            (
              Mathf.Clamp(transform.position.x, LeftLimit, RightLimit),
              Mathf.Clamp(transform.position.y, BottomLimit, TopLimit),
              transform.position.z
            );
    }
}
