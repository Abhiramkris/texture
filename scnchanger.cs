using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public string scene2;
    public void LoadScene()
    {
        SceneManager.LoadScene(scene2);
    }
}
