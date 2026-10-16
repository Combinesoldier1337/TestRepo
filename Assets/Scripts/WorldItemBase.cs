using UnityEngine;

public abstract class WorldItemBase : MonoBehaviour
{ 
    [SerializeField] protected object _data;
    [SerializeField] protected bool IsInit = false;
    public virtual void OnInit()
    {
        IsInit = true;
        Debug.Log(IsInit);
    }

    public virtual void TryPickup() { }
}