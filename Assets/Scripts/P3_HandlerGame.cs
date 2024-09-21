using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P3_HandlerGame : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI texto;
    [SerializeField] TextMeshProUGUI Texto_puntuacion;
    int puntuacion = 0;
    void Update()
    {
        int index_scene_active = SceneManager.GetActiveScene().buildIndex;
        if (index_scene_active == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(1);
            }
        }else if(index_scene_active == 1){
            Texto_puntuacion.text = puntuacion.ToString();
        }else if(index_scene_active == 2){
            this.texto.text = PlayerPrefs.GetString("Label");
            Texto_puntuacion.text = PlayerPrefs.GetInt("Puntuacion",0).ToString();
        }
    }


    public void cambioEscena(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void cambioLabel(string label){
        PlayerPrefs.SetString("Label", label);
    }

    public void cambioPuntacion(int puntuacion){
        PlayerPrefs.SetInt("Puntuacion",puntuacion);
    }


    public void agregarPuntuacion(int puntuacion){
        this.puntuacion += puntuacion;
        if(this.puntuacion >= 8400){
            this.cambioLabel("Lo haz conseguido, tu puntuacion fue");
            this.cambioPuntacion(this.puntuacion);
            this.cambioEscena(2);
        }
    }

    public void cambioEscenaFinalizado(){
        cambioLabel("Se acabo el tiempo, tu puntuacion fue");
        cambioPuntacion(puntuacion);
        cambioEscena(2);
    }




}
