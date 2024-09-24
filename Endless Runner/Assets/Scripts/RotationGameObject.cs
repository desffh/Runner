using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RotationGameObject : MonoBehaviour
{
    [SerializeField] float speed = 50f;

    // 프로퍼티
    public float Speed
    {
        get { return speed; }
        //set { speed = value; }
    }


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);       
    }
}
