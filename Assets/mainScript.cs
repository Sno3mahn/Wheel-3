using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainScript: MonoBehaviour
{
    private float Speed;
    public bool isSpin = true;
    public float maxSpeed = 600; 

    public GameObject pointer;

    void Start(){

        Speed = maxSpeed;
    }

    void Update()
    {
      Rotate ();
    }
    void Rotate()
    {

     transform.Rotate (0,0, Speed * Time.deltaTime);
     
     if(isSpin == false && Speed > 0)
     {
        Stop ();
     }

    }

    public void Stop()
    {
      isSpin = false;
        
        Speed--;
        if(Speed <= 0)
        {
          
          pointer.GetComponent<BoxCollider> ().enabled = true;
          Speed = 0;
        }

    }

    public void SPIN(){
        isSpin = true;
        pointer.GetComponent<BoxCollider> ().enabled = false;
        Speed = maxSpeed;
    }
}


