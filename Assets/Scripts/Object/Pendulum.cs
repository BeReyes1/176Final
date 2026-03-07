using UnityEngine;
using KinematicCharacterController;

public class Pendulum : MonoBehaviour, IMoverController
{
    public PhysicsMover Mover;

    private Vector3 _originalPosition;
    private Quaternion _originalRotation;
    [SerializeField] private float swingAngle = 30f;  
    [SerializeField] private float swingSpeed = 1f;   
    public Vector3 swingAxis = Vector3.forward; 

    private void Start()
    {
        _originalPosition = Mover.Rigidbody.position;
        _originalRotation = Mover.Rigidbody.rotation;

        Mover.MoverController = this;
    }

    public void UpdateMovement(out Vector3 goalPosition, out Quaternion goalRotation, float deltaTime)
    {
        goalPosition = _originalPosition;
        float angle = Mathf.Sin(Time.time * swingSpeed) * swingAngle;
        goalRotation = Quaternion.AngleAxis(angle, swingAxis.normalized) * _originalRotation;
    }
}
