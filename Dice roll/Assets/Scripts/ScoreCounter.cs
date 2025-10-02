using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private Rigidbody cubeRigidbody;

    int isStill = 0;
    void FixedUpdate()
    {

        if (cubeRigidbody.linearVelocity.magnitude == 0.0f)
        {
            // Debug.Log("объект остановился");
            isStill++;
        }
        
        if (isStill == 2)
        {
            CheckSide(cube);
        }
        
    }

    private void CheckSide(GameObject cube)
    {
        Debug.Log("CheckSide");
    }
}
