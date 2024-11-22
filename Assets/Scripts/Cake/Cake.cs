using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake : MonoBehaviour
{
    private PlayerController player;
    private bool _isCakeDrop;

    private void Start()
    {
        _isCakeDrop = false;
    }

    private void Update()
    {
    }

    private void CakeDrop()
    {
        _isCakeDrop = true;
        Debug.Log("Drop the cake!");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            CakeDrop();
        }

        if(collision.gameObject.GetComponent<TrayBalance>() != null)
        {
            var parent = collision.gameObject.GetComponentInParent<TrayBalance>();
            Debug.Log(parent.name);        }
    }

    
}
