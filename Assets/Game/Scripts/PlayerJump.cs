using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float _jumpTimeThreshold = 0.5f;
    [SerializeField] private float _maxJumpForce = 20f;
    [SerializeField] private AnimationCurve _jumpCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);

    private Rigidbody2D rb;
    private bool isJumping;
    private float jumpStartTime;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        CheckInput();
    }

    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            jumpStartTime = Time.time;
        }

        if (Input.GetKeyUp(KeyCode.Space) && isJumping)
        {
            isJumping = false;
            float jumpTime = Time.time - jumpStartTime;
            float jumpForce = CalculateJumpForce(jumpTime);
            Jump(jumpForce);
        }
    }

    private float CalculateJumpForce(float jumpTime)
    {
        float jumpPercent = Mathf.Clamp01(jumpTime / _jumpTimeThreshold);
        float jumpForce = _maxJumpForce * _jumpCurve.Evaluate(jumpPercent);
        return jumpForce;
    }

    private void Jump(float jumpForce)
    {
        rb.velocity = new Vector2(jumpForce, jumpForce);
    }
}
