using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //QualitySettings.vSyncCount = 0;
        //Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        float movement = 3.0f;
        float horizontal = Input .GetAxis("Horizontal");
        float vertical = Input .GetAxis("Vertical");
        
        Vector2 position = transform.position;
        position.x = position.x + movement * horizontal * Time.deltaTime;
        position.y = position.y + movement * vertical * Time.deltaTime;
        transform.position = position;
    }
}
