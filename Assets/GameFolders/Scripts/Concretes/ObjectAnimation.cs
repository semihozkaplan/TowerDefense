using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAnimation : IObjectAnimation
{

    Animator _animatorDoor;

    public ObjectAnimation(Animator animatorDoor)
    {
        _animatorDoor = animatorDoor;
    }

    public void DoorOpenAnim()
    {

        _animatorDoor.SetTrigger("isOpen");

    }

    public void DoorCloseAnim()
    {

      _animatorDoor.SetTrigger("isClose");

    }

}
