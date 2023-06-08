using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource AudioInnerHill;

    // Start is called before the first frame update
    void Start()
    {
        AudioInnerHill.Play();
        Debug.Log("started");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
