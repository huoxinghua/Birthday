using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorTrigger : MonoBehaviour
{
    public UnityEvent doorTrigger;
    private void OnTriggerEnter(Collider other)
    {
        if (!other.GetComponent<PlayerController>())
        {
            //load another room
            doorTrigger?.Invoke();
        }
    }
}
