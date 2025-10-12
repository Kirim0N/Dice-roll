using UnityEngine;
using UnityEngine.Events;

public class Face : MonoBehaviour
{
    [SerializeField] private int value;
    
    public int Value => value;

    public UnityEvent<Face> TriggerEntered;

    private void OnTriggerEnter(Collider other)
    {
        TriggerEntered.Invoke(this);
    }
}
