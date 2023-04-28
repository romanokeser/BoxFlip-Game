using System;
using UnityEngine;

public class DetectFlipper : MonoBehaviour
{
    public static Action OnFlipperTrigger;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Flipper"))
        {
            OnFlipperTrigger?.Invoke();
        }
    }
}
