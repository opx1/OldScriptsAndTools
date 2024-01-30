using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction2022 : ScriptableObject
{
    public UnityAction raise;

    public void RaiseAction()
    {
        raise?.Invoke();
    }
}