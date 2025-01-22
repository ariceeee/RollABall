using System.Numerics;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody sphereRigidbody;
    public float ballSpeed = 2f;

    void Start()
    {

    }

    void Update()
    {
        UnityEngine.Vector2 inputVector = UnityEngine.Vector2.zero; // init
        if (Input.GetKey(KeyCode.W))
        {
            inputVector += UnityEngine.Vector2.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector += UnityEngine.Vector2.down;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector += UnityEngine.Vector2.left;
        }

        if (Input.GetKey(KeyCode.D))
        {
            inputVector += UnityEngine.Vector2.right;
        }

        UnityEngine.Vector3 inputXZPlane = new UnityEngine.Vector3(inputVector.x, 0, inputVector.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);

        Debug.Log("Resultant Vector: " + inputVector);

    }
}
