using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewUser
{
    private string _name;
    private int _health;
    private int _id;

    public NewUser (string name, int health, int id) 
        {
        _name = name;
        _health = health;
        _id = id;

        Debug.Log(_name);
        }


    public void Move()
    {

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

        myClass = new NewUser("myClass Temp100", 100, 5);
        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
