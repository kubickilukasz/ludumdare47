using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Movement{

    public static PlayerMovement Instance{private set; get;}

    protected override void Init(){
        if(Instance == null){
            Instance = this;
        }else if(Instance != this){
            Destroy(gameObject);
        }
    }

    protected override void UpdateChild(){

    }

    protected override Vector2 GetDirection(){
        return new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

}
