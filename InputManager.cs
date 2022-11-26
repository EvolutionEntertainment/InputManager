using UnityEngine;

[CreateAssetMenu(fileName = "InputManager", menuName = "ScriptableObject / InputManager")]
public class InputManager : ScriptableObject
{
    PlayerControls PlayerControls;

    void OnEnable()
    {
        PlayerControls = new PlayerControls();

        PlayerControls.Enable();
    }

    void OnDisable()
    {
        PlayerControls.Disable();
    }

    public float OnMovement()
    {
        return PlayerControls.Player.Movement.ReadValue<Vector2>().x;
    }

    public bool OnJump()
    {
        return PlayerControls.Player.Jump.triggered;
    }
}