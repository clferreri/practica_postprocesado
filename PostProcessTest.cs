using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessTest : MonoBehaviour
{
    public PostProcessVolume vol;

    private Bloom _bloom;
    private Vignette _vignette;
    void Start()
    {
        vol.profile.TryGetSettings(out _bloom);
        vol.profile.TryGetSettings(out _vignette);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _bloom.intensity.value += 10f;
        }
    }
}
