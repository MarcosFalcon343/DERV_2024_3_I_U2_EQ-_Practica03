using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3_ResetPersonaje : MonoBehaviour
{
    float valor_y;
    [SerializeField] Transform spanwPoint;

    void Update()
    {
        valor_y = transform.position.y;
        if (valor_y < -2)
        {
            transform.position = spanwPoint.position;
        }
        if(Input.GetKeyDown(KeyCode.R)){
            transform.SetPositionAndRotation(new Vector3(transform.position.x,2,transform.position.z), Quaternion.identity);
        }
    }
}
