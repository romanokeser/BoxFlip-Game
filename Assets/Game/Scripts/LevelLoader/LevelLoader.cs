using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private Button _level1Btn;

    private void Awake()
    {
        _level1Btn.onClick.AddListener(() => { LoadLevel(2); });
    }

    private void LoadLevel(int level)
    {
        SceneManager.LoadScene(level);
    }
}
