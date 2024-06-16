using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    [SerializeField] private Transform? followedObject;
    [SerializeField] private Vector3 relativePosition = new(0, 2, -3);


    private void Update()
    {
        transform.position = followedObject.transform.position + relativePosition;
    }
}