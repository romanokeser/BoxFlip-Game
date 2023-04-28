using UnityEngine;

public class PlayerInit : MonoBehaviour
{
    public bool IsPlayerFacingRight = true;

    private void Awake()
    {
        if (IsPlayerFacingRight)
        {
            PlayerOrientation.CurrentOrientation = Orientation.Right;
        }
        else
        {
            PlayerOrientation.CurrentOrientation = Orientation.Left;
        }
    }
}
