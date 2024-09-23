
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;

    [SerializeField] int createCount = 16;

    [SerializeField] float offset = 2.5f;
    private void Awake()
    {
        Create();
    }
    public void Create()
    {
        for (int i = 0; i < createCount; i++)
        {
            GameObject instance = Instantiate(prefab);
            instance.transform.SetParent(gameObject.transform); // �ڽĿ�����Ʈ�� ����
            instance.transform.localPosition = 
                new Vector3(0f, prefab.transform.position.y, offset * i);
        }
    }
    public void InitializePosition()
    {

    }
}
