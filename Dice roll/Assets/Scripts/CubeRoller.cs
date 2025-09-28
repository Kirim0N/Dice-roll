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
        cube.AddForce(Random.Range(0,3), Random.Range(0,3), Random.Range(0,3), ForceMode.Impulse);
        cube.AddTorque(Random.Range(0,3), Random.Range(0,3), Random.Range(0,3), ForceMode.Impulse);
    }
}
