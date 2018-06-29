using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour {
    public Transform houreTransform, minutesTransform, secondTransform;
    public bool updateCon;
	// Use this for initialization
	void Awake () {
        
    }
	
    void UpdateContinous()
    {
        System.TimeSpan time = System.DateTime.Now.TimeOfDay;
        //Debug.Log(System.DateTime.Now);
        houreTransform.localRotation =
        Quaternion.Euler(0,(float) (time.TotalHours) * 30f, 0);
        minutesTransform.localRotation =
       Quaternion.Euler(0, (float)time.TotalMinutes * 6f, 0);
        secondTransform.localRotation =
       Quaternion.Euler(0, (float)time.TotalSeconds * 6f, 0);
    }
     void UpdateDescrite()
    {
        System.DateTime time = System.DateTime.Now;
        //Debug.Log(System.DateTime.Now);
        houreTransform.localRotation =
        Quaternion.Euler(0, time.Hour * 30f, 0);
        minutesTransform.localRotation =
       Quaternion.Euler(0, time.Minute * 6f, 0);
        secondTransform.localRotation =
       Quaternion.Euler(0, time.Second * 6f, 0);
    }
    // Update is called once per frame
    void Update () {
        if (updateCon)
        {
            UpdateContinous();

        }
        else
        {
            UpdateDescrite();
        }
    }
}
