using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;


public enum RoadLine
{
    LEFT = -1,
    MIDDLE = 0,
    RIGHT = 1
}

public class Runner : MonoBehaviour
{
    [SerializeField] RoadLine roadline;
    [SerializeField] Rigidbody rigidBody;

    [SerializeField] float positionX = 2.5f;
    [SerializeField] float speed = 25.0f;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        InputManager.Instance.action += OnKeyUpdate;
    }
    // Start is called before the first frame update
    void Start()
    {
        roadline = RoadLine.MIDDLE;
    }

    void OnKeyUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (roadline != RoadLine.LEFT)
            {
                roadline--;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (roadline != RoadLine.RIGHT)
            {
                roadline++;
            }
        }
    }

    private void Move()
    {
        rigidBody.position = Vector3.Lerp
            (
            rigidBody.position,
            new Vector3((int)roadline * positionX, 0, 0),
            speed * Time.fixedDeltaTime
            );
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void OnDisable()
    {
        InputManager.Instance.action -= OnKeyUpdate;
    }
}
