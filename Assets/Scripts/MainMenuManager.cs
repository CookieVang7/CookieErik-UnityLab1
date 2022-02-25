using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{

    [SerializeField] private Button startButton;
    [SerializeField] private Button openCreditsButton;
    [SerializeField] private Button closeCreditsButton;
    [SerializeField] private Button platformerButton;
    [SerializeField] private Button spawnButton;
    [SerializeField] private Button pongButton;
    [SerializeField] private Button fpsButton;

    [SerializeField] private GameObject creditsUI;

    // Start is called before the first frame update
    void Start()
    {

        openCreditsButton.onClick.AddListener(
            () => {
                creditsUI.SetActive(true);
            });


        closeCreditsButton.onClick.AddListener(
            () => {
                creditsUI.SetActive(false);
            });


        startButton.onClick.AddListener(
            () => { 
                LoadingScreen.LoadScene("GunGame");
            });

        platformerButton.onClick.AddListener(
            () => {
                LoadingScreen.LoadScene("NotQuitePlatformer");
            });


        spawnButton.onClick.AddListener(
            () => {
                LoadingScreen.LoadScene("3DSpawn");
            });

        pongButton.onClick.AddListener(
            () =>
            {
                LoadingScreen.LoadScene("Pong");
            });

        fpsButton.onClick.AddListener(
            () =>
            {
                LoadingScreen.LoadScene("FPS");
            });


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
