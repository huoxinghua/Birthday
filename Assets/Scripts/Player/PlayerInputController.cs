using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    private PlayerInput inputActions;
    private PlayerController controller;

    private void Awake()
    {
        controller = GetComponent<PlayerController>();
    }

    private void OnEnable()
    {
        if(controller == null) return;
        inputActions = new PlayerInput();

        inputActions.Enable();
        inputActions.Player.Movement.performed += ctx => controller.MovementInput(ctx.ReadValue<Vector2>());
        inputActions.Player.LookAt.performed += ctx => controller.MousePosition(ctx.ReadValue<Vector2>());
        inputActions.Player.BalanceCake.performed += ctx => controller.BalanceCakeInput(ctx.ReadValue<float>());
    }
}
