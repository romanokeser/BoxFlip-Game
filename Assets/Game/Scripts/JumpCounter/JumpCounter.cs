using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JumpCounter : MonoBehaviour
{
    public static JumpCounter Instance;
    [SerializeField] private TextMeshProUGUI _counterTxt;
    public int Counter;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
    }

    public void IncrementCounter()
    {
        Counter++;
        _counterTxt.text = "Jumps: " + Counter;
    }

    public void ResetCounter()
    {
        Counter = 0;
        _counterTxt.text = "Jumps: " + 0;
    }
}
