using UnityEngine;
using UnityEngine.Events;

public class Face : MonoBehaviour
{
    [SerializeField] private int value;
    
    public int Value => value;

    public UnityEvent<Face> TriggerEntered;

    public void TriggerEnter()
    {
        TriggerEntered.Invoke(this);
    }
}