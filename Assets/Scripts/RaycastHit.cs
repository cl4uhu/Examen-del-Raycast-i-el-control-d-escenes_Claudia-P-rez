using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{  
    GameManager _gamemanager;

    void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        Debug.DrawLine(ray.origin, hit.point, Color.green);
        
            if(hit.transform.gameObject.layer == 3);
            {
                Debug.Log(hit.transform.name)
                Debug.Log
            }
    }
}