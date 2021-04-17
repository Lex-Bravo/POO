//Nombre: Alejandra Bravo Ayala
//Materia: Programación Orientada a Objetos
//Profesor: Josue Israel Rivas Diaz
//Fuente: Examen bimestral POO 
//Descripción: Script que contara la llave para abrir paso al trofeo

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterKey : MonoBehaviour
{
    public static int numitem;
    private Text Countert;


    // Start is called before the first frame update
    void Start()
    {
       Countert = GetComponent<Text>();
        numitem = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Countert.text="StarKey"+ numitem;
    }
}
