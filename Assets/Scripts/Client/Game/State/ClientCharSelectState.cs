using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BossRoom;

namespace BossRoom.Client
{
    /// <summary>
    /// Client specialization of the Character Select game state. 
    /// </summary>
    [RequireComponent(typeof(CharSelectData))]
    public class ClientCharSelectState : GameStateBehaviour
    {
        public override GameState ActiveState { get { return GameState.CHARSELECT; } }


        public override void NetworkStart()
        {
            base.NetworkStart();
            if (!IsClient) { this.enabled = false; }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
