using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button _playGameBtn;
    [SerializeField] private Button _optionsBtn;
    [SerializeField] private Button _exitBtn;

    private void Awake()
    {
        _playGameBtn.onClick.AddListener(PlayGame);
        _optionsBtn.onClick.AddListener(OpenOptions);
        _exitBtn.onClick.AddListener(ExitApp);
    }

    private void ExitApp()
    {
        Application.Quit();
    }

    private void OpenOptions()
    {
        Debug.Log("Open options now");
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("LevelLoader");
    }
}
