using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
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
        
    }

    public void CakeDrop()
    {
        _isCakeDrop = true;
        transform.parent = null;
        rb.isKinematic = false;
        rb.useGravity = true;
        Debug.Log("Drop the cake!");
    }
}
