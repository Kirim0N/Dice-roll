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
        cube.AddForce(Random.Range(-1000,1000), Random.Range(-1000,1000), Random.Range(-1000,1000), ForceMode.Impulse);
        cube.AddTorque(Random.Range(-100,100), Random.Range(-100,100), Random.Range(-100,100), ForceMode.Impulse);
    }
}
