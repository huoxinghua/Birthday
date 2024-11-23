using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake : MonoBehaviour
{
    private PlayerController player;
    private Rigidbody rb;
    private bool _isCakeDrop;

    public bool IsCakeDrop
    {
        get => _isCakeDrop;
        set => _isCakeDrop = value;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        player = GetComponentInParent<PlayerController>();
    }

    private void Update()
    {
        if (!_isCakeDrop)
        {
            
            transform.localPosition = new Vector3(rb.velocity.x, transform.localPosition.y, 0);
        }
    }

    public void CakeDrop()
    {
        _isCakeDrop = true;
        transform.parent = null;
        Debug.Log("Drop the cake!");
    }

    private void OnCollisionEnter(Collision collision)
    {/*
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            CakeDrop();
        }

        if(collision.gameObject.GetComponentInParent<TrayBalance>() != null)
        {
            var parent = collision.gameObject.GetComponentInParent<TrayBalance>();
            Debug.Log(parent.name);
        }*/
    }

    
}
