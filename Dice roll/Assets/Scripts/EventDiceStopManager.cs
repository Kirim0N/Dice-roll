using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EventDiceStopManager : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private Rigidbody cubeRigidbody;

    private int isStill = 0;

	public delegate void DiceStopped();
	public static event DiceStopped OnDiceStoppedEvent;

    private void Update()
    { 
        if (cubeRigidbody.linearVelocity.magnitude == 0.0f)
        {
            isStill++;
        }
        
        if (isStill == 2)
        {
            OnDiceStoppedEvent();
        }
    }
}
