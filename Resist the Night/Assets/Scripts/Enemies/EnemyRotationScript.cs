using Pathfinding;
using UnityEngine;

namespace Enemies
{
    public class EnemyRotationScript : MonoBehaviour
    {
    
        public AIPath aiPath;
        private float startedMoving = 0.01f;
        private int scale = 3;
        private readonly int ONE = 1;

        void Update()
        {
            if (aiPath.desiredVelocity.x >= startedMoving)
            {
                transform.localScale = new Vector3((-scale), scale, ONE);
            } 
            else if (aiPath.desiredVelocity.x <= (-startedMoving))
            {
                transform.localScale = new Vector3(scale, scale, ONE);
            }
        }
    }
}
