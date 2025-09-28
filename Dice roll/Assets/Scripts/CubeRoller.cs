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
        cube.AddForce(Random.Range(-5,5), Random.Range(-5,5), Random.Range(-5,5), ForceMode.Impulse);
        cube.AddTorque(Random.Range(-3,3), Random.Range(-3,3), Random.Range(-3,3), ForceMode.Impulse);
    }
}
