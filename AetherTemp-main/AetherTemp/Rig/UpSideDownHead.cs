using System;
using System.Collections.Generic;
using System.Text;

namespace AetherTemp.Rig
{
    class UpSideDownHead
    {
        public static void UpsideDownHeadG()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z = 180f;
            }
            if (ControllerInputPoller.instance.leftGrab)
            {
                GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z = 180f;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z = 0f;
            }
        }
    }
}
