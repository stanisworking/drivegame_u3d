using UnityEngine;
using UnityEngine.Audio;

public class AudioDucker : MonoBehaviour
    {
    public AudioMixerSnapshot normalSnapshot;
    public AudioMixerSnapshot duckedSnapshot;

    public void Duck(){        
        duckedSnapshot.TransitionTo(0.5f);
    }

    public void Unduck(){
        normalSnapshot.TransitionTo(0.5f);
    }
}
