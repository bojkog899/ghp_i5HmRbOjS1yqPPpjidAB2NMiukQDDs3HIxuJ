using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Small factory for the runtime UGUI this game builds inside the template's own
// panel bodies. Everything is expressed in the canvas reference units (1242x2688).
public static class _0x341165e8
{
    public static RectTransform Node(Transform _0xba4725d2, string _0x9838b349, Vector2 _0xd1fe8ae5, Vector2 _0x00c85c90, Vector2 _0x6805aff9)
    {
        GameObject _0xdec7e0b1 = new GameObject(_0x9838b349, typeof(RectTransform));
        RectTransform _0xa918745b = _0xdec7e0b1.GetComponent<RectTransform>();
        _0xa918745b.SetParent(_0xba4725d2, false);
        _0xa918745b.anchorMin = _0xd1fe8ae5;
        _0xa918745b.anchorMax = _0xd1fe8ae5;
        _0xa918745b.pivot = new Vector2(0.5f, 0.5f);
        _0xa918745b.anchoredPosition = _0x00c85c90;
        _0xa918745b.sizeDelta = _0x6805aff9;
        _0xa918745b.localScale = Vector3.one;
        return _0xa918745b;
    }

    public const float CanvasWidth = 1242f;
    public static RectTransform Stretch(Transform _0x781b2067, string _0x8ecce989)
    {
        GameObject _0xc0847f1a = new GameObject(_0x8ecce989, typeof(RectTransform));
        RectTransform _0xf5764b2b = _0xc0847f1a.GetComponent<RectTransform>();
        _0xf5764b2b.SetParent(_0x781b2067, false);
        _0xf5764b2b.anchorMin = Vector2.zero;
        _0xf5764b2b.anchorMax = Vector2.one;
        _0xf5764b2b.pivot = new Vector2(0.5f, 0.5f);
        _0xf5764b2b.anchoredPosition = Vector2.zero;
        _0xf5764b2b.sizeDelta = Vector2.zero;
        _0xf5764b2b.localScale = Vector3.one;
        return _0xf5764b2b;
    }

    public static Image StretchPlate(Transform _0x271655a9, string _0x3007db14, Color _0x5562c210)
    {
        RectTransform _0x580dc30a = Stretch(_0x271655a9, _0x3007db14);
        Image _0x42213210 = _0x580dc30a.gameObject.AddComponent<Image>();
        _0x42213210.color = _0x5562c210;
        _0x42213210.raycastTarget = false;
        return _0x42213210;
    }

