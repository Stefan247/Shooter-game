using Pathfinding;
using UnityEngine;

namespace Enemies
{
    public class EnemyRotationScript : MonoBehaviour
    {
        public AIPath aiPath;

        private const float StartedMoving = 0.01f;
        private const int Scale = 3;
        private const int One = 1;

        private void Update()
        {
            Vector3 localScale;
            localScale = aiPath.desiredVelocity.x >= StartedMoving ? 
                new Vector3((-Scale), Scale, One) : new Vector3(Scale, Scale, One);
            transform.localScale = localScale;
        }
    }
}
