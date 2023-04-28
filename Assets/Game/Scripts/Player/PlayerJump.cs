using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float _jumpTimeThreshold = 0.5f;
    [SerializeField] private float _maxJumpForce = 20f;
    [SerializeField] private AnimationCurve _jumpCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
    [SerializeField] private float _flipSpeed = 5f;

    private Rigidbody2D rb;
    private bool isJumping;
    private float jumpStartTime;
    private bool hasLanded;
    private bool isInAir;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        CheckInput();
        if (isInAir)
        {
            //Flip();
        }
    }

    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping && hasLanded)
        {
            isJumping = true;
            jumpStartTime = Time.time;
            hasLanded = false;
            rb.freezeRotation = true;
            isInAir = true;
        }

        if (Input.GetKeyUp(KeyCode.Space) && isJumping)
        {
            isJumping = false;
            float jumpTime = Time.time - jumpStartTime;
            float jumpForce = CalculateJumpForce(jumpTime);
            Jump(jumpForce);
            rb.freezeRotation = false;
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
        float xForce = jumpForce;
        if (PlayerOrientation.CurrentOrientation == Orientation.Left) // if player is flipped, jump to the left
        {
            xForce = -jumpForce;
        }
        else
        {
            xForce = jumpForce;
        }
        rb.velocity = new Vector2(xForce, jumpForce * 2);
    }

    private void Flip()
    {
        transform.Rotate(Vector3.forward, _flipSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            hasLanded = true;
            // check the angle of the player and rotate it accordingly
            float angle = transform.rotation.eulerAngles.z;
            if (angle > 90f && angle < 270f)
            {
                transform.Rotate(0, 0, 180f);
            }
        }
    }
}
