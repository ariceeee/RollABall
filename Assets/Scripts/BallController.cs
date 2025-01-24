using System.Numerics;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 2f;

    // Jump vars:
    private float jumpAmnt = 4.0f; // how big of a jump ball will make
    private bool isGrounded; // ball state: whether or not ball is currently on ground

    void Start()
    {
        // ball is initially on ground
        isGrounded = true;
    }

    void Update()
    {
        // Ball can only jump if currently on ground (ie: is not mid-air/mid-jump)
        // and player has pressed spacebar
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            Jump();
        }

    }
    // Adds vertical force to ball, taking its mass into account and sets isGrounded 
    // to reflect the fact that we are jumping
    void Jump()
    {
        sphereRigidbody.AddForce(UnityEngine.Vector3.up * jumpAmnt, ForceMode.Impulse);
        isGrounded = false;
    }

    // Jump
    // Checks for collisions btwn ball and anything, then if the collision is w the floor
    // ie: ball has touched floor, sets isGrounded to say we're back on the ground
    // Purpose of this: 1) prevent double/triple/etc. jumps, and 2) if we were to add more game objects
    // to this, we don't necessarily want collisions w those to affect isGrounded (only collisions w
    // the floor should affect that)
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            isGrounded = true;
        }
    }

    public void MoveBall(UnityEngine.Vector2 input)
    {
        UnityEngine.Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }
}
