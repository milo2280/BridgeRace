using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform cameraTranform, player;
    public Vector3 offset;

    private Vector3 temp;

    private void LateUpdate()
    {
        temp = player.position;
        temp.y = 0f;
        cameraTranform.position = temp + offset;
    }
}
