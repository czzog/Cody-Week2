using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOnOffPressureBox : MonoBehaviour
{
    public GameObject objectToToggle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Interactive")
        {
            if (objectToToggle.active == true)
            {
                objectToToggle.SetActive(false);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Interactive")
        {
            if (objectToToggle.active == false)
            {
                objectToToggle.SetActive(true);
            }
        }
    }


}