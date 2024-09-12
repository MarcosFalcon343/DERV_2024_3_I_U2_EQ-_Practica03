using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3_DestruyeConsumibles : MonoBehaviour
{
    private void OnCollisionEnter(Collision other){
        GameObject objeto = other.gameObject;
        if(!objeto.CompareTag("Escenario")){
            Destroy(objeto);
        }
    }
}
