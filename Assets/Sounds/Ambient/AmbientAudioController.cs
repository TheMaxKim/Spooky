
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class AmbientAudioController : UdonSharpBehaviour
{
    public AudioSource ForestAmbience;
    public AudioSource SpookyAmbience;

    public float forestAmbienceMaxDelay = 15f;

    void Start()
    {
        ForestAmbience.Play();
    }

    void Update()
    {
        LoopForestAmbience();
    }

    private void LoopForestAmbience()
    {
        if (!ForestAmbience.isPlaying)
        {
            float forestAmbienceDelay = Random.Range(0f, forestAmbienceMaxDelay);
            ForestAmbience.PlayDelayed(forestAmbienceDelay);
        }
    }

    public void LoopSpookyAmbience()
    {
        SpookyAmbience.loop = true;
        SpookyAmbience.Play();
    }
}
