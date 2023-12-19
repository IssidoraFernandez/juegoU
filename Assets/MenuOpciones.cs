using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuOpciones : MonoBehaviour
{
    //Creaci�n de referencia a Mixer de Audio
    [SerializeField] private AudioMixer audioMixer;

    //Funci�n para reescalar la pantalla a tama�o completo
    public void PantallaCompleta(bool pantallaCompleta){
        Screen.fullScreen = pantallaCompleta;
    }

    //Funci�n para controlar volumen de la m�sica del videojuego
    public void CambiarVolumen(float volumen)
    {
        audioMixer.SetFloat("Volumen", volumen);
    }


    //Funci�n para cambiar calidad gr�fica del videojuego
    public void CambiarCalidad(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }
}
