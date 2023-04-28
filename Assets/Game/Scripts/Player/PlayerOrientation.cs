using System;
using UnityEngine;

public class PlayerOrientation : MonoBehaviour
{
    public static Orientation CurrentOrientation;

    private void Awake()
    {
        DetectFlipper.OnFlipperTrigger += FlipThePlayer;
    }

    private void FlipThePlayer()
    {
        CurrentOrientation = CurrentOrientation == Orientation.Left ? Orientation.Right : Orientation.Left;
        transform.localScale = new Vector3(transform.localScale.x, -1f, transform.localScale.z);
    }
}

public enum Orientation
{
    Left,
    Right
}