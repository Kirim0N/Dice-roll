using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Game : MonoBehaviour
{
    [SerializeField] private DiceSpawner cubeSpawner;
    [SerializeField] private List<Cube> cubes;
    [Range(0, 1000)][SerializeField] private float maxForce = 500f;
    [Range(0, 100)][SerializeField] private float maxTorque = 100f;
    
    public IEnumerable<Cube> Cubes => cubes;
    public float Value => Cubes.Sum(cube => cube.CurrentValue);
    public UnityEvent NeedRedraw;
    
    private int win;
    private int draw;

    public int Win
    {
        get => win;
        set
        {
            win = value;
            NeedRedraw?.Invoke();
        }
    }

    public int Draw
    {
        get => draw;
        set
        {
            draw = value;
            NeedRedraw?.Invoke();
        }
    }

    private void Awake()
    {
        RollCubes();

        foreach (var cube in cubes)
        {
            cube.ValueStablished.AddListener(CubeValueStablished);
        }
    }
    public void RollCubes()
    {
        foreach (var cube in cubes)
        {
            cube.Rb.AddForce(UnityEngine.Random.Range(-maxForce, maxForce), UnityEngine.Random.Range(0, maxForce), UnityEngine.Random.Range(-maxForce, maxForce), ForceMode.Impulse);
            cube.Rb.AddTorque(UnityEngine.Random.Range(-maxTorque, maxTorque), UnityEngine.Random.Range(-maxTorque, maxTorque), UnityEngine.Random.Range(-maxTorque, maxTorque), ForceMode.Impulse);
        }
    }

    private void CubeValueStablished()
    {
        NeedRedraw?.Invoke();
    }

    public void SpawnCube()
    {
        var cube = cubeSpawner.GetCube();
        cubes.Add(cube);
        cube.ValueStablished.AddListener(CubeValueStablished);
    }
}
