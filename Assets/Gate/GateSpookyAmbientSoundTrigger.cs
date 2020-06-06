
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class GateSpookyAmbientSoundTrigger : UdonSharpBehaviour
{

    bool spookyAmbienceTriggered;

    [SerializeField] AmbientAudioController ambientAudioController;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (!spookyAmbienceTriggered)
        {
            spookyAmbienceTriggered = true;
            ambientAudioController.LoopSpookyAmbience();
        }
    }
}
