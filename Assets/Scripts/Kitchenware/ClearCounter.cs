using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO initPrefab;

    public override void InteractPlayer(PlayerController playerController)
    {
        if (!HasKitchenObject())
        {
            Transform prefab = Instantiate(initPrefab.prefabTransform);
            prefab.GetComponent<KitchenObject>().SetKitchenObjectParent(this);
        }
        else
        {
            kitchenObject.SetKitchenObjectParent(playerController);
        }
    }
    
}