using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePositionManager : State
{
    private Coroutine coroutine;

    [SerializeField] float [] randompositionZ = new float[16];

    [SerializeField] int index = -1;
    
    [SerializeField] Transform [ ] parentRoads;

    [SerializeField] Transform [ ] positionRandomX;

    [SerializeField] ObstacleManager obstacleManager; // ��������

    private void Awake()
    {
        for (int i = 0; i < randompositionZ.Length; i++)
        {
            randompositionZ[i] = i * 2.5f + -10.0f;
        }
    }


    public IEnumerator SetPosition()
    {
        while (state)
        {
            yield return CoroutineCache.WaitForSecond(2.5f);

            transform.localPosition = new Vector3
                (0, 0,
                randompositionZ[Random.Range(0, randompositionZ.Length)]);

            obstacleManager.GetObstacle().SetActive(true);

            obstacleManager.GetObstacle().transform.position =
                positionRandomX[Random.Range(0, positionRandomX.Length)].position;

            obstacleManager.GetObstacle().transform.SetParent(transform.root.GetChild(index));
        }
    }

    public void InitializePosition()
    {
        if(coroutine == null)
        {
            coroutine = StartCoroutine(SetPosition());
        }

        index = ( index + 1) % parentRoads.Length;

        transform.SetParent(parentRoads[index]);
        transform.localPosition += new Vector3(0, 0, 40);
    }
}
