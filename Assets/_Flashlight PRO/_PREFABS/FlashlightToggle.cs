
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class FlashlightToggle : UdonSharpBehaviour
{

    public GameObject FLLight;

    void Start()
    {
    }

    public override void OnPickupUseDown()
    {
        FLLight.SetActive(!FLLight.activeSelf);
    }

}
