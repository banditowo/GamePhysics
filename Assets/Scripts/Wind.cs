using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public Vector3 windDirection = new Vector3(1, 0, 0); // Default wind direction
    public float windStrength = 5.0f; // Wind strength

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Marble"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(windDirection.normalized * windStrength);
            }
        }
    }
}
