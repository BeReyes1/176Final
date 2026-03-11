using UnityEngine;
using System;
using KinematicCharacterController.Examples;

public class ColliderTrigger : MonoBehaviour
{
    public event Action OnPlayerEnters;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ExampleCharacterController>() != null)
        {
            OnPlayerEnters?.Invoke();
        }
    }
}
