using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The control scheme is not "press a button", so the gesture and its result are
// written on the play screen and stay there for the whole run (C.6).
public sealed class _0xe8e929b3 : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _text;
    public void _0x1a18e5cd(float deltaTime)
    {
        if (this._0x8a3d4edd > BrightSeconds)
        {
            return;
        }

        this._0x8a3d4edd += deltaTime;
        if (this._0x8a3d4edd <= BrightSeconds)
        {
            return;
        }

        if (this._plate != null)
        {
            this._plate.color = _0xf18456f5.Alpha(_0xf18456f5.InkDeep, 0.5f);
        }

        if (this._text != null)
        {
            this._text.color = _0xf18456f5.Alpha(_0xf18456f5.Paper, 0.62f);
        }
    }

    public void _0xd04beedb(Transform _0xe0be89de, TMP_FontAsset _0x3a8b7646, Sprite _0xebce7d9b)
    {
        Vector2 _0xdd992e3f = new Vector2(0.5f, 0.072f);
        this._plate = _0x341165e8.Plate(_0xe0be89de, _0xa3eb42af._0x6a945be3(new byte[9] { 170, 139, 140, 150, 178, 142, 131, 150, 135 }, 226), _0xdd992e3f, Vector2.zero, new Vector2(1120f, 84f), _0xf18456f5.Alpha(_0xf18456f5.InkDeep, 0.72f), _0xebce7d9b);
        this._text = _0x341165e8.Label(_0xe0be89de, _0xa3eb42af._0x6a945be3(new byte[8] { 230, 199, 192, 218, 250, 203, 214, 218 }, 174), _0xa3eb42af._0x6a945be3(new byte[42] { 148, 129, 144, 224, 148, 143, 224, 140, 143, 131, 139, 224, 138, 149, 141, 144, 224, 237, 224, 132, 143, 149, 130, 140, 133, 224, 148, 129, 144, 224, 148, 143, 224, 129, 137, 146, 224, 130, 146, 129, 139, 133 }, 192), _0xdd992e3f, Vector2.zero, new Vector2(1060f, 70f), 28f, 40f, _0xf18456f5.Paper, _0x3a8b7646, TextAlignmentOptions.Center);
        this._text.transform.SetAsLastSibling();
    }

    [SerializeField]
    private Image _plate;
    private const float BrightSeconds = 6f;
    private float _0x8a3d4edd;
}

internal static class _0xa3eb42af
{
    internal static string _0x6a945be3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}