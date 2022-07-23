using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCollision : PunLocalBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player p = collision.gameObject.GetComponentInChildren<Player>();
        if (p != null && p.SetPlayerReachedTarget())
        {
            Debug.Log($"Player {p.playerName} reached target");
        }
    }


}
