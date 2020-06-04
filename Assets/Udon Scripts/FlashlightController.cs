
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class FlashlightController : UdonSharpBehaviour
{

    public GameObject FLight;

    private int playerCount = 0;
    private const int MAX_PLAYERS = 20;
    private GameObject[] FLights;

    void Start()
    {
        FLights = new GameObject[MAX_PLAYERS];
    }
    public override void OnPlayerJoined(VRCPlayerApi player)
    {
        playerCount++;
        GameObject newFLight = VRCInstantiate(FLight);
        newFLight.transform.SetPositionAndRotation(transform.position, new Quaternion());
        FLights[playerCount - 1] = newFLight;
    }

    public override void OnPlayerLeft(VRCPlayerApi player)
    {
        playerCount--;
    }
}
