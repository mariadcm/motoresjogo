using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    private void LatUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y,transform.position.z);
    }
}
