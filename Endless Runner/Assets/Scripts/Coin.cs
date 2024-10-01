using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : State
{
    [SerializeField] float speed;

    [SerializeField] GameObject rotationGameObject;

    private new void OnEnable()
    {
        base.OnEnable();

        rotationGameObject = GameObject.Find("RotationGameobject");

        speed = rotationGameObject.GetComponent<RotationGameObject>().Speed;

        transform.localRotation = rotationGameObject.transform.rotation;

    }

    private void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
