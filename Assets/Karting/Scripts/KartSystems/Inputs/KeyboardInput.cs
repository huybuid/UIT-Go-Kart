using UnityEngine;

namespace KartGame.KartSystems {

    public class KeyboardInput : BaseInput
    {
        public string TurnInputName = "Horizontal";
        public string AccelerateButtonName = "Accelerate";
        public string ReverseButtonName = "Reverse";
        public string BrakeButtonName = "Brake";

        public override InputData GenerateInput() {
            return new InputData
            {
                Accelerate = Input.GetAxisRaw(AccelerateButtonName) > 0,
                Brake = Input.GetButton(BrakeButtonName),
                Reverse = Input.GetButton(ReverseButtonName),
                TurnInput = Input.GetAxis(TurnInputName)
            };
        }
    }
}
