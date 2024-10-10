using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : State, IHitable
{
    [SerializeField] float speed;

    [SerializeField] GameObject rotationGameObject;

    // interface IHitable
    public void Activate()
    {
        gameObject.SetActive(false);
    }

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
