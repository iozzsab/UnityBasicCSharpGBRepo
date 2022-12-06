using UnityEngine;

namespace Maze
{
    public class InputController : IExecute
    {
        private readonly Unit player;
        
        private float horizontal;
        private float vertical;

        public InputController (Unit _player)
        {
            player = _player;

        }
        public void Update()
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");

            player.Move(horizontal, 0, vertical);

        }
    }
}
