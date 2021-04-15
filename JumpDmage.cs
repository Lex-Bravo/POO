//Nombre: Alejandra Bravo Ayala
//Materia: Programación Orientada a Objetos
//Profesor: Josue Israel Rivas Diaz
//Fuente: Script reciclado del proyecto final de Estructura de datos 2020, registro de colisiones
//Descripción: Script dedicado al registro de colisiones, para dañar/eliminar al enemigo al saltar sobre este.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpDmage : MonoBehaviour
{
    public Collider2D collider2D;
    public SpriteRenderer spriterenderer;
    public Animator animator;
    public GameObject destroyParticle;

    public float Jumpforce = 1.5f;
    public int lifes = 2;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = (Vector2.up * Jumpforce);
            LosseLifeAndHit();
            CheckLife();
        }
    }

    public void LosseLifeAndHit()
    {
        lifes--;
        animator.Play("Hit");
    }

    public void CheckLife()
    {
        if (lifes == 0)
        {
            destroyParticle.SetActive(true);
            spriterenderer.enabled = false;
            Invoke("EnemyDie", 0.2f);
        }
    }

    public void EnemyDie()
    {
        Destroy(gameObject);
    }
}
