using BBUnity.Actions;
using Pada1.BBCore;
using Pada1.BBCore.Tasks;
using UnityEngine;

namespace Script.Citizen.Flee
{
    
    [Action("MyActions/Flee")]
    [Help("Periodically attacks the target. This action never ends.")]
    public class FleeOnce : GOAction {
    
        // Event raised when sun rises or sets.
        public static event System.EventHandler OnFlee;
    
        // Main class method, invoked by the execution engine.
        public override TaskStatus OnUpdate()
        {
            Debug.LogWarning("shoot p");
            // Do the real shoot.
            if (OnFlee != null)
                OnFlee(this, System.EventArgs.Empty);
            return TaskStatus.COMPLETED;
        }
    }
}
