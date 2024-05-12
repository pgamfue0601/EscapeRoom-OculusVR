using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private GameObject door;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenDoor()
    {
        Quaternion rotationRequired = Quaternion.Euler(0, -90, 0);
        door.transform.rotation = Quaternion.Lerp(door.transform.rotation, rotationRequired, 1.5f);
    }

    public void OpenDoorSecond(string[] values)
    {
        Quaternion rotationRequired = Quaternion.Euler(0, -90, 0);
        door.transform.rotation = Quaternion.Lerp(door.transform.rotation, rotationRequired, 1.5f);
    }

    public void OpenDoorSecond(string value)
    {
        Quaternion rotationRequired = Quaternion.Euler(0, -90, 0);
        door.transform.rotation = Quaternion.Lerp(door.transform.rotation, rotationRequired, 1.5f);
    }
}
