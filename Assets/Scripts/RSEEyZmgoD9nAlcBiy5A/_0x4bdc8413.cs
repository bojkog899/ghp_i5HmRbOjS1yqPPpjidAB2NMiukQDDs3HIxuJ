using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Three illustrated steps explaining the gesture scheme. Shown from the menu, so a
// player meets the controls before the shaft does (C.6).
public sealed class _0x4bdc8413 : MonoBehaviour
{
    private void _0xb71b3c3d(Transform _0x9de97027, int _0xfedbbe46, Sprite _0x04422cd0, string _0x2a108103, Sprite _0x7f4bfb50, TMP_FontAsset _0x62f77248)
    {
        float _0xe4582b56 = _0x63ba6769[_0xfedbbe46];
        Image _0xa6168b98 = _0x341165e8.Plate(_0x9de97027, _0x9934381b._0x55176833(new byte[8] { 236, 203, 211, 240, 203, 246, 203, 211 }, 164) + _0xfedbbe46.ToString(), new Vector2(0.5f, _0xe4582b56), Vector2.zero, new Vector2(1000f, 260f), _0xf18456f5.Alpha(_0xf18456f5.Surface, 0.92f), _0x7f4bfb50);
        _0xa6168b98.raycastTarget = false;
        _0x341165e8.Picture(_0x9de97027, _0x9934381b._0x55176833(new byte[8] { 40, 15, 23, 52, 15, 33, 18, 20 }, 96) + _0xfedbbe46.ToString(), _0x04422cd0, new Vector2(0.5f, _0xe4582b56), new Vector2(-350f, 0f), new Vector2(220f, 220f));
        _0x341165e8.Label(_0x9de97027, _0x9934381b._0x55176833(new byte[9] { 45, 10, 18, 49, 10, 38, 10, 21, 28 }, 101) + _0xfedbbe46.ToString(), _0x2a108103, new Vector2(0.5f, _0xe4582b56), new Vector2(130f, 0f), new Vector2(620f, 210f), 28f, 42f, _0xf18456f5.Paper, _0x62f77248, TextAlignmentOptions.Left);
    }

    public void _0x8d6a6129()
    {
        if (this._gate != null)
        {
            this._gate._0xf257c7f4();
        }
    }

    public bool _0x8ccfd60d
    {
        get
        {
            return this._gate != null && this._gate._0xc2f75570;
        }
    }

    public void _0x74d6221d()
    {
        if (this._gate != null)
        {
            this._gate._0xe2a5f96f();
        }
    }

