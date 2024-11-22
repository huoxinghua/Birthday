using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] private LayerMask mask;
    [SerializeField] private float slopeSpeed;

    private bool isGround;

    public bool IsGround => isGround;

    private void Awake()
    {
        
    }

    private void Update()
    {
        GroundCheckRay();
    }
    private void GroundCheckRay()
    {
        if(Physics.Raycast(transform.position, -transform.up, out RaycastHit hit, 0.01f, mask))
        {
            RotateWithSlope(hit.transform);

            Debug.DrawLine(transform.position, transform.position - 0.5f * transform.up, Color.red);
            isGround = true;
        }
        else
        {
            isGround = false;
        }
    }

    public void RotateWithSlope(Transform objectToMatch)
    {
        
        Debug.Log("rotate!");
    }
}
