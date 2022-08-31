
using System;
using UnityEngine;

[CreateAssetMenu]
public class FloatVariable : ScriptableObject, ISerializationCallbackReceiver
{
    public float InitalValue;
    [NonSerialized] 
    public float RuntimeValue;

    public void OnAfterDeserialize()
    {
        RuntimeValue = InitalValue;
    }
    
    public void OnBeforeSerialize() {}
}
