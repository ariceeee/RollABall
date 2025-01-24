using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();
    void Start()
    {

    }

    void Update()
    {
        UnityEngine.Vector2 inputVector = UnityEngine.Vector2.zero; // init

        if (Input.GetKey(KeyCode.W))
        {
            inputVector += UnityEngine.Vector2.right;
        }

        if (Input.GetKey(KeyCode.S))
        {
            inputVector += UnityEngine.Vector2.left;
        }

        if (Input.GetKey(KeyCode.A))
        {
            inputVector += UnityEngine.Vector2.up;
        }

        if (Input.GetKey(KeyCode.D))
        {
            inputVector += UnityEngine.Vector2.down;
        }

        // '?' says that if no listeners for this event, compiler will safely handle it (as opposed to throwing a an exception)
        OnMove?.Invoke(inputVector);
    }
}
