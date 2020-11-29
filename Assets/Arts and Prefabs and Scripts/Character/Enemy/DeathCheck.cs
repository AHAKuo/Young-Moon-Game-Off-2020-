using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HutongGames.PlayMaker;

public class DeathCheck : MonoBehaviour
{
    private PlayMakerFSM Score;
    public MeshRenderer meshRenderer;
    public BoxCollider2D disablebox;
    private ParticleSystem ScoreFlare;
    private void Awake()
    {
        Score = GameObject.FindGameObjectWithTag("ScoreFSM").GetComponent<PlayMakerFSM>();
        ScoreFlare = GameObject.FindGameObjectWithTag("ScoreFlare").GetComponent<ParticleSystem>();
    }
    public void EnemyDied()
    {
        ScoreFlare.Play();
        meshRenderer.enabled = false;
        disablebox.enabled = false;
        Score.FsmVariables.GetFsmInt("Score").Value += 100;
    }
}
