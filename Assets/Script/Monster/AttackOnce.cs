using BBUnity.Actions;
using Pada1.BBCore;
using Pada1.BBCore.Tasks;
using UnityEngine;

namespace Script.Monster
{
    [Action("MyActions/Attack")]
    [Help("Periodically attacks the target. This action never ends.")]
    public class AttackOnce : GOAction
    {
        // Event raised when sun rises or sets.
        public static event System.EventHandler OnAttack;
        // Define the input parameter delay, with the waited game loops between shoots.
        [InParam("delay", DefaultValue=30)]
        public int delay;
 
        // Game loops since the last shoot.
        private int elapsed = 0;
        
        ///<value>Input Target Parameter to to check the distance.</value>
        [InParam("target")]
        [Help("Target to check the distance")]
        public GameObject target;
        
        // Initialization method. If not established, we look for the shooting point.
        public override void OnStart()
        {
                delay = 10;
        }

        // Main class method, invoked by the execution engine.
        public override TaskStatus OnUpdate()
        {
            if (delay > 0)
            {
                ++elapsed;
                elapsed %= delay;
                if (elapsed != 0)
                    return TaskStatus.RUNNING;
            }
            
            // Do the real shoot.
            if (OnAttack != null)
                OnAttack(this, System.EventArgs.Empty);
            return TaskStatus.RUNNING;

        } // OnUpdate
    }
}
