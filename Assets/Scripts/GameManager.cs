using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("SceneMenu");
    }

    // Update is called once per frame
    void Scene1()
    {
        SceneManager.LoadScene("Scene1 1");
    }

    void Scene2()
    {
        SceneManager.LoadScene("Scene1 2");
    }

    void Scene3()
    {
        SceneManager.LoadScene("Scene1 3");
    }
}
