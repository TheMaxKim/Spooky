
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Cube : UdonSharpBehaviour
{
    public GameObject FL;
    void Start()
    {
        
    }

    public override void Interact()
    {
        GameObject newFL = VRCInstantiate(FL);
        newFL.transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), new Quaternion());
    }
}
