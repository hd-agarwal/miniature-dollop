using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform objectToFollow;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position=objectToFollow.position+offset;
    }
}
