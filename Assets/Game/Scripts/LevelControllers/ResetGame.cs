using DG.Tweening;
using UnityEngine;

public class ResetGame : MonoBehaviour
{
    [SerializeField] private Transform _playerTr;
    private Vector3 startPosition;

    private void Awake()
    {
        startPosition = _playerTr.position;
    }

    public void RestartLevel()
    {
        ResetPlayerPosition();
        InitPlayerOrientation();
        ResetJumpCounter();
    }

    private void ResetPlayerPosition()
    {
        _playerTr.DOMove(startPosition, 0.5f);
    }

    private void InitPlayerOrientation()
    {
        PlayerOrientation.CurrentOrientation = Orientation.Right;
        _playerTr.localScale = new Vector3(0.4f, 0.4f, 0.4f);
    }

    private void ResetJumpCounter()
    {
        JumpCounter.Instance.ResetCounter();
    }
}
