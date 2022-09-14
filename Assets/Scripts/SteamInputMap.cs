using Valve.VR;
using Valve.VR.InteractionSystem;
using Zinnia.Action;
using UnityEngine;

public class SteamInputMap : BooleanAction
{
    public string SteamVRAction;
    public Hand hand;

    private SteamVR_Action_Boolean button;

    private void Start()
    {
        button = SteamVR_Input.GetAction<SteamVR_Action_Boolean>(SteamVRAction);
    }

    protected virtual void Update()
    {
        Receive(button.GetState(hand.handType));
    }
}
