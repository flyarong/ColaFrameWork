﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 角色的动画播放控制器
/// </summary>
public class CharAnimCtrl : IAnimCtrl
{
    private Animation animation;

    public CharAnimCtrl(GameObject entity)
    {
        if(null != entity)
        {
            animation = entity.GetComponent<Animation>();
        }
    }

    public void PlayAnimation(string animName)
    {
        animation.Play(animName);
    }

    public void PlayAnimation(string animName, Action<bool> callback)
    {
        //TODO：用一种比较合适的方式处理回调事件
        animation.Play(animName);
    }

    public void StopPlay(string animName)
    {
        animation.Stop();
    }

    public void Release()
    {
        if (animation.isPlaying)
        {
            animation.Stop();
        }
        animation = null;
    }
}
