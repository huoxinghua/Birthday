using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrayBalance : MonoBehaviour
{
    [SerializeField] private BoxCollider trigger;
    public void TrayRotation(Transform player, float angle, float rotateSpeed)
    {
        transform.localRotation = Quaternion.Euler(0f, 0f, -angle * rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerStay(Collider other)
    {
        var cake = other.GetComponent<Cake>();
        if (cake != null)
        {
            Debug.Log("Caking" + cake.IsCakeDrop);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var cake = other.GetComponent<Cake>();
        if (cake != null)
        {
            cake.CakeDrop();
        }
    }
}
