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
        _playerTr.localScale = new Vector3(0.2f, 0.2f, 0.2f);//hardcoded shit gotta remove ayy
    }

    private void ResetJumpCounter()
    {
        JumpCounter.Instance.ResetCounter();
    }
}
