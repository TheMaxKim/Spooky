
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class AmbientAudioController : UdonSharpBehaviour
{
    public AudioSource ForestAmbience;
    public AudioSource SpookyAmbience;

    public float forestAmbienceMinDelay;
    public float forestAmbienceMaxDelay;

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
            float forestAmbienceDelay = Random.Range(forestAmbienceMinDelay, forestAmbienceMaxDelay);
            ForestAmbience.PlayDelayed(forestAmbienceDelay);
        }
    }

    public void LoopSpookyAmbience()
    {
        SpookyAmbience.loop = true;
        SpookyAmbience.Play();
    }
}
