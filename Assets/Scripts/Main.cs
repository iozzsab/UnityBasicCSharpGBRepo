using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class Main : MonoBehaviour
    {
        private InputController inputController;

        private ListExecuteObjectController executeObjectController;

        [SerializeField] private Unit player;
        private void Awake()
        {
            inputController = new InputController(player);

            executeObjectController = new ListExecuteObjectController();

            executeObjectController.AddExecuteObject(inputController);
        }
        
        void Update()
        {
            for (int i = 0; i < executeObjectController.Length; i++)
            {
                if (executeObjectController.InteractiveObject[i] == null)
                {
                    continue;

                }
                executeObjectController.InteractiveObject[i].Update();
            }
        }
    }
}
