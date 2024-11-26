using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrayBalance : MonoBehaviour
{
    [SerializeField] private BoxCollider trigger;
    [SerializeField] private float trayBalanceValue;

    private Cake _cake;

    public void TrayRotation(Transform player, float angle, float rotateSpeed)
    {
        transform.localRotation = Quaternion.Euler(0f, 0f, -angle * rotateSpeed * Time.deltaTime);

        _cake.transform.localPosition += new Vector3(angle * trayBalanceValue * 0.01f, 0f, 0f);
    }

    private void OnTriggerStay(Collider other)
    {
        _cake = other.GetComponent<Cake>();
        if (_cake != null)
        {
            Debug.Log("Caking" + _cake.IsCakeDrop);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _cake = other.GetComponent<Cake>();
        if (_cake != null)
        {
            _cake.CakeDrop();
        }
    }
}
