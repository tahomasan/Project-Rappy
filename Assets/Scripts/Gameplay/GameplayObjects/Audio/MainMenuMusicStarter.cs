using System;
using Unity.BossRoom.Audio;
using UnityEngine;

namespace Unity.BossRoom.Gameplay.GameplayObjects.Audio
{
    /// <summary>
    /// Simple class to play game theme on scene load
    /// </summary>
    public class MainMenuMusicStarter : MonoBehaviour
    {
        // set whether theme should restart if already playing
        [SerializeField]
        bool m_Restart;
        [SerializeField]
        bool m_PlayOnLaunch;

        void Start()
        {
            if (m_PlayOnLaunch)
            {
                ClientMusicPlayer.Instance.PlayThemeMusic(m_Restart);
            }
        }
    }
}
