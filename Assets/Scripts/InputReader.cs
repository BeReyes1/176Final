using UnityEngine;
using UnityEngine.InputSystem;
using New;
using System;

[CreateAssetMenu(menuName = "ScriptableObjects/InputReader")]
public class InputReader : ScriptableObject, CustomInput.IPlayerActions
{
    public CustomInput newerInput;

    private void OnEnable()
    {
        if (newerInput == null)
        {
            newerInput = new CustomInput();
            newerInput.Player.SetCallbacks(this);
        }

        SetGameplay();
    }

    public void SetGameplay()
    {
        newerInput.Player.Enable();
    }

    public event Action JumpEvent;
    public event Action<Vector2> LookEvent;
    public event Action<Vector2> MoveEvent;
    public event Action SprintEvent;
    public event Action GrappleEvent;

    public void OnCrouch(InputAction.CallbackContext context)
    {
        
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            JumpEvent?.Invoke();
        }
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        LookEvent?.Invoke(context.ReadValue<Vector2>());
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        MoveEvent?.Invoke(context.ReadValue<Vector2>());
    }

    public void OnSprint(InputAction.CallbackContext context)
    {
        SprintEvent?.Invoke();
    }

    public void OnGrapple(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            GrappleEvent?.Invoke();
        }
    }
}
