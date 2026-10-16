using UnityEngine;

public abstract class WorldItemBase : MonoBehaviour
{ 
    [SerializeField] protected object _data;
    [SerializeField] protected bool IsInit = false;
    [SerializeField] protected bool IsLocked = false;
    public virtual void OnInit()
    {
        IsLocked = false;
        IsInit = true;
        Debug.Log(IsInit);
    }

    public virtual void TryPickup() { }
    public virtual void TryDrop() { }
}