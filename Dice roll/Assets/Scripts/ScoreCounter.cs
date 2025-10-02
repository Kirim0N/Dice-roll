using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private Rigidbody cubeRigidbody;
    [SerializeField] private Collider side1;
    [SerializeField] private Collider side2;
    [SerializeField] private Collider side3;
    [SerializeField] private Collider side4;
    [SerializeField] private Collider side5;
    [SerializeField] private Collider side6;
    [SerializeField] private Collider floorCollider;

    private int isStill = 0;
    private List<Collider> sideList;
    private Dictionary<Collider, int> sideValueDict;

    void Awake()
    {
        sideList = new List<Collider> {side1, side2, side3, side4, side5, side6};
        sideValueDict.Add(side1, 1);
        sideValueDict.Add(side2, 2);
        sideValueDict.Add(side3, 3);
        sideValueDict.Add(side4, 4);
        sideValueDict.Add(side5, 5);
        sideValueDict.Add(side6, 6);
    }
    void FixedUpdate()
    { 
        if (cubeRigidbody.linearVelocity.magnitude == 0.0f)
        {
            isStill++;
        }
        
        if (isStill == 2)
        {
            CheckSide(cube, sideList, floorCollider);
        }
    }
    
    

    private void CheckSide(GameObject cube, List<Collider> sideList, Collider floorCollider)
    {
        var number = 0;
        foreach (var side in sideList)
        {
            if (side.IsTrigger(floorCollider))
            {
                SideValueDict.TryGetValue(side, out number);
                Debug.Log(number);
            }
        }
    }
}
