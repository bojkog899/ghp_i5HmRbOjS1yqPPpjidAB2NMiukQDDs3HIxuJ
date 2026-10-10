using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x34457304 : MonoBehaviour
{
    private int _0xc4b2ffcf => this.ScoreCurrent;

    private void _0x04a9aa5e()
    {
        this.IsGameEnd = true;
        _0xcefca5e5.IsAfterLevelComplete = true;
    }

    public int CustomTargetScore = 10;
    [HideInInspector]
    public int TimeLeft;
    private static _0x34457304 _0xb5162775;
    public List<TMP_Text> TimerText = new();
    private int _0xea11a4bd => this.CustomTimeInitial + _0xcefca5e5._0x49d431b3._0x0f7bd499 * 10;

    [HideInInspector]
    public int ScoreCurrent;
    [HideInInspector]
    public bool IsGameEnd;
    [HideInInspector]
    public int CurrentGameIndex;
    public void _0x5b3590e3()
    {
        _0xcefca5e5.Instance._0x19693c4d(true);
        _0xcefca5e5.Instance._0x1484c85c(_0x682bf997._0x03d597f1.SCENE_0);
    }

    public void _0xe629a61d()
    {
        if (_0x8f23637c.Instance.IsOnlyWinGameEndEnabled)
            this._0x519cfbad();
        if (!this.IsGameEnd)
        {
            this._0x04a9aa5e();
            _0xcefca5e5.IsAfterLevelComplete = false;
            _0xcefca5e5.IsAfterLevelFailed = true;
            _0x8e511e3c _0x484aae5a = _0xc1414747.Instance._0x0a70eb9c(_0x682bf997._0x6a7890bf.LOSE).GetComponent<_0x8e511e3c>();
            if (_0x8f23637c.Instance.IsCheckScoreEnabled)
                _0x484aae5a.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x9c860377}";
            else
                _0x484aae5a.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x484aae5a.ContentAdditionalText.text = $"{0}";
            _0x682bf997._0x99de7efd._0xd2149585 += 0;
            _0xc1414747.Instance._0x40f6426c(_0x682bf997._0x6a7890bf.LOSE);
        }
    }

    private void _0x13ae49b9()
    {
        if (this.ScoreCurrent >= this._0x9c860377)
            this._0x519cfbad();
        else
            this._0xe629a61d();
    }

    private IEnumerator _0x07fe3469()
    {
        this._0xc97eb80c();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0xcefca5e5.Instance._0x364d82cf == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0xcefca5e5.Instance._0x67283b03)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0xc97eb80c();
            }
        }

        if (!this.IsGameEnd)
            this._0xe629a61d();
    }

    public List<TMP_Text> LevelNumberText = new();
    public List<TMP_Text> ScoreText = new();
    private int _0x9c860377 => this.CustomTargetScore + _0xcefca5e5._0x49d431b3._0x0f7bd499 * 10;

    public List<TMP_Text> SubtitleText = new();
    private void _0x7c6eac8c()
    {
        if (this.ScoreCurrent > _0xcefca5e5._0x49d431b3._0x6b153811)
            _0xcefca5e5._0x49d431b3._0x6b153811 = this.ScoreCurrent;
        if (_0x8f23637c.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x9c860377)
                this._0x519cfbad();
    }

    public int CustomTimeInitial = 30;
    private void _0x8e01c705()
    {
        if (_0x8f23637c.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0xbcd28080 => _0xbcd28080.text = $"{this.ScoreCurrent}/{this._0x9c860377}");
        else
            this.ScoreText.ForEach(_0xbcd28080 => _0xbcd28080.text = $"{this.ScoreCurrent}");
    }

    public void _0x519cfbad()
    {
        if (!this.IsGameEnd)
        {
            this._0x04a9aa5e();
            _0xcefca5e5.IsAfterLevelComplete = true;
            _0xcefca5e5.IsAfterLevelFailed = false;
            _0x8e511e3c _0x7dea3326 = _0xc1414747.Instance._0x0a70eb9c(_0x682bf997._0x6a7890bf.WIN).GetComponent<_0x8e511e3c>();
            if (_0x8f23637c.Instance.IsCheckScoreEnabled)
                _0x7dea3326.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x9c860377}";
            else
                _0x7dea3326.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x8f23637c.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x682bf997._0x99de7efd._0xd2149585)
                    _0x682bf997._0x99de7efd._0xd2149585 = this.ScoreCurrent;
                _0x7dea3326.ContentAdditionalText.text = $"{_0x682bf997._0x99de7efd._0xd2149585}";
            }
            else
            {
                _0x7dea3326.ContentAdditionalText.text = $"{this._0xc4b2ffcf}";
                _0x682bf997._0x99de7efd._0xd2149585 += this._0xc4b2ffcf;
            }

            if (_0x8f23637c.Instance.IsLevelIncrementOnWin)
                ++_0xcefca5e5._0x49d431b3._0x0f7bd499;
            _0xc1414747.Instance._0x40f6426c(_0x682bf997._0x6a7890bf.WIN);
        }
    }

    public List<Button> PauseButtons = new();
    private void _0xc97eb80c()
    {
        this.TimerText.ForEach(_0xbcd28080 => _0xbcd28080.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x4ca0fff4._0xd893343e(new byte[6] { 13, 13, 60, 90, 19, 19 }, 96)));
    }

    private void Awake()
    {
        _0xb5162775 = this.gameObject.GetComponent<_0x34457304>();
    }

    public List<Button> HomeButtons = new();
    public void _0xe445d86a(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x8e01c705();
            this._0x7c6eac8c();
        }
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0xea11a4bd;
        this.CurrentGameIndex = _0xcefca5e5.Instance._0x364d82cf;
        foreach (Button _0x031e2b7c in this.HomeButtons)
            _0x031e2b7c.onClick.AddListener(() =>
            {
                this._0x5b3590e3();
            });
        foreach (Button _0xc3c8e70a in this.PauseButtons)
            _0xc3c8e70a.onClick.AddListener(() =>
            {
                _0xcefca5e5.Instance._0x19693c4d(false);
                _0xc1414747.Instance._0x40f6426c(_0x682bf997._0x6a7890bf.PAUSE);
            });
        this._0x8e01c705();
        this.LevelNumberText.ForEach(_0xbcd28080 => _0xbcd28080.text = $"LVL {_0xcefca5e5._0x49d431b3._0x0f7bd499 + 1}");
        if (_0x8f23637c.Instance.IsTimerEnabled)
        {
            this._0xc97eb80c();
            this.StartCoroutine(this._0x07fe3469());
        }
    }
}

internal static class _0x4ca0fff4
{
    internal static string _0xd893343e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}