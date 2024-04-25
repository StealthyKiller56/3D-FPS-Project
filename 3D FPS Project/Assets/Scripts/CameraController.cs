using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform objectToFollow;

    // Start is called before the first frame update
    void LateUpdate()
    {
        transform.position = objectToFollow.position;
        transform.rotation = objectToFollow.rotation;
    }
}
