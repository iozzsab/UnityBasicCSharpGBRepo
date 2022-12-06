using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{

    public abstract class Bonus : MonoBehaviour, IExecute
    {
        private bool isInteractable;
        protected Color color;
        private Renderer renderer;
        private Collider collider;

        public float heightFly;

        public bool IsInteractable
        {
            get => isInteractable;
            set
            {
                isInteractable = value;
                renderer.enabled = value;
                collider.enabled = value;
            }
        }

        public virtual void Awake()
        {
            if (!TryGetComponent<Renderer>(out renderer))
                Debug.Log("No Renderer Component");
            if (!TryGetComponent<Collider>(out collider))
                Debug.Log("No Collider Component");

            isInteractable = true;
            color = Random.ColorHSV();
            renderer.sharedMaterial.color = color;


        
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Interaction();
            
            }
        }
        protected abstract void Interaction();

        public abstract void Update();
    }
}