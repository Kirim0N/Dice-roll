using UnityEngine;
using System.Collections.Generic;

public class DiceSpawner : MonoBehaviour
{
    [SerializeField] private Cube prefab;
    [SerializeField] private Transform spawnPoint;

    public Cube GetCube()
    {
        var instance = Instantiate(prefab);
        // spawnPoint.position += new Vector3 (0, 5, 0); // doesn't work
        return instance;
    }

    public IEnumerable<Cube> GetCubes(int amount)
    {
        for (var i = 0; i < amount; i++)
        {
            yield return GetCube();
        }
    }
}
