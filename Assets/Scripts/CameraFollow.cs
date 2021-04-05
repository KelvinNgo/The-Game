using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public float cameraHeightY = 20.0f;
    public float cameraHeightX = 20.0f;
    public float cameraHeightZ = 20.0f;

    void Update()
    {
        Vector3 pos = player.transform.position;
        pos.y += cameraHeightY;
        pos.x += cameraHeightX;
        pos.z += cameraHeightZ;
        transform.position = pos;
    }

}