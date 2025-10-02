using UnityEngine;

public class CubeRoller : MonoBehaviour
{
    [SerializeField] private Rigidbody cube;

    void Awake()
    {
        Roll(cube);
    }
    private void Roll(Rigidbody cube)
    {
        cube.AddForce(Random.Range(-50,50), Random.Range(-50,50), Random.Range(-50,50), ForceMode.Impulse);
        cube.AddTorque(Random.Range(-50,50), Random.Range(-50,50), Random.Range(-50,50), ForceMode.Impulse);
    }
}
