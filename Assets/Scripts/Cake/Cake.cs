using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake : MonoBehaviour
{
    [SerializeField] private Transform player;

    private bool _isCakeDrop;

    private void Awake()
    {
        
    }

    private void Start()
    {
        _isCakeDrop = false;
    }

    void Update()
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
    }
}
