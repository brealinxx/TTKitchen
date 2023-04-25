using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCounter : MonoBehaviour,IKitchenObjectParent
{
    [SerializeField] private Transform counterTopPoint;

    public KitchenObject kitchenObject;

    public virtual void InteractPlayer(PlayerController playerController)
    {
        
    }

    public virtual void InteractAlternatePlayer(PlayerController playerController)
    {
        
    }

    public Transform GetKitchenObjectFollowTransform()
    {
        return counterTopPoint;
    }

    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;
    }

    public KitchenObject GetKitchenObject()
    {
        return kitchenObject;
    }

    public void ClearKitchenObject()
    {
        kitchenObject = null;
    }

    public bool HasKitchenObject()
    {
        return kitchenObject != null;
    }

    protected void DestroyKitchenObject(KitchenObject kitchenObject)
    {
        Destroy(kitchenObject.gameObject);
    }
}
