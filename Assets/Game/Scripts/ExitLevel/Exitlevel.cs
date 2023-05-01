using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Exitlevel : MonoBehaviour
{
    [SerializeField] private Button _exitLevel;

    private void Awake()
    {
        _exitLevel.onClick.AddListener(()=> { ExitLevel(0); });
    }

    private void ExitLevel(int level)
    {
        SceneManager.LoadScene(level);
    }
}
