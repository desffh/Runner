using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    [SerializeField] float speed = 20f;

    [SerializeField] float increaseValue = 5f;

    [SerializeField] float maxspeed = 50f;
    public float Speed
    {
        get { return speed; }
    }


    IEnumerator Accelerate()
    {
        while (speed < maxspeed)
        {
            yield return new WaitForSeconds(10);

            speed += increaseValue;
        }
    }

    private void Awake()
    {
        StartCoroutine(Accelerate());
    }

}
