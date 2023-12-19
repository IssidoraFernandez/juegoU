using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    //Funci�n para acceder al juego desde el men� de inicio
    public void Jugar() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Funci�n para salir del videojuego desde el men� de inicio
    public void Salir(){
        Debug.Log("Salir...");
        Application.Quit();
    }

}
