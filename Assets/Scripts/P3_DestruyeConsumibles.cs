using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3_DestruyeConsumibles : MonoBehaviour
{
    [SerializeField] P3_HandlerGame handler;
    private void OnCollisionEnter(Collision other){
        GameObject objeto = other.gameObject;
        if(objeto.CompareTag("Consumible")){
            Destroy(objeto);
            handler.agregarPuntuacion(100);
        }
    }
}
