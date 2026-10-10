using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x682bf997;

public class _0x42b5233b : MonoBehaviour
{
    public static _0x42b5233b Instance;
    public List<_0x706c786a> Panels;
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public void _0x1d2d6c8a(int _0xa4b0c28d)
    {
        if (_0xa4b0c28d == _0x29641b38.SPLASH && _0xcefca5e5.Instance._0x364d82cf != _0x03d597f1.SCENE_0)
            _0x35d08ad8.Instance._0x266075ae();
        if (_0xcefca5e5.Instance._0x364d82cf != _0x03d597f1.SCENE_0)
        {
            if (_0xa4b0c28d == _0x29641b38.SPLASH || _0xa4b0c28d == _0x29641b38.TUTORIAL0)
                _0xcefca5e5.Instance._0x19693c4d(false);
            else if (_0xa4b0c28d == _0x29641b38.DEFAULT)
                _0xcefca5e5.Instance._0x19693c4d(true);
        }
    }

    private void _0xcd3d62d7()
    {
        this._0x80e0823b(_0x29641b38.SPLASH);
        if (_0xcefca5e5.Instance._0x364d82cf == _0x03d597f1.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x35d08ad8.Instance.DefaultAnimationTime);
        }
    }

    private void SwitchSplash()
    {
        if (_0x8f23637c.Instance.IsTutorialEnabled && !_0xcefca5e5._0x49d431b3._0x92e9e7c7)
            this._0x948050d1(_0x29641b38.TUTORIAL0);
        else
            this._0x948050d1(_0x29641b38.DEFAULT);
    }

    private _0x706c786a _0xa717e23a(int _0xf43112b3)
    {
        return this.Panels[_0xf43112b3];
    }

    private void _0x80e0823b(int _0x97e57a23)
    {
        this._0x0834ca45(_0x97e57a23);
        this._0x0b7d6cae(_0x97e57a23);
        this.CurrentPanelIndex = _0x97e57a23;
        this.Panels[_0x97e57a23]._0x8d85d7c5();
    }

    public float ScaleDuration = 0.4f;
    private void Start()
    {
        this._0xcd3d62d7();
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x42b5233b>();
    }

    public bool IsShowSplashOnStart = true;
    public void _0xa352bdac()
    {
        this.LastPanelIndexes.RemoveAll(_0x2451a690 => _0x2451a690 == this.CurrentPanelIndex);
        int _0x6dba32b0 = this.LastPanelIndexes.Last();
        this._0x0b7d6cae(_0x6dba32b0);
        this._0x7b75248e(_0x6dba32b0);
        this.CurrentPanelIndex = _0x6dba32b0;
        this.Panels[_0x6dba32b0].Show();
    }

    public float StaticBlurMaterialInitialValue;
    public void _0x948050d1(int _0xb8d4aeae)
    {
        this._0x0834ca45(_0xb8d4aeae);
        this._0x0b7d6cae(_0xb8d4aeae);
        this.CurrentPanelIndex = _0xb8d4aeae;
        this.Panels[_0xb8d4aeae].Show();
    }

    private void _0x7b75248e(int _0xe3c6ebd8)
    {
        this.LastPanelIndexes.Add(_0xe3c6ebd8);
        this.CurrentPanelIndex = _0xe3c6ebd8;
        for (int _0x00773fa9 = 0; _0x00773fa9 < this.Panels.Count; _0x00773fa9++)
            if (_0x00773fa9 != _0xe3c6ebd8 && this.Panels[_0x00773fa9] != null)
                this.Panels[_0x00773fa9]._0xfed9d7a4();
    }

    private void _0x0b7d6cae(int _0x769391a2)
    {
        if (_0x769391a2 == _0x29641b38.SPLASH)
            _0x35d08ad8.Instance._0x5ca399dd();
        if (_0xcefca5e5.Instance._0x364d82cf == _0x03d597f1.SCENE_0)
        {
        }
    }

    public int CurrentPanelIndex;
    private void _0x0834ca45(int _0x36c6ff0a)
    {
        this.LastPanelIndexes.Add(_0x36c6ff0a);
        this.CurrentPanelIndex = _0x36c6ff0a;
        for (int _0x3719168a = 0; _0x3719168a < this.Panels.Count; _0x3719168a++)
            if (_0x3719168a != _0x36c6ff0a && this.Panels[_0x3719168a] != null)
                this.Panels[_0x3719168a]._0xfed9d7a4();
    }
}