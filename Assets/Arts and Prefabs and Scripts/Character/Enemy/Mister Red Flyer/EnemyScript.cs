using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Feedbacks;

public class EnemyScript : MonoBehaviour
{
    public MMFeedbacks FeedbacksonDeath;

    public MMFeedbacks FeedbacksonPlayerDeath;

    private Transform Player;

    private DeathScript PlayerdeathScript;

    private MeshRenderer thisMesh;


    public float SpeedofFollow;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        PlayerdeathScript = GameObject.FindGameObjectWithTag("Player").GetComponent<DeathScript>();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Player.position, SpeedofFollow * Time.deltaTime);
    }
}
