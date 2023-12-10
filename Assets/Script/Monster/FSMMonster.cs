using Script.Citizen;
using Script.Game;
using UnityEngine;

namespace Script.Monster
{
    public class FsmMonster : FsmCitizen
    {

        // Start is called before the first frame update
        private new void Start()
        {
            base.Start();
            CurrentDestinationState = null;
            AttackOnce.OnAttack += Attack;
        }

        // Update is called once per frame
        private new void Update()
        {
            Animator.SetFloat(Constant.Animation.SPEED, NavMeshAgent.speed);
            CurrentMovementState.UpdateMovementState();
        }

        private void Attack(object sender, System.EventArgs e)
        {
            Animator.SetTrigger(Constant.Animation.ATTACK);
        }

    }
}
