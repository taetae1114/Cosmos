using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zizhuan2 : MonoBehaviour {

    public float RotateSpeed;//旋转速度
                             // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.left * RotateSpeed, Space.World);
    }
}
