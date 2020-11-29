using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Feedbacks;

public class MisterRedTalk : MonoBehaviour
{

    public MMFeedbacks Cemewholo;
    public MMFeedbacks Idletalk;
    public AudioSource Voice;


    public void CemeWholo() //CemewholoCemewholoCemewholoCemewholoCemewholo
    {
        if (!Cemewholo.IsPlaying)
        {
            Idletalk.StopFeedbacks();
            Cemewholo.PlayFeedbacks();
        }
    }

    public void IdleTalk() //Idle talk sound event
    {
        if (!Idletalk.IsPlaying)
        {
            Cemewholo.StopFeedbacks();
            Idletalk.PlayFeedbacks();
        }
    }

    public void ShutUp() //Makes sure he is quiet when dead
    {
        Voice.Stop();
    }
}
