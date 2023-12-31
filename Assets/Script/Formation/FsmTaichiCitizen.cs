using Script.Citizen;

namespace Script.Formation
{
    /*
    * Handle the behavior of the taichi leader citizen
    * It inherit from FsmCitizen
    * Has the same behavior but a new _targetDestinationState
    */
    public class FsmTaichiCitizen : FsmCitizen
    {
        private FormationManager _formation;        // the formation script to get the followers list
        private new void Start()
        {
            base.Start();
            _formation = GetComponentInParent<FormationManager>();
            _targetDestinationState = new TaichiDestinationState(this, _formation);
        }

        // Update is called once per frame
        private new void Update()
        {
            base.Update();
        }
    }
}
