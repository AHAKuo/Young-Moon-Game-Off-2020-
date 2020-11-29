using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public void Kill()
    {
        Destroy(gameObject, 5f);
    }
}
