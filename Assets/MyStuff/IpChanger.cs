using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using extOSC.Core;
using extOSC.Core.Network;

public class IpChanger : MonoBehaviour
{
    public string ip;
    public extOSC.OSCTransmitter oscr;

    public TMP_Text txt;

    public void IPChanger()
    {
        oscr._remoteHost = ip;
        oscr.LocalRefresh();
    }

    public void TextChanger(string s)
    {
        ip = s;
    }
}
