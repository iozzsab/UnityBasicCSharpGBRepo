using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public abstract class Unit
{

    int health;
    int damage;

    abstract public void Move(int x, int y);
    
}


public class NewUser : Unit
{
    private string _name;
    private int _health;
    private int _id;

    public override void Move(int x, int y)
    {
        Debug.Log("NewMove");
    }
}


public class Temp : MonoBehaviour
{

    struct User
    {
        public string name;
        public int health;
        public int id;
    }
    NewUser myClass;
    void Start()
    {
        User user = new User();
        user.name = "Test";
        user.health = 100;
        Debug.Log(user.name);


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
