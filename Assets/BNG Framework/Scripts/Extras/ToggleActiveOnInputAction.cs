using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace BNG {

    /// <summary>
    /// This script will toggle a GameObject whenever the provided InputAction is executed
    /// </summary>
    public class ToggleActiveOnInputAction : MonoBehaviour {

        public InputActionReference InputAction = default;
        public GameObject ToggleObject = default;
        [SerializeField] GameObject UITimerGameObject;
        Timer timer;
        private bool ActiveTime = false;
        public GameObject vehicle;
        private void OnEnable() {
            InputAction.action.performed += ToggleActive;
        }

        private void OnDisable() {
            InputAction.action.performed -= ToggleActive;
        }

        public void ToggleActive(InputAction.CallbackContext context) {
            if(ToggleObject) {
                ToggleObject.SetActive(!ToggleObject.activeSelf);
                if (UITimerGameObject.GetComponent<Timer>().TimeActive)
                {
                    UITimerGameObject.GetComponent<Timer>().TimeActive = false ;
                    vehicle.GetComponent<VehicleControl>().activeControl = false;

                }else if(!UITimerGameObject.GetComponent<Timer>().TimeActive)
                {
                    UITimerGameObject.GetComponent<Timer>().TimeActive = true;
                    vehicle.GetComponent<VehicleControl>().activeControl = true;
                }
            }
            
        }
    }
}

