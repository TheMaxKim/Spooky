
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class AmbientAudioController : UdonSharpBehaviour
{
    public AudioSource ForestAmbience;
    public AudioSource SpookyAmbience;
    public GameObject GateEventCollider;

    public float forestAmbienceMaxDelay = 15f;

    void Start()
    {
        ForestAmbience.Play();
    }

    void Update()
    {
        if (!ForestAmbience.isPlaying)
        {
            float forestAmbienceDelay = Random.Range(0f, forestAmbienceMaxDelay);
            ForestAmbience.PlayDelayed(forestAmbienceDelay);
        }
    }
}
