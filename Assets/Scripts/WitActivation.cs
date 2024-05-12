using Meta.WitAi;
using UnityEngine;
using UnityEngine.InputSystem;

public class WitActivation : MonoBehaviour
{
    [SerializeField] private Wit wit;

    private void OnValidate()
    {
        if (!wit) wit = GetComponent<Wit>();
    }

    public void ButtonActivate(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            wit.Activate();
        }
    }
}
