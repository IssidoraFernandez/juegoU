using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    //designar que la camara va a seguir al jugador
    public Transform target;

    //asignar los fondos
    public Transform farBackground, middleBackground;

    //diferenciar los fondos
    private float lastXPos;

    // Start is called before the first frame update
    void Start()
    {
        //definir la ultima posicion en x del jugador
        lastXPos = transform.position.x;
        
    }

    // Update is called once per frame
    void Update()
    {
        //seguir al jugador
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
        //el vector3 permite que la camara siga al jugador en el eje x e y, pero no en el z
        
        //Cantidad de movimiento a asignar a los fondos
        float amountToMoveX = transform.position.x - lastXPos;

        //asignar el fondo lejano
        farBackground.position = farBackground.position + new Vector3(amountToMoveX, 0, 0);

        //asignar el fondo medio
        middleBackground.position += new Vector3(amountToMoveX * 0.5f, 0, 0);

        //actualizar la ultima posicion en x del jugador
        lastXPos = transform.position.x;
    }
}
