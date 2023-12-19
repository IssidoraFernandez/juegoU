using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth instance;

    public int currentHealth, maxHealth;


    // Invencibilidad para el jugador y dar un segundo de invencibilidad
    public float invincibleLength;
    private float invincibleCounter;

    //obtener el sprite del jugador para cambiarlo cuando reciba daño
    private SpriteRenderer spriteR;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; // Empezar con la vida máxima

        spriteR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(invincibleCounter > 0)
        {
            invincibleCounter -= Time.deltaTime;

            if(invincibleCounter <= 0)
            {
                spriteR.color = new Color(spriteR.color.r, spriteR.color.g, spriteR.color.b, 1f);
            }
        }
                     
    }

    public void dealDamage()
    {
        // Si el contador de invencibilidad es menor o igual a 0, el jugador recibe daño
        if (invincibleCounter <=0)
        {
            currentHealth--;
            movPersonaje.instance.animaciones.SetTrigger("Hurt");

            if (currentHealth <= 0)
            {
                currentHealth = 0;

                levelManager.instance.RespawnPlayer();
            }
            else
            {
                invincibleCounter = invincibleLength;
                spriteR.color = new Color(spriteR.color.r, spriteR.color.g, spriteR.color.b, .5f);

                movPersonaje.instance.Knockback();


            }
        }

        UIController.instance.UpdateHealthDisplay();
    }
}
