using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public float turnSpeed = 100;

    public InputAction moveAction;
    public Vector2 moveInput;

    void Start()
    {
        moveAction.Enable();
    }
    
    void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * moveInput.x);
    }
}
