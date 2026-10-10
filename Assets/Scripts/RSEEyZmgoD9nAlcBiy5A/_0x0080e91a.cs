using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The sector list. Built once into the menu body and shown through its own gate,
// so nothing of the template is reused or hidden behind it.
public sealed class _0x0080e91a : MonoBehaviour
{
    [SerializeField]
    private _0x875ac168 _gate;
    private const float FirstCardY = 0.735f;
    private int _0x3b294b08;
    private void _0xaf8a3209()
    {
        _0x69baa7e4._0x107c22cb = this._0x3b294b08;
        _0xcefca5e5.Instance._0x1484c85c(_0x682bf997._0x03d597f1.SCENE_1);
    }

    [SerializeField]
    private TextMeshProUGUI _launchLabel;
    public bool _0xfeb44c69
    {
        get
        {
            return this._gate != null && this._gate._0xc2f75570;
        }
    }

    private void _0x6d485603(int _0x2016e06d)
    {
        if (_0x2016e06d < 0 || _0x2016e06d >= this._cards.Length)
        {
            return;
        }

        if (_0x2016e06d >= _0x69baa7e4._0xd9497139)
        {
            this._cards[_0x2016e06d]._0xf384ccff();
            return;
        }

        this._0x3b294b08 = _0x2016e06d;
        _0x69baa7e4._0x107c22cb = _0x2016e06d;
        this._0xb409785a();
        this._cards[_0x2016e06d]._0x3f3b9156();
    }

    private void _0xb409785a()
    {
        int _0xf0775382 = _0x69baa7e4._0xd9497139;
        if (this._emptyNote != null)
        {
            this._emptyNote.gameObject.SetActive(_0xf0775382 <= 0);
        }

        if (this._0x3b294b08 >= _0xf0775382)
        {
            this._0x3b294b08 = Mathf.Max(0, _0xf0775382 - 1);
        }

        for (int _0x3b5eb304 = 0; _0x3b5eb304 < this._cards.Length; _0x3b5eb304++)
        {
            this._cards[_0x3b5eb304]._0x2f8aa4af(_0x3b5eb304 >= _0xf0775382);
            this._cards[_0x3b5eb304]._0xad41c884(_0x3b5eb304 == this._0x3b294b08);
        }

        if (this._launchLabel != null)
        {
            this._launchLabel.text = _0xb50de71c._0xa48689e5(new byte[14] { 230, 235, 255, 228, 233, 226, 138, 249, 239, 233, 254, 229, 248, 138 }, 170) + (this._0x3b294b08 + 1).ToString();
        }
    }

