using UnityEngine;
using EmeraldAI;
using HFPS.Player;

namespace ThunderWire.EmeraldAI
{
    public class EmeraldAISendDamage : MonoBehaviour
    {
        /// <summary>
        /// Send Damage to Emerald AI System
        /// </summary>
        public void ApplyDamage(int DamageAmount)
        {
            EmeraldAISystem EmeraldComponent = GetComponent<EmeraldAISystem>();
            PlayerController player = PlayerController.Instance;

            //Cause damage to the AI that is hit using the HFPS damage function.
            EmeraldComponent.Damage(DamageAmount, EmeraldAISystem.TargetType.Player, player.transform, 400);
        }
    }
}