using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class InteractiveActorBase : MonoBehaviour,IInteractInterface
{
    // Start is called before the first frame update

    public string ActorName;
    public int ActorQuantity;
    public bool bCanCatch;
    public bool bInteractable;
    public bool bGetFromInventory;
    public string ItemContext;

    public void Interact()
    {
        //TODO: Interact Behaviour
    }

    public string GetContextInfo()
    {
        return ItemContext;
    }


    public virtual void SetActorName(string InactorName)
    {
        ActorName = InactorName;
    }

    public virtual void SetActorQuantity(int InactorQuantity)
    {
        ActorQuantity = InactorQuantity;
    }

    public virtual void SetCanCatch(bool InbcanCatch)
    {
        bCanCatch = InbcanCatch;
    }

    public virtual void SetInteractable(bool Inbinteractable)
    {
        bInteractable = Inbinteractable;
    }

    public virtual void SetGetFromInventory(bool InbGetFromInventory)
    {
        bGetFromInventory = InbGetFromInventory;
    }


    public virtual string GetActorName()
    {
       return ActorName;
    }

    public virtual int GetActorQuantity()
    {
        return ActorQuantity;
    }

    public virtual bool GetbCanCatch()
    {
        return bCanCatch;
    }

    public virtual bool GetbInteractable()
    {
        return bInteractable;
    }

    public virtual bool GetbGetFromInventory()
    {
        return bGetFromInventory;
    }

    public virtual string GetItemContext()
    {
        return ItemContext;
    }

    public virtual void DebugActor()
    {
        Debug.Log(GetActorName());
        Debug.Log(GetActorQuantity());
        Debug.Log(GetbCanCatch());
        Debug.Log(GetbInteractable());
        Debug.Log(GetbGetFromInventory());
        Debug.Log(GetItemContext());
        
    }

    public virtual string ActivateDialogue(string InContext)
    {
        //TODO : Interface to UI Manager, delegate the context
        if (bInteractable)
        {
            ItemContext = InContext;
        }
        else
        {
            ItemContext = null;
        }
        return ItemContext;
        
    }

    public virtual void CatchItem()
    {
        if (bCanCatch)
        {
            //TODO: Using bool and if condition to call the function of Catching
        }
    }

    public virtual void AddItem()
    {
        if (bInteractable)
        {
            //TODO: Using bool and if condition to call the AddItem function in the Inventory System
        }
    }

    public virtual void GetItemFromInventory()
    {
        if (bGetFromInventory)
        {
            //TODO:Using bool and if condition to call the SpawnItem function from the Inventory System
        }
    }

    public virtual void PlayAudio()
    {
        //TODO: Play the Audio sound 
    }

    public virtual void StopAudio()
    {
        //TODO: Stop playing Audio sound
    }
    
    void Start()
    {
        DebugActor();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
