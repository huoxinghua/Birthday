using UnityEngine;

[CreateAssetMenu(fileName = "GameCheckpoint", menuName = "Checkpoint/Create New Checkpoint")]
public class CheckpointData : ScriptableObject
{
    public Vector3 playerPosition;
}
