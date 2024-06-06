using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    public float tiltSpeed = 20.0f;

    void Update()
    {
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltSpeed;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltSpeed;

        Quaternion target = Quaternion.Euler(tiltAroundX, 0, -tiltAroundZ);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
    }
}
