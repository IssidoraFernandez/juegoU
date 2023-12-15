using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movPersonaje : MonoBehaviour
{
    //indicar uso de RigidBody
    Rigidbody2D cuerpo;
    public float velocidad;
    
    // Start is called before the first frame update
    void Start()
    {
        //establecer velocidad inicial
        velocidad = 10;
        //obtener propiedades RigidBody
        cuerpo = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per f rame
    void Update()
    {
        //agregar movimiento al personaje

        //obtener los valores de los ejes
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");

        //buscar propiedad velocity del RigidBody
        cuerpo.velocity = new Vector2(movHorizontal, movVertical) * velocidad;
        transform


        //para cuando exista colision
        private void onCollisionEnter2D(Collision2D collision)

        //si el jugador colisiona con el enemigo vuelve a la posicion 0,0
        if(c)
    }
}
