using System.Collections.Generic;
using UnityEngine;

public class Challenge_Easy_Spawn_Minion_Solution : MonoBehaviour
{

    [Header("Minion Object to Spawn")]
    [SerializeField]
    private GameObject MinionPrefab;

    [Header("Minion Position to Spawn")] 
    [SerializeField]
    private Transform MinionSpawnTransform;

    private List<GameObject> _spawnedMinions = new();
    private List<GameObject> _minionsToDestroy = new();

    private float horizontalInput = 0.25f;
    private static readonly float BorderXPosition = 7.5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _spawnedMinions.Add(Instantiate(MinionPrefab, MinionSpawnTransform.position, MinionSpawnTransform.rotation));
        }
    }
    
    private void FixedUpdate()
    {
        foreach (GameObject spawnedMinion in _spawnedMinions)
        {
            spawnedMinion.transform.Translate(horizontalInput, 0f, 0f);
            if (spawnedMinion.transform.position.x > BorderXPosition)
            {
                _minionsToDestroy.Add(spawnedMinion);
            }
        }

        foreach (GameObject minionToDestroy in _minionsToDestroy)
        {
            if (_spawnedMinions.Remove(minionToDestroy))
            {
                Destroy(minionToDestroy);
            }
        }
        _minionsToDestroy.Clear();
    }
}
