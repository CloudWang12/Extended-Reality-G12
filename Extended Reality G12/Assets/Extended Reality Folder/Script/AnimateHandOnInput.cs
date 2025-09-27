using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{

    public InputActionProperty TriggerValue;
    public InputActionProperty GripValue;

    public Animator HandAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Trigger = TriggerValue.action.ReadValue<float>();
        float Grip = GripValue.action.ReadValue<float>();
        
        HandAnimator.SetFloat("Trigger", Trigger);
        HandAnimator.SetFloat("Grip", Grip);
    }
}
