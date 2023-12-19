using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuOpciones : MonoBehaviour
{
    //Creación de referencia a Mixer de Audio
    [SerializeField] private AudioMixer audioMixer;

    //Función para reescalar la pantalla a tamaño completo
    public void PantallaCompleta(bool pantallaCompleta){
        Screen.fullScreen = pantallaCompleta;
    }

    //Función para controlar volumen de la música del videojuego
    public void CambiarVolumen(float volumen)
    {
        audioMixer.SetFloat("Volumen", volumen);
    }


    //Función para cambiar calidad gráfica del videojuego
    public void CambiarCalidad(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }
}
