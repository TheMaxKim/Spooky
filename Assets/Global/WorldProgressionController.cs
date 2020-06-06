
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class WorldProgressionController : UdonSharpBehaviour
{

    [SerializeField] AmbientAudioController ambientAudioController;

    bool spookyInitiated;

    void Start()
    {
        
    }

    public void InitiateSpooky()
    {
        if (!spookyInitiated)
        {
            spookyInitiated = true;
            ambientAudioController.LoopSpookyAmbience();
        }
    }
}
