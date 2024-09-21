using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class P3_Tiempo : MonoBehaviour
{

    [SerializeField]  P3_HandlerGame handler;
    [SerializeField]int TiempoContador;
    [SerializeField] TextMeshProUGUI texto_tiempo;
    void Start()
    {
        StartCoroutine(currutina_contador());
    }

    IEnumerator currutina_contador(){
        while(TiempoContador > 0){
            TiempoContador--;
            texto_tiempo.text = TiempoContador.ToString();
            yield return new WaitForSeconds(1f); 
        }
        handler.cambioEscenaFinalizado();
    }
}
