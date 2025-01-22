using System.Numerics;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 2f;

    void Start()
    {

    }

    void Update()
    {

    }

    public void MoveBall(UnityEngine.Vector2 input)
    {
        UnityEngine.Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }
}