    public void _0x17e91ed7(Transform _0x02df2182, Sprite _0xafac0f0d, Sprite _0xb441e901, Sprite _0x46dd2ccb, Sprite _0x8f751afe, Sprite _0xe6c24fcc, TMP_FontAsset _0x18863730)
    {
        RectTransform _0xc746c497 = _0x341165e8.Stretch(_0x02df2182, _0x9934381b._0x55176833(new byte[10] { 122, 93, 69, 102, 93, 97, 90, 87, 87, 70 }, 50));
        Image _0xe8da157a = _0x341165e8.StretchPlate(_0xc746c497, _0x9934381b._0x55176833(new byte[10] { 176, 151, 143, 172, 151, 171, 144, 153, 156, 157 }, 248), _0xf18456f5.Alpha(_0xf18456f5.InkDeep, 0.9f));
        _0xe8da157a.raycastTarget = true;
        _0xe8da157a.canvasRenderer.cullTransparentMesh = false;
        Image _0xf1e0787f = _0x341165e8.Plate(_0xc746c497, _0x9934381b._0x55176833(new byte[9] { 225, 198, 222, 253, 198, 236, 205, 206, 204 }, 169), new Vector2(0.5f, 0.52f), Vector2.zero, new Vector2(1100f, 1640f), _0xf18456f5.Alpha(_0xf18456f5.Violet, 0.75f), _0xe6c24fcc);
        _0xf1e0787f.raycastTarget = false;
        Image _0x3c63df2a = _0x341165e8.Plate(_0xc746c497, _0x9934381b._0x55176833(new byte[9] { 79, 104, 112, 83, 104, 65, 102, 100, 98 }, 7), new Vector2(0.5f, 0.52f), Vector2.zero, new Vector2(1088f, 1628f), _0xf18456f5.Alpha(_0xf18456f5.Ink, 0.97f), _0xe6c24fcc);
        _0x3c63df2a.raycastTarget = true;
        _0x3c63df2a.canvasRenderer.cullTransparentMesh = false;
        _0x341165e8.Label(_0xc746c497, _0x9934381b._0x55176833(new byte[10] { 199, 224, 248, 219, 224, 219, 230, 251, 227, 234 }, 143), _0x9934381b._0x55176833(new byte[11] { 1, 6, 30, 105, 29, 6, 105, 25, 5, 8, 16 }, 73), new Vector2(0.5f, 0.845f), Vector2.zero, new Vector2(700f, 86f), 36f, 54f, _0xf18456f5.Paper, _0x18863730, TextAlignmentOptions.Center);
        Button _0x603402b3 = _0x341165e8.IconCta(_0xc746c497, _0x9934381b._0x55176833(new byte[10] { 209, 246, 238, 205, 246, 218, 245, 246, 234, 252 }, 153), _0x8f751afe, new Vector2(0.875f, 0.845f), Vector2.zero, new Vector2(104f, 104f), _0xf18456f5.Alpha(_0xf18456f5.Surface, 0.95f), _0xf18456f5.Alpha(_0xf18456f5.Danger, 0.9f), _0xe6c24fcc);
        _0x603402b3.onClick.AddListener(() => this._0x8d6a6129());
        this._0xb71b3c3d(_0xc746c497, 0, _0xafac0f0d, _0x9934381b._0x55176833(new byte[37] { 98, 126, 115, 22, 119, 100, 100, 121, 97, 22, 101, 97, 127, 120, 113, 101, 60, 98, 119, 102, 22, 98, 121, 22, 122, 121, 117, 125, 22, 98, 126, 115, 22, 124, 99, 123, 102 }, 54), _0xe6c24fcc, _0x18863730);
        this._0xb71b3c3d(_0xc746c497, 1, _0xb441e901, _0x9934381b._0x55176833(new byte[45] { 63, 52, 46, 57, 55, 62, 91, 47, 58, 43, 91, 50, 53, 91, 47, 51, 62, 91, 58, 50, 41, 113, 47, 52, 91, 57, 41, 58, 48, 62, 91, 58, 53, 63, 91, 63, 41, 52, 43, 91, 40, 51, 52, 41, 47 }, 123), _0xe6c24fcc, _0x18863730);
        this._0xb71b3c3d(_0xc746c497, 2, _0x46dd2ccb, _0x9934381b._0x55176833(new byte[57] { 159, 136, 140, 142, 133, 237, 153, 133, 136, 237, 153, 130, 157, 237, 143, 136, 140, 142, 130, 131, 199, 153, 133, 159, 136, 136, 237, 139, 140, 129, 129, 158, 237, 130, 159, 237, 153, 132, 128, 136, 237, 130, 152, 153, 199, 136, 131, 137, 158, 237, 153, 133, 136, 237, 159, 152, 131 }, 205), _0xe6c24fcc, _0x18863730);
        Button _0x6df5bc46 = _0x341165e8.Cta(_0xc746c497, _0x9934381b._0x55176833(new byte[8] { 111, 72, 80, 115, 72, 96, 72, 83 }, 39), _0x9934381b._0x55176833(new byte[6] { 102, 110, 117, 1, 104, 117 }, 33), new Vector2(0.5f, 0.185f), Vector2.zero, new Vector2(560f, 140f), _0xf18456f5.Alpha(_0xf18456f5.Surface, 0.96f), _0xf18456f5.Accent, _0xf18456f5.Paper, 32f, 48f, _0x18863730, _0xe6c24fcc);
        _0x6df5bc46.onClick.AddListener(() => this._0x8d6a6129());
        this._gate = this.gameObject.AddComponent<_0x875ac168>();
        this._gate._0x730e14dd(_0xc746c497.gameObject);
        this._gate._0xf257c7f4();
    }

    [SerializeField]
    private _0x875ac168 _gate;
    private static readonly float[] _0x63ba6769 = new float[]
    {
        0.700f,
        0.530f,
        0.360f
    };
}

internal static class _0x9934381b
{
    internal static string _0x55176833(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}