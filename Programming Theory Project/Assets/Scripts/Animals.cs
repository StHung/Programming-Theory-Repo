using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    [SerializeField] protected string nickName;
    [SerializeField] protected float weigth;
    [SerializeField] protected int age;

    public string NickName { get => nickName; set => nickName = value; }
    public float Weigth { get => weigth; set => weigth = value; }
    public int Age { get => age; set => age = value; }

    public virtual string Walk()
    {
        return "Animals walk...";
    }

    public virtual string Talk()
    {
        return "Animals walk...";
    }

    public virtual string DisplayInfo()
    {
        return "Animals Info: .....";
    }


}
