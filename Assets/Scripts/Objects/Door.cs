using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private GameObject doorPivot;
    public float rotationAngle = 90f; 
    public float rotationDuration = 1f; 

    private Quaternion initialRotation;
    private Quaternion targetRotation;
    private bool isRotating = false;
    private float rotationTime = 0f;

    [SerializeField] DoorTrigger trigger;
    void Start()
    {
        initialRotation = doorPivot.transform.rotation;
        targetRotation = Quaternion.Euler(0, rotationAngle, 0) * initialRotation;
    }

    private void OnEnable()
    {
       
        if (trigger != null)
        {
            trigger.doorTrigger.AddListener(OpenDoor);
        }
    }

    private void OnDisable()
    {
        
        if (trigger != null)
        {
            trigger.doorTrigger.RemoveListener(OpenDoor);
        }
    }
    public void OpenDoor()
    {
        if (!isRotating)
        {
          
            isRotating = true;
            rotationTime = 0f;
        }
    }

    void FixedUpdate()
    {
       
        if (isRotating)
        {
            Debug.Log("open door");
            rotationTime += Time.fixedDeltaTime / rotationDuration;
            doorPivot.transform.rotation = Quaternion.Lerp(initialRotation, targetRotation, rotationTime);
            if (rotationTime >= 1f)
            {
                isRotating = false;
            }
        }

    }
}
