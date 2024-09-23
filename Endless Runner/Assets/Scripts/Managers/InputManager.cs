using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : Singleton<InputManager>
{
    // �Լ� �ּ� ����
    public Action action;
    
    void Update()
    {
        if(Input.anyKey == false) // �Է��� ���ٸ�
        {
            return;
        }
        if (action != null) // �̺�Ʈ�� �ִٸ� 
        {
            action.Invoke();
        }
    }
}
