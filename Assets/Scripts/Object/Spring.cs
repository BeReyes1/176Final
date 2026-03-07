using UnityEngine;
using KinematicCharacterController.Examples;

public class Spring : MonoBehaviour
{
    [SerializeField] private float springForce = 20;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ExampleCharacterController>() != null)
        {
            other.GetComponent<ExampleCharacterController>().SpringJump(springForce);
        }
    }
}
