using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Everything the shell owns and this game has to take responsibility for: the
// splash body, its loading bar, and the tutorial panels the template ships with
// filler copy. Runs in both scenes.
public sealed class _0x2ef58d51 : MonoBehaviour
{
    // The splash has to read as a different screen from the menu: darker body, an
    // abstract mark (never the app name) and a single line under the bar.
    private void _0x1c7a58b0()
    {
        _0x42b5233b _0xe083aee2 = _0x42b5233b.Instance;
        if (_0xe083aee2 == null || _0xe083aee2.Panels == null || _0xe083aee2.Panels.Count <= _0x682bf997._0x29641b38.SPLASH)
        {
            return;
        }

        _0x706c786a _0x07cce8fd = _0xe083aee2.Panels[_0x682bf997._0x29641b38.SPLASH];
        if (_0x07cce8fd == null || _0x07cce8fd.Content == null)
        {
            return;
        }

        Transform _0x14663b6a = _0x07cce8fd.Content.transform;
        RectTransform _0x9b523bd3 = _0x341165e8.Stretch(_0x14663b6a, _0x9462c2e9._0xacca2b53(new byte[11] { 60, 31, 3, 14, 28, 7, 43, 29, 10, 28, 28 }, 111));
        _0x9b523bd3.SetAsFirstSibling();
        Image _0xdb6058af = _0x341165e8.StretchPlate(_0x9b523bd3, _0x9462c2e9._0xacca2b53(new byte[11] { 112, 83, 79, 66, 80, 75, 112, 75, 66, 71, 70 }, 35), _0xf18456f5.Alpha(_0xf18456f5.Ink, 0.55f));
        _0xdb6058af.raycastTarget = false;
        Image _0x97dbb2d2 = _0x341165e8.Plate(_0x9b523bd3, _0x9462c2e9._0xacca2b53(new byte[10] { 240, 211, 207, 194, 208, 203, 235, 194, 207, 204 }, 163), new Vector2(0.5f, 0.60f), Vector2.zero, new Vector2(560f, 560f), _0xf18456f5.Alpha(_0xf18456f5.Accent, 0.16f), this._roundPlate);
        _0x97dbb2d2.raycastTarget = false;
        Image _0x622acd7b = _0x341165e8.Picture(_0x9b523bd3, _0x9462c2e9._0xacca2b53(new byte[10] { 23, 52, 40, 37, 55, 44, 9, 37, 54, 47 }, 68), this._markEmblem, new Vector2(0.5f, 0.60f), Vector2.zero, new Vector2(460f, 460f));
        _0x622acd7b.transform.localScale = Vector3.one * 0.94f;
        _0x622acd7b.transform.DOScale(1f, 0.9f).SetEase(Ease.OutBack).SetLink(_0x622acd7b.transform.gameObject);
        _0x97dbb2d2.transform.localScale = Vector3.one * 0.92f;
        _0x97dbb2d2.transform.DOScale(1.06f, 1.4f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(_0x97dbb2d2.transform.gameObject);
        _0x341165e8.Label(_0x9b523bd3, _0x9462c2e9._0xacca2b53(new byte[13] { 138, 169, 181, 184, 170, 177, 154, 184, 169, 173, 176, 182, 183 }, 217), _0x9462c2e9._0xacca2b53(new byte[13] { 163, 168, 161, 178, 167, 169, 174, 167, 192, 163, 175, 178, 165 }, 224), new Vector2(0.5f, 0.17f), Vector2.zero, new Vector2(820f, 70f), 30f, 44f, _0xf18456f5.Paper, this._font, TextAlignmentOptions.Center);
        // The loading bar is the only thing the template puts in the splash body, so it
        // has to come back to the front after anything is added underneath it.
        for (int _0x4839158d = 0; _0x4839158d < _0x14663b6a.childCount; _0x4839158d++)
        {
            Transform _0x328cc932 = _0x14663b6a.GetChild(_0x4839158d);
            if (_0x328cc932 != _0x9b523bd3 && _0x328cc932.GetComponentInChildren<Slider>(true) != null)
            {
                _0x328cc932.SetAsLastSibling();
            }
        }
    }

    [SerializeField]
    private TMP_FontAsset _font;
    private static readonly string[] _0xd9bcc90b = new string[]
    {
        _0x9462c2e9._0xacca2b53(new byte[30] { 242, 238, 227, 134, 231, 244, 244, 233, 241, 134, 245, 241, 239, 232, 225, 245, 134, 233, 240, 227, 244, 134, 242, 238, 227, 134, 229, 233, 244, 227 }, 166),
        _0x9462c2e9._0xacca2b53(new byte[25] { 193, 212, 197, 181, 218, 219, 214, 208, 181, 193, 218, 181, 217, 218, 214, 222, 181, 193, 221, 208, 181, 223, 192, 216, 197 }, 149),
        _0x9462c2e9._0xacca2b53(new byte[30] { 1, 10, 16, 7, 9, 0, 101, 17, 4, 21, 101, 12, 11, 101, 17, 13, 0, 101, 4, 12, 23, 101, 17, 10, 101, 7, 23, 4, 14, 0 }, 69),
        _0x9462c2e9._0xacca2b53(new byte[34] { 148, 155, 150, 157, 154, 135, 245, 135, 156, 155, 146, 134, 245, 135, 144, 134, 129, 154, 135, 144, 245, 148, 245, 147, 148, 153, 153, 245, 150, 157, 148, 135, 146, 144 }, 213),
        _0x9462c2e9._0xacca2b53(new byte[37] { 203, 220, 216, 218, 209, 185, 205, 209, 220, 185, 205, 214, 201, 185, 219, 220, 216, 218, 214, 215, 185, 219, 220, 223, 214, 203, 220, 185, 205, 209, 220, 185, 218, 213, 214, 218, 210 }, 153),
        "",
        "",
    };
    private void Start()
    {
        this._0x1c7a58b0();
        this._0x41757581();
        this._0x4367ed75();
    }

    // Loading bar colours (rule G): the fill takes the palette accent, the track the
    // deep ink so the progress actually reads against it.
    private void _0x41757581()
    {
        _0x42b5233b _0x6c5a2e19 = _0x42b5233b.Instance;
        if (_0x6c5a2e19 == null || _0x6c5a2e19.Panels == null || _0x6c5a2e19.Panels.Count <= _0x682bf997._0x29641b38.SPLASH)
        {
            return;
        }

        _0x706c786a _0xd556da7e = _0x6c5a2e19.Panels[_0x682bf997._0x29641b38.SPLASH];
        if (_0xd556da7e == null || _0xd556da7e.Content == null)
        {
            return;
        }

        Slider _0x89234b07 = _0xd556da7e.Content.GetComponentInChildren<Slider>(true);
        if (_0x89234b07 == null || _0x89234b07.fillRect == null)
        {
            return;
        }

        Image _0x89041bd9 = _0x89234b07.fillRect.GetComponent<Image>();
        if (_0x89041bd9 != null)
        {
            _0x89041bd9.color = _0xf18456f5.Accent;
        }

        Transform _0xaccfa76f = _0x89234b07.fillRect.parent;
        Image _0xa880e7d3 = _0xaccfa76f == null ? null : _0xaccfa76f.GetComponent<Image>();
        if (_0xa880e7d3 != null)
        {
            _0xa880e7d3.color = _0xf18456f5.Ink;
        }
    }

    // The shell declares seven tutorial slots; this game explains its controls on its
    // own HOW TO PLAY sheet, so every slot the shell wired gets this game's copy and
    // the rest are emptied - no shipped panel keeps the template filler.
    private void _0x4367ed75()
    {
        List<int> _0x57b2672c = new List<int>();
        _0x57b2672c.Add(_0x682bf997._0x29641b38.TUTORIAL0);
        _0x57b2672c.Add(_0x682bf997._0x29641b38.TUTORIAL1);
        _0x57b2672c.Add(_0x682bf997._0x29641b38.TUTORIAL2);
        _0x57b2672c.Add(_0x682bf997._0x29641b38.TUTORIAL3);
        _0x57b2672c.Add(_0x682bf997._0x29641b38.TUTORIAL4);
        _0x57b2672c.Add(_0x682bf997._0x29641b38.TUTORIAL5);
        _0x57b2672c.Add(_0x682bf997._0x29641b38.TUTORIAL6);
        _0x42b5233b _0x065b81ea = _0x42b5233b.Instance;
        if (_0x065b81ea == null || _0x065b81ea.Panels == null)
        {
            return;
        }

        for (int _0xec25e94b = 0; _0xec25e94b < _0x57b2672c.Count; _0xec25e94b++)
        {
            int _0x57a7d055 = _0x57b2672c[_0xec25e94b];
            if (_0x57a7d055 < 0 || _0x57a7d055 >= _0x065b81ea.Panels.Count)
            {
                continue;
            }

            _0x706c786a _0xf13e6e3e = _0x065b81ea.Panels[_0x57a7d055];
            if (_0xf13e6e3e == null)
            {
                continue;
            }

            string _0xf5a0bc5c = _0xec25e94b < _0xd9bcc90b.Length ? _0xd9bcc90b[_0xec25e94b] : "";
            TMP_Text[] _0x053b6b15 = _0xf13e6e3e.GetComponentsInChildren<TMP_Text>(true);
            for (int _0xea79658a = 0; _0xea79658a < _0x053b6b15.Length; _0xea79658a++)
            {
                _0x053b6b15[_0xea79658a].text = _0xf5a0bc5c;
                _0x053b6b15[_0xea79658a].textWrappingMode = TextWrappingModes.NoWrap;
                _0x053b6b15[_0xea79658a].enableAutoSizing = true;
                _0x053b6b15[_0xea79658a].fontSizeMin = 30f;
                _0x053b6b15[_0xea79658a].fontSizeMax = 52f;
                _0xf5a0bc5c = "";
            }
        }
    }

    [SerializeField]
    private Sprite _markEmblem;
    [SerializeField]
    private Sprite _roundPlate;
}

internal static class _0x9462c2e9
{
    internal static string _0xacca2b53(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}