using UnityEngine;
using System.Collections;

public class Rotating : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime * speed);
    }
}