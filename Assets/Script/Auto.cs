using UnityEngine;
using System.Collections;

public class Auto : MonoBehaviour {
    public float speed;
    public float huongquay =1;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //chuyển động xoay
        //Debug.Log(transform.rotation.z);
       
        // nếu >30 do thi quay nguoc lai
        if(transform.rotation.z > 0.26f)
        {
            huongquay = -1;
            speed = huongquay * speed;
        }

        if (transform.rotation.z < -0.26f)
        {
            huongquay = -1;
            speed = huongquay * speed;
        }
        this.transform.Rotate(0, 0, speed);
    }
}
