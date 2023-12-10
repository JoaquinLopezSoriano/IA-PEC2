using System.Collections.Generic;
using System.Linq;
using Script.Citizen;
using Script.Citizen.State.Destination;
using Script.Game;
using UnityEngine;
using Random = System.Random;

namespace Script.Formation
{
    /*
     * Handles the destination behavior of the taichi leader
     * When they reach the destination point they do a taichi movement
     */
    public class TaichiDestinationState : TargetDestinationState
    {
        // taichi id movement list
        private int[] _taichiList = new int[Constant.Animation.MAX_TAICHI];
        private readonly FormationManager _formationManager;
        public TaichiDestinationState(FsmCitizen fsmCitizen, FormationManager formationManager) : base(fsmCitizen)
        {
            _formationManager = formationManager;
            for (int i = 0; i < _taichiList.Length; i++)
            {
                _taichiList[i] = i;
            }
        }
        
        public override void ToFindDestinationState()
        {
            // get a random taichi movement
            var rnd = new Random();
            var randomized = _taichiList.OrderBy(item => rnd.Next());
            _fsm.Animator.SetFloat(Constant.Animation.TAICHI, _taichiList[0]+1);    // do the leader the taichi movement
            foreach (GameObject go in _formationManager.FormationList)                        // do every follower the taichi movement as well
            {
                go.GetComponent<Slot>().Anime(_taichiList[0]+1);
                
            }
            // sleep until the animation is over
            _fsm.Animator.SetFloat(Constant.Animation.TAICHI, 0);                   // return moving     
            foreach (GameObject go in _formationManager.FormationList)
            {
                go.GetComponent<Slot>().Anime(0);
            }
            
        }
    }
}
