using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class VisualizeVelocity : MonoBehaviour
{
    [SerializeField] [Range(0.1f, 20)] private float arrowLength = 1.0f;

    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnDrawGizmos()
    {
        if (!Application.isPlaying) return;

        var position = transform.position;
        var velocity = _rb.velocity;

        // if (velocity.magnitude < 0.1f) return;

        Handles.color = Color.red;
        Handles.ArrowHandleCap(0, position, Quaternion.LookRotation(velocity), arrowLength, EventType.Repaint);
    }
}