using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    //Función para acceder al juego desde el menú de inicio
    public void Jugar() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Función para salir del videojuego desde el menú de inicio
    public void Salir(){
        Debug.Log("Salir...");
        Application.Quit();
    }

}
