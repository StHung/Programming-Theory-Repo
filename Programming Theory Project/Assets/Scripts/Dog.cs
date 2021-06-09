using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class Dog : Animals
{
    public override string Walk()
    {
        return "Dog walks on 4 legs";
    }

    public override string Talk()
    {
        return "Woof Woof ...";
    }

    public override string DisplayInfo()
    {
        return "Nickname: " + this.nickName +
               "\nWeight: " + this.weigth +
               "\nAge: " + this.age +
               "\nMove: " + this.Walk() +
               "\nTalk : " + this.Talk();
    }
    private void OnMouseEnter()
    {
        GUIManager.Instance.SetText(DisplayInfo());
    }
    private void OnMouseExit()
    {
        GUIManager.Instance.SetText("");
    }
}
