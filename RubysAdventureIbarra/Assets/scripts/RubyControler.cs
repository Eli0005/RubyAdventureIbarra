using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //create 2 varibales to use the unity built in axes
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = input.GetAxis("Vertical");

        //Create our movement vector
        vector2 position = transform.position;

        //create horizontal and vertical movement
        postion.x = position.x + 3.0f * horizontal * Time.delta
        postion.y = postion.y + 3.0f * vertical * time.delta
    }
}
