using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{  
    [SerializeField] GameManager _gameManager;

    void Awake()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            RaycastHit();
        }
    }

    void RaycastHit()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.DrawLine(ray.origin, hit.point, Color.green);
            
            if(hit.transform.gameObject.tag == "Sphere")
            {
                _gameManager.SphereScene();  
            }

            if(hit.transform.gameObject.tag == "Cube")
            {
                _gameManager.CubeScene();  
            }

            if(hit.transform.gameObject.tag == "Plane")
            {
                _gameManager.PlaneScene();  
            }
        }
    }
}