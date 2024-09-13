using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    // T타입으로 들어옴
    private static T instance;

    public static T Instance
    {
        get { return instance; }
        set { }
    }

    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = (T)FindObjectOfType(typeof(T));
        }
        else // 중복이 되지않게 파괴
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

}
