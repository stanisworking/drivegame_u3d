using UnityEngine;
using UnityEngine.Audio;

public class AudioDucker : MonoBehaviour
    {
    public AudioMixerSnapshot normalSnapshot;
    public AudioMixerSnapshot duckedSnapshot;

    public void Duck(){        
        duckedSnapshot.TransitionTo(0.01f);
    }

    public void Unduck(){
        normalSnapshot.TransitionTo(1.0f);
    }
}
