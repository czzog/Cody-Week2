using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBox : MonoBehaviour
{
    public GameObject teleportLocation;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Interactive")
        {
            other.transform.position = teleportLocation.transform.position;
        }

    }
}