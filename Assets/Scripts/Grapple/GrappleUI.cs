using UnityEngine;
using UnityEngine.UI;
using KinematicCharacterController.Examples;

public class GrappleUI : MonoBehaviour
{
    [SerializeField] private Image grappleImage;
    [SerializeField] private ExampleCharacterController cc;

    private void OnEnable()
    {
        cc.GrappleEvent += HandleGrappleUI;
    }

    private void OnDisable()
    {
        cc.GrappleEvent -= HandleGrappleUI;
    }

    private void HandleGrappleUI(bool avaliable)
    {
        grappleImage.color = avaliable ? Color.white : Color.black;
    }
}
