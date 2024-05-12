using Meta.WitAi;
using UnityEngine;

public class WitActivation : MonoBehaviour
{
    [SerializeField] private Wit wit;

    private void OnValidate()
    {
        if (!wit) wit = GetComponent<Wit>();
    }

    void Start()
    {
        wit.Activate();
    }
}
