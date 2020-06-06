
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class GateSpookyAmbientSoundTrigger : UdonSharpBehaviour
{
    [SerializeField] WorldProgressionController worldProgressionController;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        worldProgressionController.InitiateSpooky();
    }
}
