using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{

    public abstract class Unit : MonoBehaviour
    { 
        public Transform transform;
        public Rigidbody rigidbody;

        private float speed = 5f;
        private int health = 100;
        private bool isDead;

        public int Health 
        {
            get
            {
               return health;
            } 
            set
            {
                if (value <= 100 && value >= 0)
                    health = value;
                else
                {
                    health = 100;
                    Debug.Log("Wrong number health");
                }
            }
        }

        public virtual void Awake()
        {
            if (!TryGetComponent<Transform>(out transform))
            {
                Debug.Log("No Transform Component");
            }

            if (!TryGetComponent<Rigidbody>(out rigidbody))
            {
                Debug.Log("No RigidBody Component");
            }

        }

        public abstract void Move(float x, float y, float z);
    }
}
