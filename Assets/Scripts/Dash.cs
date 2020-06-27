using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CreatingCharacters.Abilities
{
    public class Dash : Ability
    {
        [SerializeField] private float dashForce;
        [SerializeField] private float dashDuration = 3;
/*
        public CharacterController cc;

        public void Awake()
        {
            cc = GetComponent<CharacterController>();
        }
*/
        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
                StartCoroutine(Cast());
        }

        public override IEnumerator Cast()
        {
        //    GetComponent<CharacterController>().AddForce(Camera.main.transform.forward * dashForce, ForceMode.VelocityChange); //No existe en CharacterController

            yield return new WaitForSeconds(dashDuration);

        //    GetComponent<CharacterController>().velocity = Vector3.zero; //No existe en CharacterController
        }
    }
}
