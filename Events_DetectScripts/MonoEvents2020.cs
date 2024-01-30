using System;
using System.Collections;
using UnityEngine;
using  UnityEngine.Events;
public class MonoEvents2020 : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, onEnableEvent;
    public float holdTime;

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(holdTime);
        startEvent.Invoke();
    }

    private void OnEnable()
    {
        onEnableEvent.Invoke();
    }
}
