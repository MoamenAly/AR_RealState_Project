using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AvatarIntro : MonoBehaviour
{
    public GameObject avatar;
    public UnityEvent onAudioFinished;
    private AudioSource audioSource;
    private bool isAudioPlaying = false;

    void Start()
    {
        if (avatar != null)
        {
            avatar.SetActive(false);
            audioSource = avatar.GetComponent<AudioSource>();
        }
    }

    public void ShowAvatarAndPlayAudio()
    {
        if (avatar == null || audioSource == null) return;

        avatar.SetActive(true);
        if (audioSource.clip != null)
        {
            audioSource.Play();
            isAudioPlaying = true;
        }
    }

    void Update()
    {
        if (isAudioPlaying && !audioSource.isPlaying)
        {
            isAudioPlaying = false;
            AudioFinished();
        }
    }

    void AudioFinished()
    {
        Debug.Log("Audio finished playing.");
        onAudioFinished?.Invoke();
    }
}
