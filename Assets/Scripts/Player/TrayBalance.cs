using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrayBalance : MonoBehaviour
{
    [SerializeField] private Transform tray;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TrayRotation(Transform player, float angle, float rotateSpeed)
    {
        tray.rotation = Quaternion.Euler(player.rotation.x, player.rotation.y, -angle * rotateSpeed);
    }
}
