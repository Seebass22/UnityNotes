﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FrameRateCounter : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI display = default;

    public enum DisplayMode { FPS, MS}

    [SerializeField]
    DisplayMode displayMode = DisplayMode.FPS;

    int frames;
    float duration, bestDuration = float.MaxValue, worstDuration;

    [SerializeField, Range(0.1f, 2f)]
    float sampleDuration = 1f;

    private void Update()
    {
        float frameDuration = Time.unscaledDeltaTime;
        frames += 1;
        duration += frameDuration;

        if (frameDuration < bestDuration)
            bestDuration = frameDuration;
        if (frameDuration > worstDuration)
            worstDuration = frameDuration;

        if (duration >= sampleDuration)
        {
            if (displayMode == DisplayMode.FPS)
            {
                display.SetText("FPS\n{0:0}\n{1:0}\n{2:0}", 1f / bestDuration, frames / duration, 1f / worstDuration);
            }
            else
            {
                display.SetText("MS\n{0:1}\n{1:1}\n{2:1}", 1000 * bestDuration, 1000 * duration / frames, 1000 * worstDuration);
            }
            frames = 0;
            duration = 0f;
            bestDuration = float.MaxValue;
            worstDuration = 0f;
        }
    }
}
