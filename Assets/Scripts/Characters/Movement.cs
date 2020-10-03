using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class Movement : MonoBehaviour{

    [SerializeField]
    [Range(0,500)]
    protected float speed = 5f;

    protected Vector2 currentDirection;
    protected Rigidbody2D rigidbody2;

    protected abstract void Init();
    protected abstract void UpdateChild();
    protected abstract Vector2 GetDirection();

    void Awake(){
        rigidbody2 = GetComponent<Rigidbody2D>();
        Init();
    }

    void FixedUpdate(){
        currentDirection = GetDirection();
        currentDirection *= speed;
        currentDirection *= Time.fixedDeltaTime;
        UpdateChild();  
        rigidbody2.AddForce(currentDirection);
    }

}
