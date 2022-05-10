
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] float _speed = 5f;
    private InputActions _inputactions;
    private Rigidbody2D _rbody;
    private Vector3 _moveInput;

    Shooter shooter;

    void Awake()
    {
        shooter = GetComponent<Shooter>();
        _inputactions = new InputActions();
        _rbody = GetComponent<Rigidbody2D>();
        if (_rbody is null)
        {
            Debug.LogError("Rigidbody is NULL!");
        }
    }



    // For input system
    private void OnEnable()
    {
        _inputactions.Player.Enable();
    }
    // For input system
    private void OnDisable()
    {
        _inputactions.Player.Disable();
    }

    void FixedUpdate()
    {
        _moveInput = _inputactions.Player.Move.ReadValue<Vector2>();
        _rbody.MovePosition(transform.position + _moveInput * Time.deltaTime * _speed);

    }

    void OnFire(InputValue value)
    {
        if (shooter != null)
        {
            shooter.isFiring = value.isPressed;
        }
    }

}
