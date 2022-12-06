using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{

    public class ListExecuteObjectController : MonoBehaviour
    {
        private IExecute[] interactiveObject;
        public int Length => interactiveObject.Length; 
            
        

        public IExecute[] InteractiveObject
        {
            get => interactiveObject;
            set => interactiveObject = value;
        }

        public ListExecuteObjectController()
        {
        
        }
        public void AddExecuteObject(IExecute execute)
        {
            if (InteractiveObject == null)
            {
                InteractiveObject = new[] {execute};
                return;

            }
            Array.Resize(ref interactiveObject, Length +1);
            InteractiveObject[Length - 1] = execute;
        }

    }
}