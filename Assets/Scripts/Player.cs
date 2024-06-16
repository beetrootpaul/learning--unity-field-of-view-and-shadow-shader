using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5.0f;

    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        var hInput = Input.GetAxis("Horizontal");
        var vInput = Input.GetAxis("Vertical");

        _rb.velocity =  new Vector3(hInput, 0, vInput).normalized * movementSpeed;
        
        // prevent rotation e.g. due to friction
        _rb.rotation = Quaternion.identity;
    }
}