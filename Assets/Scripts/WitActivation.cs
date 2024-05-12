using Meta.WitAi;
using UnityEngine;

public class WitActivation : MonoBehaviour
{
    [SerializeField] private Wit wit;

    private void OnValidate()
    {
        if (!wit) wit = GetComponent<Wit>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            wit.Activate();
        }
    }
}
