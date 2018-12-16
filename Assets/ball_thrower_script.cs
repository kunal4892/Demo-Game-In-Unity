using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_thrower_script : MonoBehaviour {

    public GameObject ball;
    public GameObject pad;
    bool should_throw = false;
    float lerpSpeed = 50f;

    //could be done via assigning to each trigger in the GUI.
    void Start ()
    {
        pad = GameObject.Find(findPadTag() + "_pad");
    }

    private void OnTriggerEnter(Collider other)
    {
        print("tag check pending");
        print(other.tag.ToString());
        if (other.tag == ball.tag)
        {
            should_throw = true;
            if (pad)
            {
                ball.transform.parent = null;
                ball.GetComponent<Rigidbody>().isKinematic = true;
                ball.GetComponent<Rigidbody>().useGravity = true;
                print("putting the ball onto the pad now!!");
                ball.transform.position = Vector3.Lerp(ball.transform.position, pad.transform.position, Time.deltaTime * lerpSpeed);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        print("out of throw zone:");
    }

    private string findPadTag()
    {
        string pad_tag = ball.tag.ToString();
        pad_tag = pad_tag.Substring(0, pad_tag.IndexOf("_"));
        print(pad_tag);
        return pad_tag;
    }
}
