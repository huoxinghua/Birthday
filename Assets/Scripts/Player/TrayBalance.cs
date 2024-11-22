using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrayBalance : MonoBehaviour
{
    public void TrayRotation(Transform player, float angle, float rotateSpeed)
    {
        transform.localRotation = Quaternion.Euler(0f, 0f, -angle * rotateSpeed);
    }
}