    public void _0xdd7bea86(Transform _0x3a9a07f8, Sprite _0x9d77d747, Sprite _0x0a28609f, Sprite _0xb8f7deb3, Sprite _0x172815f2, TMP_FontAsset _0xb918c451)
    {
        RectTransform _0x3a4e19ac = _0x341165e8.Stretch(_0x3a9a07f8, _0xb50de71c._0xa48689e5(new byte[11] { 166, 144, 150, 129, 154, 135, 166, 157, 144, 144, 129 }, 245));
        Image _0xb4822135 = _0x341165e8.StretchPlate(_0x3a4e19ac, _0xb50de71c._0xa48689e5(new byte[10] { 154, 161, 172, 172, 189, 154, 161, 168, 173, 172 }, 201), _0xf18456f5.Alpha(_0xf18456f5.InkDeep, 0.88f));
        _0xb4822135.raycastTarget = true;
        _0xb4822135.canvasRenderer.cullTransparentMesh = false;
        Image _0xed01f6f5 = _0x341165e8.Plate(_0x3a4e19ac, _0xb50de71c._0xa48689e5(new byte[9] { 209, 234, 231, 231, 246, 199, 230, 229, 231 }, 130), new Vector2(0.5f, 0.52f), Vector2.zero, new Vector2(1100f, 1640f), _0xf18456f5.Alpha(_0xf18456f5.Accent, 0.65f), _0x172815f2);
        _0xed01f6f5.raycastTarget = false;
        Image _0x4a769ae0 = _0x341165e8.Plate(_0x3a4e19ac, _0xb50de71c._0xa48689e5(new byte[9] { 253, 198, 203, 203, 218, 232, 207, 205, 203 }, 174), new Vector2(0.5f, 0.52f), Vector2.zero, new Vector2(1088f, 1628f), _0xf18456f5.Alpha(_0xf18456f5.Ink, 0.97f), _0x172815f2);
        _0x4a769ae0.raycastTarget = true;
        _0x4a769ae0.canvasRenderer.cullTransparentMesh = false;
        _0x341165e8.Label(_0x3a4e19ac, _0xb50de71c._0xa48689e5(new byte[10] { 226, 217, 212, 212, 197, 229, 216, 197, 221, 212 }, 177), _0xb50de71c._0xa48689e5(new byte[7] { 110, 120, 126, 105, 114, 111, 110 }, 61), new Vector2(0.5f, 0.845f), Vector2.zero, new Vector2(560f, 86f), 36f, 54f, _0xf18456f5.Paper, _0xb918c451, TextAlignmentOptions.Center);
        Button _0xc8ed28b1 = _0x341165e8.IconCta(_0x3a4e19ac, _0xb50de71c._0xa48689e5(new byte[10] { 106, 81, 92, 92, 77, 122, 85, 86, 74, 92 }, 57), _0xb8f7deb3, new Vector2(0.875f, 0.845f), Vector2.zero, new Vector2(104f, 104f), _0xf18456f5.Alpha(_0xf18456f5.Surface, 0.95f), _0xf18456f5.Alpha(_0xf18456f5.Danger, 0.9f), _0x172815f2);
        _0xc8ed28b1.onClick.AddListener(() => this._0x30402c7c());
        List<_0x98bb2d26> _0x6f6766a4 = new List<_0x98bb2d26>();
        for (int _0x0557dec7 = 0; _0x0557dec7 < _0xe6c2d6f3.Count; _0x0557dec7++)
        {
            RectTransform _0x4921ceca = _0x341165e8.Node(_0x3a4e19ac, _0xb50de71c._0xa48689e5(new byte[10] { 206, 248, 254, 233, 242, 239, 222, 252, 239, 249 }, 157) + _0x0557dec7.ToString(), new Vector2(0.5f, FirstCardY - (_0x0557dec7 * CardStepY)), Vector2.zero, new Vector2(1040f, 236f));
            _0x98bb2d26 _0x02f3edcd = _0x4921ceca.gameObject.AddComponent<_0x98bb2d26>();
            _0x02f3edcd._0x444a7f02(_0x4921ceca, _0x0557dec7, _0x9d77d747, _0x0a28609f, _0xb918c451, _0x172815f2);
            Button _0xe8599188 = _0x4921ceca.gameObject.AddComponent<Button>();
            _0xe8599188.targetGraphic = _0x4921ceca.GetComponentInChildren<Image>();
            int _0xae0effc9 = _0x0557dec7;
            _0xe8599188.onClick.AddListener(() => this._0x6d485603(_0xae0effc9));
            _0x6f6766a4.Add(_0x02f3edcd);
        }

        this._cards = _0x6f6766a4.ToArray();
        this._emptyNote = _0x341165e8.Label(_0x3a4e19ac, _0xb50de71c._0xa48689e5(new byte[10] { 243, 200, 197, 197, 212, 229, 205, 208, 212, 217 }, 160), _0xb50de71c._0xa48689e5(new byte[20] { 226, 227, 248, 228, 229, 226, 235, 140, 249, 226, 224, 227, 239, 231, 233, 232, 140, 245, 233, 248 }, 172), new Vector2(0.5f, 0.52f), Vector2.zero, new Vector2(900f, 90f), 30f, 46f, _0xf18456f5.Alpha(_0xf18456f5.Paper, 0.75f), _0xb918c451, TextAlignmentOptions.Center);
        this._emptyNote.gameObject.SetActive(false);
        Button _0x603304f3 = _0x341165e8.Cta(_0x3a4e19ac, _0xb50de71c._0xa48689e5(new byte[11] { 0, 59, 54, 54, 39, 31, 50, 38, 61, 48, 59 }, 83), _0xb50de71c._0xa48689e5(new byte[15] { 56, 53, 33, 58, 55, 60, 84, 39, 49, 55, 32, 59, 38, 84, 69 }, 116), new Vector2(0.5f, 0.118f), Vector2.zero, new Vector2(700f, 150f), _0xf18456f5.Alpha(_0xf18456f5.Surface, 0.96f), _0xf18456f5.Accent, _0xf18456f5.Paper, 32f, 48f, _0xb918c451, _0x172815f2);
        _0x603304f3.onClick.AddListener(() => this._0xaf8a3209());
        this._launchLabel = _0x603304f3.GetComponentInChildren<TextMeshProUGUI>();
        // The gate lives on the director, never on the object it switches off.
        this._gate = this.gameObject.AddComponent<_0x875ac168>();
        this._gate._0x730e14dd(_0x3a4e19ac.gameObject);
        this._gate._0xf257c7f4();
    }

    [SerializeField]
    private _0x98bb2d26[] _cards;
    [SerializeField]
    private TextMeshProUGUI _emptyNote;
    public void _0x30402c7c()
    {
        if (this._gate != null)
        {
            this._gate._0xf257c7f4();
        }
    }

    public void _0xe50d100b()
    {
        this._0x3b294b08 = _0x69baa7e4._0x107c22cb;
        this._0xb409785a();
        if (this._gate != null)
        {
            this._gate._0xe2a5f96f();
        }
    }

    private const float CardStepY = 268f / 2688f;
}

internal static class _0xb50de71c
{
    internal static string _0xa48689e5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}