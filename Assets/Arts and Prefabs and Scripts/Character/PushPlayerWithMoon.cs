using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPlayerWithMoon : MonoBehaviour
{

    //public GameObject Mooncenter;
    public float PlayerPushedForce = -10;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Moon")
        {
            transform.Translate(new Vector2(PlayerPushedForce * Time.deltaTime, 0));
        }
    }

    //private void Update()
    //{
    //    transform.LookAt(Mooncenter.transform, Vector3.back);
    //}
}
