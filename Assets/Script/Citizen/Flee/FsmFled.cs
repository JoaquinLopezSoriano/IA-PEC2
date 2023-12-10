using Script.Game;

namespace Script.Citizen.Flee
{
    public class FsmFled: FsmCitizen
    {

        // Start is called before the first frame update
        private new void Start()
        {
            base.Start();
            CurrentDestinationState = null;
            FleeOnce.OnFlee += Flee;
        }

        // Update is called once per frame
        private new void Update()
        {
            Animator.SetFloat(Constant.Animation.SPEED, NavMeshAgent.speed);
            CurrentMovementState.UpdateMovementState();
        }

        private void Flee(object sender, System.EventArgs e)
        {
            Animator.SetTrigger(Constant.Animation.FLEE);
            NavMeshAgent.speed *= 2;
        }
    }
}