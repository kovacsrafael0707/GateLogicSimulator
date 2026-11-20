using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

[RequireComponent(typeof(XRSimpleInteractable))]
public class SwitchLogic : MonoBehaviour
{
    [SerializeField] private Renderer Renderer;
    [SerializeField] private Color onColor = Color.green;
    [SerializeField] private Color offColor = Color.red;

    private XRSimpleInteractable interactable;

    public bool IsOn { get; private set; }
    public event Action<bool> StateChanged;

    private void Awake()
    {
        interactable = GetComponent<XRSimpleInteractable>();
        UpdateVisual();
    }
    private void OnEnable()
    {
        interactable.selectEntered.AddListener(OnSelected);
    }

    private void OnDisable()
    {
        interactable.selectEntered.RemoveListener(OnSelected);
    }

    private void OnSelected(SelectEnterEventArgs args)
    {
        IsOn = !IsOn;
        UpdateVisual();
        StateChanged?.Invoke(IsOn);
    }

    private void UpdateVisual()
    {
        Renderer.material.color = IsOn ? onColor : offColor;
    }
}