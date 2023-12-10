namespace Script.Game
{
    /*
     * Constant parameters
     */
    public static class Constant
    {
        // NavMesh name layers
        public struct NavMesh
        {
            // Walkable name navMesh layer
            public const string CITIZEN_WALK = "Walkable";
            public const string TAICHI_WALK = "Taichi";
            public enum AreaMask
            {
                Walkable,
                Taichi
            }

        }

        // Animation parameters
        public struct Animation
        {
            public static string ATTACK = "Attack";
            public static string FLEE = "Flee";
            public const string SPEED = "Speed";
            public const string WAIT = "Wait";
            public const string LEAVE = "Leave";
        }
        
        // Collider Tags
        public struct Collider
        {
            public const string BENCH = "Bench";
        }
   

    }
}
