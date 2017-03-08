using UnityEngine;
using System.Collections;
using System;

public class Vatcan : MonoBehaviour {
    public float speed_Down = 0;
    public float posion_max = -2.6f;
    public float posion_min = -4.6f;

     bool Play { get;  set; }

    // Use this for initialization
    void Start () {
        float x = UnityEngine.Random.Range(posion_min, posion_max);
        transform.localPosition = new Vector3(x, transform.localPosition.y, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && !Play)
            Play = true;
        if (transform.localPosition.y < -6.5f)
            move();
        if(Play)
            transform.Translate(Vector3.down * speed_Down * Time.deltaTime);
   
           
	}

    private void move()
    {
        float x = UnityEngine.Random.Range(posion_min, posion_max);
        float y = 6.5f;
        transform.localPosition = new Vector3(x, y, 0);

    }

}