    // One slot, one button: a plate, an optional icon, and the caption LAST so the
    // background can never cover its own text (C.13 / E.1).
    public static Button Cta(Transform _0xf6625cb5, string _0x18ab9a54, string _0xb8f64b74, Vector2 _0x5f9749e8, Vector2 _0x83a9c837, Vector2 _0x44ee4524, Color _0x038a5d1d, Color _0x8b60eea2, Color _0x5cc0a51e, float _0xf2ba74aa, float _0x6d1bacc4, TMP_FontAsset _0xb6bacc40, Sprite _0x35112b44)
    {
        RectTransform _0xb54ee11e = Node(_0xf6625cb5, _0x18ab9a54, _0x5f9749e8, _0x83a9c837, _0x44ee4524);
        Image _0xb6396912 = _0xb54ee11e.gameObject.AddComponent<Image>();
        _0xb6396912.sprite = _0x35112b44;
        _0xb6396912.preserveAspect = false;
        _0xb6396912.type = _0x35112b44 == null ? Image.Type.Simple : Image.Type.Sliced;
        _0xb6396912.pixelsPerUnitMultiplier = RoundnessFor(_0x44ee4524);
        _0xb6396912.color = _0x8b60eea2;
        _0xb6396912.raycastTarget = true;
        _0xb6396912.canvasRenderer.cullTransparentMesh = false;
        Vector2 _0x92fd41ac = new Vector2(_0x44ee4524.x - 10f, _0x44ee4524.y - 10f);
        Image _0x740bc214 = Plate(_0xb54ee11e, _0x18ab9a54 + _0x21fc5996._0x3fd57d97(new byte[4] { 13, 42, 40, 46 }, 75), new Vector2(0.5f, 0.5f), Vector2.zero, _0x92fd41ac, _0x038a5d1d, _0x35112b44);
        _0x740bc214.raycastTarget = true;
        _0x740bc214.canvasRenderer.cullTransparentMesh = false;
        TextMeshProUGUI _0x369d1903 = Label(_0xb54ee11e, _0x18ab9a54 + _0x21fc5996._0x3fd57d97(new byte[4] { 35, 18, 15, 3 }, 119), _0xb8f64b74, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0x44ee4524.x - 60f, _0x44ee4524.y - 36f), _0xf2ba74aa, _0x6d1bacc4, _0x5cc0a51e, _0xb6bacc40, TextAlignmentOptions.Center);
        _0x369d1903.transform.SetAsLastSibling();
        Button _0xd79f3543 = _0xb54ee11e.gameObject.AddComponent<Button>();
        _0xd79f3543.targetGraphic = _0x740bc214;
        ColorBlock _0xd92a60a4 = _0xd79f3543.colors;
        _0xd92a60a4.normalColor = Color.white;
        _0xd92a60a4.highlightedColor = new Color(1f, 1f, 1f, 1f);
        _0xd92a60a4.pressedColor = new Color(0.72f, 0.72f, 0.72f, 1f);
        _0xd92a60a4.selectedColor = Color.white;
        _0xd92a60a4.disabledColor = new Color(1f, 1f, 1f, 0.45f);
        _0xd92a60a4.fadeDuration = 0.08f;
        _0xd79f3543.colors = _0xd92a60a4;
        return _0xd79f3543;
    }

    // sliced_solid_round ships a 127 px border on every side, so the corner radius
    // multiplier has to be derived from the SMALLEST side of the rect or the nine
    // slices overlap and the plate renders as a sliver.
    public static float RoundnessFor(Vector2 _0x435b57de)
    {
        float _0xb586fe83 = Mathf.Max(1f, Mathf.Min(_0x435b57de.x, _0x435b57de.y));
        return Mathf.Clamp(300f / _0xb586fe83, 1.6f, 9f);
    }

    // A real PNG always keeps its aspect (F.2a): the pipeline square-pads every sprite,
    // so Simple + preserveAspect is the only honest way to draw one.
    public static Image Picture(Transform _0x158ac0ba, string _0x551d42ba, Sprite _0x0ba7d669, Vector2 _0xa0e629ae, Vector2 _0xefb141ef, Vector2 _0x6f21ccfc)
    {
        RectTransform _0x12b124b4 = Node(_0x158ac0ba, _0x551d42ba, _0xa0e629ae, _0xefb141ef, _0x6f21ccfc);
        Image _0x8896ef25 = _0x12b124b4.gameObject.AddComponent<Image>();
        _0x8896ef25.sprite = _0x0ba7d669;
        _0x8896ef25.preserveAspect = true;
        _0x8896ef25.type = Image.Type.Simple;
        _0x8896ef25.raycastTarget = false;
        return _0x8896ef25;
    }

    public const float CanvasHeight = 2688f;
    public static Button IconCta(Transform _0x42f2afa2, string _0xd8f99caa, Sprite _0xb596153c, Vector2 _0xa77ea18e, Vector2 _0x5f493828, Vector2 _0x71b4f43b, Color _0x928a0ec9, Color _0x8c2e2726, Sprite _0xacd42a0e)
    {
        RectTransform _0xca9a487f = Node(_0x42f2afa2, _0xd8f99caa, _0xa77ea18e, _0x5f493828, _0x71b4f43b);
        Image _0xe6d12762 = _0xca9a487f.gameObject.AddComponent<Image>();
        _0xe6d12762.sprite = _0xacd42a0e;
        _0xe6d12762.preserveAspect = false;
        _0xe6d12762.type = _0xacd42a0e == null ? Image.Type.Simple : Image.Type.Sliced;
        _0xe6d12762.pixelsPerUnitMultiplier = RoundnessFor(_0x71b4f43b);
        _0xe6d12762.color = _0x8c2e2726;
        _0xe6d12762.raycastTarget = true;
        _0xe6d12762.canvasRenderer.cullTransparentMesh = false;
        Image _0xe5a10f09 = Plate(_0xca9a487f, _0xd8f99caa + _0x21fc5996._0x3fd57d97(new byte[4] { 199, 224, 226, 228 }, 129), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0x71b4f43b.x - 8f, _0x71b4f43b.y - 8f), _0x928a0ec9, _0xacd42a0e);
        _0xe5a10f09.raycastTarget = true;
        _0xe5a10f09.canvasRenderer.cullTransparentMesh = false;
        Image _0x8d4c0928 = Picture(_0xca9a487f, _0xd8f99caa + _0x21fc5996._0x3fd57d97(new byte[5] { 15, 36, 49, 56, 32 }, 72), _0xb596153c, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0x71b4f43b.x * 0.52f, _0x71b4f43b.y * 0.52f));
        _0x8d4c0928.transform.SetAsLastSibling();
        Button _0xc57fdbfa = _0xca9a487f.gameObject.AddComponent<Button>();
        _0xc57fdbfa.targetGraphic = _0xe5a10f09;
        ColorBlock _0xfe963adc = _0xc57fdbfa.colors;
        _0xfe963adc.normalColor = Color.white;
        _0xfe963adc.pressedColor = new Color(0.72f, 0.72f, 0.72f, 1f);
        _0xfe963adc.fadeDuration = 0.08f;
        _0xc57fdbfa.colors = _0xfe963adc;
        return _0xc57fdbfa;
    }

    public static Image Plate(Transform _0xef8b8e07, string _0x0f9ae8db, Vector2 _0xa2616ae1, Vector2 _0x10673ac6, Vector2 _0x5a97a7a8, Color _0x9ad20160, Sprite _0x055bfbde)
    {
        RectTransform _0xb14203d0 = Node(_0xef8b8e07, _0x0f9ae8db, _0xa2616ae1, _0x10673ac6, _0x5a97a7a8);
        Image _0xccfe90be = _0xb14203d0.gameObject.AddComponent<Image>();
        _0xccfe90be.sprite = _0x055bfbde;
        _0xccfe90be.preserveAspect = false;
        _0xccfe90be.type = _0x055bfbde == null ? Image.Type.Simple : Image.Type.Sliced;
        _0xccfe90be.pixelsPerUnitMultiplier = RoundnessFor(_0x5a97a7a8);
        _0xccfe90be.color = _0x9ad20160;
        _0xccfe90be.raycastTarget = false;
        return _0xccfe90be;
    }

    public static TextMeshProUGUI Label(Transform _0x4dad0308, string _0x85a9ef78, string _0xabf97353, Vector2 _0xd02511b1, Vector2 _0x6778bb57, Vector2 _0xcc373b13, float _0xab5ca27b, float _0x30aab411, Color _0x33cf2969, TMP_FontAsset _0xf175979c, TextAlignmentOptions _0x9940591d)
    {
        RectTransform _0xa5f5b462 = Node(_0x4dad0308, _0x85a9ef78, _0xd02511b1, _0x6778bb57, _0xcc373b13);
        TextMeshProUGUI _0x5cea9bab = _0xa5f5b462.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0xf175979c != null)
        {
            _0x5cea9bab.font = _0xf175979c;
        }

        _0x5cea9bab.text = _0xabf97353;
        _0x5cea9bab.color = _0x33cf2969;
        _0x5cea9bab.alignment = _0x9940591d;
        _0x5cea9bab.raycastTarget = false;
        _0x5cea9bab.textWrappingMode = TextWrappingModes.NoWrap;
        _0x5cea9bab.overflowMode = TextOverflowModes.Overflow;
        _0x5cea9bab.enableAutoSizing = true;
        _0x5cea9bab.fontSizeMin = _0xab5ca27b;
        _0x5cea9bab.fontSizeMax = _0x30aab411;
        _0x5cea9bab.characterSpacing = 4f;
        _0xba6089da.ApplyOutline(_0x5cea9bab);
        return _0x5cea9bab;
    }
}

internal static class _0x21fc5996
{
    internal static string _0x3fd57d97(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}