using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 postion = transform.position;
        position.x = position.x + 0.1f;
        transform.position = position;
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
        position.x = position.x + 3.0f * horizontal * Time.delta;
        position.y = position.y + 3.0f * vertical * Time.delta;
    }
}
