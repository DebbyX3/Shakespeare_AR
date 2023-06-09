using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource AudioInnerHill;
    public AudioSource AudioTrustDelusion;
    public AudioSource AudioNoBoundaries;

    IEnumerable Start()
    {
        AudioInnerHill.Play();
        yield return new WaitForSeconds(5);
        AudioTrustDelusion.Play();
    }
    //There is no way out, because there is no outside.Nothing will come of nothing.
    void Update()
    {
        
    }

    public void PlayInnerHill()
    {
        AudioInnerHill.Play();
        Debug.Log("Inner Hill started");
    }

    public void PlayTrustDelusion()
    {
        AudioTrustDelusion.Play();
        Debug.Log("Trust Delusion started");
    }

    public void PlayNoBoundaries()
    {
        AudioNoBoundaries.Play();
        Debug.Log("No Boundaries started");
    }
}
