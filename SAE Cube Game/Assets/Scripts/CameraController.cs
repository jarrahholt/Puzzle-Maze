using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;
    public Vector3 cameraSecondOffset;

    void Start()
    {
        offset = transform.position - player.transform.position ;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset - cameraSecondOffset;
    }
}