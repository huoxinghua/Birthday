using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    public static CheckPointManager Instance { get; private set; }
    [SerializeField] CheckpointData checkpoint;
    private Vector3 lastCheckpointPosition;
    [SerializeField] private GameObject player;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

        }
        else
        {
            Destroy(gameObject);
        }
    }
 

    public void SaveCheckpoint(Vector3 position)
    {
        lastCheckpointPosition = position;
        Debug.Log("saved ScriptableObject");
    }

    public void LoadCheckpoint()
    {
        player.transform.position = lastCheckpointPosition;
        Debug.Log("Load check point");

    }
  
 
}
