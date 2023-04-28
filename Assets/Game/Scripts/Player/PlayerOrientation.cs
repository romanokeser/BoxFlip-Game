using UnityEngine;

public class PlayerOrientation : MonoBehaviour
{
    public static Orientation CurrentOrientation;
    private float _xScale = 0.4f;

    private void Awake()
    {
        DetectFlipper.OnFlipperTrigger += FlipThePlayer;
    }

    private void FlipThePlayer()
    {
        CurrentOrientation = CurrentOrientation == Orientation.Left ? Orientation.Right : Orientation.Left;
        _xScale = -_xScale;

        transform.localScale = new Vector3(_xScale, 0.4f, 0.4f);  //hardcoded shit gotta remove 
    }
}

public enum Orientation
{
    Left,
    Right
}