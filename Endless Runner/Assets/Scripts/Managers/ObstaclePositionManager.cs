using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePositionManager : MonoBehaviour
{
    [SerializeField] float [] randompositionZ = new float[16];

    [SerializeField] int index = -1;
    [SerializeField] Transform [ ] parentRoads;

    private void Awake()
    {
        for (int i = 0; i < randompositionZ.Length; i++)
        {
            randompositionZ[i] = i * 2.5f + -10.0f;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    public void InitializePosition()
    {
        index = ( index + 1) % parentRoads.Length;

        transform.SetParent(parentRoads[index]);
        transform.localPosition += new Vector3(0, 0, 40);
    }
}
