using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    void Start()
    {
        // offset = transform.position - player.position;
    }

    // Update is called once per frame
    void LateUpdate ()
    {
        transform.position = target.position + offset;
        // Vector3 targetPos = transform.position = player.position + offset;
        // targetPos.y = 0;
        // transform.position = targetPos;
    }
}
