using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Multiplayer.Samples.BossRoom
{
    public class DoorCreakSFX_snip : MonoBehaviour
    {
        private AudioSource m_AudioSource;

        private void Start()
        {
            m_AudioSource = GetComponent<AudioSource>();
        }

        public void PlayDoorCreak()
        {
            m_AudioSource.Play();
        }
    }
}
