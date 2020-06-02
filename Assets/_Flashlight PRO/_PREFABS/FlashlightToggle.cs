
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class FlashlightToggle : UdonSharpBehaviour
{

    public GameObject FlashLight;
    public GameObject FLLight;
    public bool on;

    void Start()
    {
        on = false;
    }

    public override void OnPickupUseDown()
    {
        FLLight.SetActive(!FLLight.activeSelf);
    }

}
