using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_picker_script : MonoBehaviour {

    public Transform ball;
    public Transform player;
    private Transform arm1;
    private Transform arm2;
    public float lerpSpeed;
    public bool picked = false;

	void Start () {
        player = GameObject.Find("Player").transform;
        arm1 = GameObject.Find("arm1").transform;
        arm2 = GameObject.Find("arm2").transform;
        lerpSpeed = 5f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Player") && picked == false)
        {
            ball.parent = GameObject.Find("Player").transform;
            ball.GetComponent<Rigidbody>().useGravity = false;
            ball.GetComponent<Rigidbody>().isKinematic = true;
            lerp();
            picked = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        print("out of the pickup zone");
    }

    public Vector3 getHoldingPosition()
    {

        float xcoord = ((arm1.position.x + arm2.position.x) / 2 + 0.25f);
        float ycoord = (arm1.position.y + arm2.position.y) / 2;
        float zcoord = (arm1.position.z + arm2.position.z) / 2;
        Vector3 pos = new Vector3(xcoord, ycoord, zcoord);
        return pos;
    }
    
    // Could use both both 1.lerp  2. directly equate coordinates.
    public void lerp()
    {
        ball.position = Vector3.Lerp(ball.position, getHoldingPosition(), Time.deltaTime * lerpSpeed);
        //ball.position = getHoldingPosition();
    }
}
