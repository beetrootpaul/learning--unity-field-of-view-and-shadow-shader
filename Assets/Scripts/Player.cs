using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5.0f;

    private Rigidbody? _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        var hInput = Input.GetAxis("Horizontal");
        var vInput = Input.GetAxis("Vertical");
        var movement = new Vector3(hInput, 0.0f, vInput).normalized * movementSpeed;
        _rb.MovePosition(_rb.position + movement * Time.fixedDeltaTime);
    }
}