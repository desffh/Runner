using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum EventType
{
    START,
    CONTINUE,
    PAUSE,
    STOP
}


// 정적함수여서 Monobehavior 불필요
public class EventManager
{
    private static readonly IDictionary<EventType, UnityEvent> dictionary =
        new Dictionary<EventType, UnityEvent>();
}
