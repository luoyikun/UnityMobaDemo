﻿/****************************************************
    文件：LobbySys.cs
    作者：CodingCodingK
    博客：CodingCodingK.github.io
    邮箱：2470939431@qq.com
    日期：#DATE#
    功能：Unknown
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using HOKProtocol;
using UnityEngine;

public class LobbySys : SystemBase
{
    public static LobbySys Instance;

    public override void InitSys()
    {
        base.InitSys();
        
        Instance = this;
        this.Log("LobbySys Init Completed.");
    }

    public void EnterLobby()
    {
        gameRootResources.lobbyWindow.SetWindowState();
    }

    public void RspMatch(GameMsg msg)
    {
        int preTime = msg.rspMatch.preTime;
        gameRootResources.lobbyWindow.ShowMatchInfo(true,preTime);
    }
}
