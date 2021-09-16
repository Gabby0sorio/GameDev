using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code: MonoBehaviour
{
    float speed = 1;

    public float Speed { get => speed; set => speed = value; }

    // Update is called once per frame
    void Update()
    {

        Vector3 temp = this.transform.position;
        //we store the current position value of the transform of the object this component is in
        //basically we store the current position of the object.

        // we add speed to the current X value of temp
        temp.x = temp.x + speed * Time.deltaTime;



        //And alternate way of writing the previuos line
        //temp.x += speed;

        //we assign temp as the new position of the object.
        //we're teleporting the object in very small ampunts really quickly.
        this.transform.position = temp;


    }      

}
