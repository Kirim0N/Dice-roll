using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class Cube : MonoBehaviour
{
    [SerializeField] private Rigidbody cubeRigidbody;
    [SerializeField] private List<Face> faces;
    private int currentValue;
    private int numberOfStop = 0;


    public int CurrentValue
    {
        get => currentValue;
        private set => currentValue = value;
    }
    
    public Rigidbody Rb => cubeRigidbody;

    public UnityEvent ValueStablished;
    private void Awake()
    {
        foreach (var face in faces)
        {
            face.TriggerEntered.AddListener(OnTriggerEntered);
        }
    }
    
    void Update()
    { 
        if (cubeRigidbody.linearVelocity.magnitude == 0.0f)
        {
            numberOfStop++;
        }
        
        if (numberOfStop > 1)
        {
            // OnDiceStoppedEvent();
            ValueStablished.Invoke();
            return;
        }
    }

    private void OnTriggerEntered(Face face)
    {
        CurrentValue = 7 - face.Value;
    }
}
