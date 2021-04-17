//Nombre: Alejandra Bravo Ayala
//Materia: Programación Orientada a Objetos
//Profesor: Josue Israel Rivas Diaz
//Fuente: Script tomado del canal LuisCanary
//Descripción: Script dedicado al Respawn del jugador en el Checkpoint y al sistema de vidas

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    private float checkPointPositionX, checkPointPositionY;
   
    public Animator animator;
    public GameObject[] Hearts;
    private int life;

    void Start()
    {
        life = Hearts.Length;

        if (PlayerPrefs.GetFloat("checkPointPositionX")!= 0)
        {
            transform.position = (new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY")));
        }
    }

    //Vidas
    private void Checklife()
    {
        if (life < 1)
        {
            Destroy(Hearts[0].gameObject);
            animator.Play("hit");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (life < 2)
        {
            Destroy(Hearts[1].gameObject);
            animator.Play("hit");
        }
        else if (life < 3)
        {
            Destroy(Hearts[2].gameObject);
            animator.Play("hit");
        }
    }

    public void ReachedCheckPoint(float x, float y)
    {
        PlayerPrefs.SetFloat("checkPointPositionX", x);
        PlayerPrefs.SetFloat("checkPointPositionY", y);
    }

    public void PlayerDamaged()
    {
        life--;
        Checklife();
    }
}
