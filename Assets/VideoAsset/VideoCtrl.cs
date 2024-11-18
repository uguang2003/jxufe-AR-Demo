using easyar;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Video;

public class VideoCtrl : MonoBehaviour
{
    public string VideoInStreamingAssets;
    private UnityEngine.Video.VideoPlayer player;
    bool isplay = false;
    private void Start()
    {   
        isplay = false;
        player=gameObject.GetComponent<UnityEngine.Video.VideoPlayer>();
        player.url = Path.Combine(Application.streamingAssetsPath, VideoInStreamingAssets);
    }
   
    private void Update()
    {
        if (this.gameObject.activeSelf == true && isplay==false)
        {
            player.Play();
            isplay = true;
        }
    }
}
