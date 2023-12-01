using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void SphereScene()
    {
        SceneManager.LoadScene(1);
    }

    public void CubeScene()
    {
        SceneManager.LoadScene(2);
    }

    public void PlaneScene()
    {
        SceneManager.LoadScene(3);
    }
}
