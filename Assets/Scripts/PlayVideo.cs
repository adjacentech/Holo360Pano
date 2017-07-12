using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour {

    private VideoPlayer videoPlayer;

    private void Awake()
    {
        // Get video player
        videoPlayer = GetComponent<VideoPlayer>();
        // Prepare, video will play on awake
        videoPlayer.Prepare();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
