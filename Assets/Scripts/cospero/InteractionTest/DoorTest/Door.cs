using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Door : MonoBehaviour
{
    public Animator DoorAnimator;
    public bool isOpen;
    public Activator activator;

    

    void Start()
    {
        activator = GetComponent<Activator>();
       if (isOpen)
        {
            DoorAnimator.SetBool("IsOpen", true);
        } 
    }

    public void Interact()
    {
        isOpen = !isOpen;
        if (isOpen)
        {
            activator.activationLine = "�������";
            DoorAnimator.SetBool("IsOpen", true);
        }
        else
        {
            activator.activationLine = "�������";
            DoorAnimator.SetBool("IsOpen", false);
        }
    }
    
}