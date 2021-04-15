//Nombre: Alejandra Bravo Ayala
//Materia: Programación Orientada a Objetos
//Profesor: Josue Israel Rivas Diaz
//Fuente: Script tomado del canal LuisCanary
//Descripción: Script dedicado al Respawn del jugador en el Checkpoint

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    private float checkPointPositionX, checkPointPositionY;

    public Animator animator;


    void Start()
    {
        if (PlayerPrefs.GetFloat("checkPointPositionX")!= 0)
        {
            transform.position = (new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY")));
        }


    }

    public void ReachedCheckPoint(float x, float y)
    {
        PlayerPrefs.SetFloat("checkPointPositionX", x);
        PlayerPrefs.SetFloat("checkPointPositionY", y);
    }

    public void PlayerDamaged()
    {
        animator.Play("hit");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
