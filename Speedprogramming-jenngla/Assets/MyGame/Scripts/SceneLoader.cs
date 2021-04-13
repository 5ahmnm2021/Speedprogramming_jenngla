using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void Load01()
    {
        // if correct Button was pressed, this will happen
        SceneManager.LoadScene("Scene2");
    }

    public void Load02()
    {
        // if correct Button was pressed, this will happen
        SceneManager.LoadScene("Scene3");
    }
}
