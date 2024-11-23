using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GiftBox : MonoBehaviour
{
    [SerializeField] GameObject balloonPerfabs;
    [SerializeField] int balloonCount = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.GetComponent<PlayerController>())
        {
            SpawnBalloons();
            Destroy(gameObject);
        }
    }
    private void SpawnBalloons()
    {
        for (int i = 0; i < balloonCount; i++) 
        {
            SpawnBalloon();
        }
    }
    private void SpawnBalloon()
    {
        Vector3 spawnPosition = this.transform.position + new Vector3(Random.Range(-2f, 2f), Random.Range(-1f,1f), Random.Range(-2f, 2f));
        var obj = Instantiate(balloonPerfabs, spawnPosition, Quaternion.identity);
        obj.GetComponent<Balloon>().isSpawned = true;
    }
}
