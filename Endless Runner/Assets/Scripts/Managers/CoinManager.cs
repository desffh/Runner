
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] List <GameObject> coins;

    [SerializeField] GameObject prefab;

    [SerializeField] int createCount = 16;

    [SerializeField] float offset = 2.5f;

    [SerializeField] int positionX = 4;
    private void Awake()
    {
        coins.Capacity = 20;
        Create();
    }

    public void Create()
    {
        for (int i = 0; i < createCount; i++)
        {
            GameObject instance = Instantiate(prefab);
            instance.transform.SetParent(gameObject.transform); // 자식오브젝트로 생성
            instance.transform.localPosition = 
                new Vector3(0f, prefab.transform.position.y, offset * i);

            instance.SetActive(false);

            coins.Add(instance);
        }
    }
    public void InitializePosition()
    {
        transform.localPosition = new Vector3(positionX * Random.Range(-1, 2), 0, 0);
    }
}
