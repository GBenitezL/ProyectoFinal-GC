// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public enum Axle{
//     Front, 
//     Back
// }

// public struct Wheel{
//     public GameObject model;
//     public WheelCollider wheelCollider;
//     public Axle axle;
// }


// [RequireComponent(typeof(Rigidbody))]

// public class carController : MonoBehaviour
// {
//     [SerializableField]
//     private float maxAcceleration = 20f;
//     [SerializableField]
//     private float turnSensitive = 1.0f,
//     [SerializableField]
//     private float maxAngle = 45.0f;

//     private float inputX, inputY;
    
//     private Rigidbody _rb;

//     public List<AxleInfo> axleInfos = new List<AxleInfo>();



//     // Start is called before the first frame update
//     void Start()
//     {
//         _rb = GetComponent<Rigidbody>();
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }

//     private void FixedUpdate(){
//         Move();
//     }
//     private void Move(){
//         foreach (AxleInfo info in axleInfos)
//         {
//             if(info.isBack)
//             {
//                 info.rightWheel.motortorque = inputY * maxAcceleration * 500 * Time.deltaTime;
//                 info.lefttWheel.motortorque = inputY * maxAcceleration * 500 * Time.deltaTime;
//             }
//             if(info.isFront)
//             {
//                 var _steerAgle = inputX * turnSensitive * maxAngle;
//                 info.rightWheel.steerAgle = Mathf.Lerp(info.rightWheel.steerAgle ,_steerAgle, 0.5f);
//                 info.leftWheel.steerAgle = Mathf.Lerp(info.leftWheel.steerAgle , _steerAgle, 0.5f);
//             }

//             AnimeteWheels(info.rightWheel, info.visualRightWheel);
//             AnimeteWheels(info.leftWheel, info.visualleftWheel);
//         }
//     }

//     private void AnimeteWheels(WheelCollider wheelCollider, Transform wheelTransform)
//     {
//         Quaternion _rot;
//         Vector3 _pos;

//         Vector3 rotate = Vector3.zero;

//         wheelCollider.GetWorldPose(out _pos, out _rot);
//         wheelTransform.transform.rotation = _rot;

//     }
// }

// [System.Serializable]

// public class AxleInfo(){
//     public WheelCollider rightWheel;
//     public WheelCollider leftWheel;

//     public Transform visualRightWheel;
//     public Transform visualLeftWheel;

//     public bool isBack;
//     public bool isFront;
// }