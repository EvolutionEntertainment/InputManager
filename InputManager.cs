using UnityEngine;

[CreateAssetMenu(fileName = "InputManager", menuName = "ScriptableObject / InputManager")]
public class InputManager : ScriptableObject
{
    public PlayerControls PlayerControls { get; private set; }

    void OnEnable()
    {
        PlayerControls = new PlayerControls();

        PlayerControls.Enable();
    }

    void OnDisable()
    {
        PlayerControls.Disable();
    }
}
