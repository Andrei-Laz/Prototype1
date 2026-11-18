using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public float turnSpeed = 100;

    public InputAction moveAction;
    private Vector2 _moveInput;

    void Start()
    {
        moveAction.Enable();
    }
    
    void Update()
    {
        _moveInput = moveAction.ReadValue<Vector2>();
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * _moveInput.y);
        
        //The axis for the rotation is (0, 1, 0) because that is how you rotate a left to right
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * _moveInput.x);
    }
}
