using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    //designar que la camara va a seguir al jugador
    public Transform target;

    //asignar los fondos
    public Transform farBackground, middleBackground;

    public float minHeight, maxHeight;

    //diferenciar los fondos
    private Vector2 lastPos;

    // Start is called before the first frame update
    void Start()
    {
        //para tomar el eje x e y del jugador
        lastPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        //el vector3 permite que la camara siga al jugador en el eje x e y, pero no en el z
        transform.position = new Vector3(target.position.x, Mathf.Clamp(target.position.y, minHeight, maxHeight), transform.position.z);

        //Calcular la cantidad de ejes que se mueve el jugador
        Vector2 amountToMove = new Vector2(transform.position.x - lastPos.x, transform.position.y - lastPos.y);

        //asignar el fondo lejano
        farBackground.position = farBackground.position + new Vector3(amountToMove.x, amountToMove.y, 0);

        //asignar el fondo medio
        middleBackground.position += new Vector3(amountToMove.x, amountToMove.y, 0);

        //actualizar la ultima posicion del jugador
        lastPos = transform.position;
    }
}
