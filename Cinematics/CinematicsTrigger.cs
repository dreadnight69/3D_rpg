﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace RPG.Cinematics
{
    public class CinematicsTrigger : MonoBehaviour
    {
        bool alreadyTriggered = false;

        private void OnTriggerEnter(Collider other) {
            if (other.gameObject.tag ==  "Player" && !alreadyTriggered)
            {
                GetComponent<PlayableDirector>().Play();
                alreadyTriggered = true;
            }
            
        }
    }
}
