using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    AudioSource audioSource;
   
    public List<AudioClip> clips = new List<AudioClip>();
    // Start is called before the first frame update

    void Start()
    {
        clips.Add((AudioClip)Resources.Load(" Sound/openning "));
        clips.Add((AudioClip)Resources.Load(" Sound/normal "));
        clips.Add((AudioClip)Resources.Load(" Sound/scared "));
        clips.Add((AudioClip)Resources.Load(" Sound/dead "));
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = Resources.Load<AudioClip>("Sound/normal");
            audioSource.Play();
        }
    }
}
