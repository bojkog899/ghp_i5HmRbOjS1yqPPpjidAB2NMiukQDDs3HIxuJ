using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x7cb8d886 : MonoBehaviour
{
    private float _0x8f5e42f5 = 4;
    private AspectRatioFitter _0xe8358c4b;
    private float _0x6ffc7308 = 0.6f;
    private List<string> _0x00073049 = new();
    private float _0x15b8a4c5 = 1.5f;
    private TMP_Text _0xf7b9093b;
    private float _0xbdfe2304;
    private void Update()
    {
        int _0x5cb32ac8 = 1;
        if (this._0x00073049.Count > 0)
        {
            string _0x3e9ead1f = this._0xf7b9093b.text;
            foreach (string _0x5b6fb8f6 in this._0x00073049)
                while (_0x3e9ead1f.Contains(_0x5b6fb8f6))
                    _0x3e9ead1f = _0x3e9ead1f.Replace(_0x5b6fb8f6, "");
            _0x5cb32ac8 = _0x3e9ead1f.Length;
        }
        else
        {
            _0x5cb32ac8 = this._0xf7b9093b.text.Length;
        }

        float _0x23c73a63 = Mathf.Clamp(this._0xbdfe2304 + this._0x6ffc7308 * _0x5cb32ac8, this._0x15b8a4c5, this._0x8f5e42f5);
        if (!Mathf.Approximately(this._0xe8358c4b.aspectRatio, _0x23c73a63))
            this._0xe8358c4b.aspectRatio = _0x23c73a63;
    }
}