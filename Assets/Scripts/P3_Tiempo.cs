using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class P3_Tiempo : MonoBehaviour
{

    [SerializeField]  P3_HandlerGame handler;
    int cont;
    [SerializeField] TextMeshProUGUI texto_tiempo;
    void Start()
    {
        cont = 60;
        StartCoroutine(currutina_contador());
    }

    IEnumerator currutina_contador(){
        while(cont > 0){
            cont--;
            texto_tiempo.text = cont.ToString();
            yield return new WaitForSeconds(1f); 
        }
        this.handler.cambioEscenaFinalizado();
    }
}
