using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3_MovimientoRotacion : MonoBehaviour
{
    [SerializeField] int velocidad_movimiento;
    [SerializeField] int velocidad_rotacion;
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            transform.rotation = Quaternion.Euler(0, 0, 0); // Rotar en el eje Y a 0 grados
            transform.position += velocidad_movimiento * Time.deltaTime * transform.forward;
        }else if(Input.GetKey(KeyCode.S)){
            transform.rotation = Quaternion.Euler(0, 180, 0); // Rotar en el eje Y a 0 grados
            transform.position += velocidad_movimiento * Time.deltaTime * transform.forward;
        }else if(Input.GetKey(KeyCode.A)){
            transform.rotation = Quaternion.Euler(0, -90, 0); // Rotar en el eje Y a 0 grados
            transform.position += velocidad_movimiento * Time.deltaTime * transform.forward;
        }else if(Input.GetKey(KeyCode.D)){
            transform.rotation = Quaternion.Euler(0, 90, 0); // Rotar en el eje Y a 0 grados
            transform.position += velocidad_movimiento *Time.deltaTime * transform.forward;
        }
    }
}

