using UnityEngine;
using UnityEngine.UI;
//using Windows.Kinect;

using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;
using System.IO;

public class ReadJoinPos : Singleton<ReadJoinPos>
{
    private Vector3 leftHandPos = Vector3.zero;
    private Vector3 rightHandPos = Vector3.zero;
    private Vector3 headPos = Vector3.zero;

    public Text joinPosText;

    public long playerUserID;
    // Start is called before the first frame update
    void Start()
    {
        // KinectManager
    }

    // Update is called once per frame
    void Update()
    {
        KinectManager kinectManager = KinectManager.Instance;
        leftHandPos = kinectManager.GetJointPosition(playerUserID, (int)KinectInterop.JointType.HandLeft);
        rightHandPos = kinectManager.GetJointPosition(playerUserID, (int)KinectInterop.JointType.HandRight);
        headPos = kinectManager.GetJointPosition(playerUserID, (int)KinectInterop.JointType.Head);
        joinPosText.text = 
            "Left Hand Pos: " + "X: "+leftHandPos.x + " Y: "+leftHandPos.y + " Z: "+leftHandPos.z + System.Environment.NewLine +
            "Right Hand Pos: " + "X: "+rightHandPos.x + " Y: "+rightHandPos.y + " Z: "+rightHandPos.z + System.Environment.NewLine +
            "Head Pos: " + "X: "+headPos.x + " Y: "+headPos.y + " Z: "+headPos.z;
    }
}
