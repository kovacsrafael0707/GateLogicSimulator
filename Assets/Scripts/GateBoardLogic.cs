using TMPro;
using UnityEngine;

public class GateBoardLogic : MonoBehaviour
{
    [SerializeField] private GateType[] gates = { GateType.AND, GateType.NAND, GateType.OR, GateType.NOR, GateType.XOR };
    [SerializeField] private SwitchLogic switchA;
    [SerializeField] private SwitchLogic switchB;
    [SerializeField] private Renderer led;
    [SerializeField] private TMP_Text gateLabel;
    [SerializeField] private Color onColor = Color.green;
    [SerializeField] private Color offColor = Color.red;

    private int gateIndex = 0;

    private void OnEnable()
    {
        switchA.StateChanged += OnSwitchChanged;
        switchB.StateChanged += OnSwitchChanged;
        Refresh();
    }

    private void OnDisable()
    {
        switchA.StateChanged -= OnSwitchChanged;
        switchB.StateChanged -= OnSwitchChanged;
    }

    private void OnSwitchChanged(bool state)
    {
        Refresh();
    }

    public void CycleGate()
    {
        gateIndex = (gateIndex + 1) % gates.Length;
        Refresh();
    }

    private void Refresh()
    {
        bool result = LogicGate.Evaluate(gates[gateIndex], switchA.IsOn, switchB.IsOn);

        led.material.color = result ? onColor : offColor;
        gateLabel.text = gates[gateIndex].ToString();
    }
}
