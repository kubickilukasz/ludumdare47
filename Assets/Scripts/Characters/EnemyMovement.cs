using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyMovement : Movement{

    [SerializeField]
    protected float distance = 20f;

    [SerializeField]
    protected bool isFriendly = false;

    protected PlayerMovement playerMovement;

    //On start because on Awake is setting Instance of PlayerMovement
    void Start(){
        playerMovement = PlayerMovement.Instance;
    }

    protected override Vector2 GetDirection(){
        Vector2 dir;
        if(!isFriendly && DistanceFromPlayer() <= distance){
            dir = playerMovement.transform.position - transform.position;
            dir.Normalize();
        }else{
            dir = Vector2.zero;
        }
        return dir; 
    }

    protected float DistanceFromPlayer(){
        return Vector2.Distance(playerMovement.transform.position, transform.position);
    }

}
