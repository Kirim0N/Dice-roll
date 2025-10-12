 using UnityEngine;

public class Plane : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var face = other.GetComponent<Face>();

        if (face is not null)
        {
            face.TriggerEnter();
        }
    }
}
