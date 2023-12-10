using System;
using BBUnity.Conditions;
using Pada1.BBCore;
using UnityEngine;

namespace Script.Monster
{
    [Condition("MyConditions/IsTargetNear")]
    [Help("Checks whether it is night. It searches for the first light labeled with " +
          "the 'MainLight' tag, and looks for its DayNightCycle script, returning the" +
          "informed state. If no light is found, false is returned.")]
    public class IsTargetNear : GOCondition
    {
        ///<value>Input maximun distance Parameter to consider that the target is close.</value>
        [InParam("closeDistance")]
        [Help("The maximun distance to consider that the target is close")]
        public float closeDistance;
        
        [InParam("targetName")]
        [Help("The maximun distance to consider that the target is close")]
        public String targetName;
        
        ///<value>Input Target Parameter to to check the distance.</value>
        [OutParam("target")]
        [Help("Target to check the distance")]
        public GameObject target;
        
        public override bool Check()
        {
            foreach (GameObject go in GameObject.FindGameObjectsWithTag(targetName))
             {
                 if ((gameObject.transform.position - go.transform.position).sqrMagnitude <
                     closeDistance * closeDistance)
                 {
                        target = go;
                        return true;
                 }
                
             }
             return false;
        }
    }
}
