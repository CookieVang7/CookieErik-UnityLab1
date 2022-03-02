using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScene : MonoBehaviour
{
    //private void Awake()
    //{
    //    IEnumerator youDied() {
    //        yield return new WaitForSeconds(3f);
    //        LoadingScreen.LoadScene("MainMenu");
    //   

    //} }

    void Start()
    {
        StartCoroutine(youDied());
    }

    IEnumerator youDied()
    {
        yield return new WaitForSeconds(3f);
        LoadingScreen.LoadScene("MainMenu");
    }

}
