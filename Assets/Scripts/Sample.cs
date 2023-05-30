using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sample : MonoBehaviour
{
    public void Switch1() {
        SceneManager.LoadScene("Scene2");
    }
    public void Switch2() {
        SceneManager.LoadScene("Scene1");
    }
    //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}
