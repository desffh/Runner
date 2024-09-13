using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : Singleton<InputManager>
{
    // 함수 주소 저장
    public Action action;
    
    void Update()
    {
        if(Input.anyKey == false) // 입력이 없다면
        {
            return;
        }
        if (action != null) // 이벤트가 있다면 
        {
            action.Invoke();
        }
    }
}
