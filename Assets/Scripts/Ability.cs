using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CreatingCharacters.Abilities
{
    public abstract class Ability : MonoBehaviour
    {
        //Add functionalities for all abilities
        public abstract IEnumerator Cast();
    }
}