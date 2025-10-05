using UnityEngine;

public class CubeRoller : MonoBehaviour
{
    [SerializeField] private Rigidbody cube;
    [SerializeField] private float maxForce;
    [SerializeField] private float maxTorque;

    void Awake()
    {
        Roll(cube);
    }
    private void Roll(Rigidbody cube)
    {
        cube.AddForce(Random.Range(-maxForce, maxForce), Random.Range(-maxForce, maxForce), Random.Range(-maxForce, maxForce), ForceMode.Impulse);
        cube.AddTorque(Random.Range(-maxTorque, maxTorque), Random.Range(-maxTorque, maxTorque), Random.Range(-maxTorque, maxTorque), ForceMode.Impulse);
    }
}
