using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xd23b4bf3 : MonoBehaviour
{
    private static bool _0x01c35867;
    private static readonly List<_0xd23b4bf3> _0x1357ed9e = new();
    private Vector2 _0x433b0aa5;
    private void OnDestroy()
    {
        if (_0x1357ed9e != null && _0x1357ed9e.Contains(this))
            _0x1357ed9e.Remove(this);
    }

    private void Update()
    {
        if (_0x1357ed9e.Count == 0 || _0x1357ed9e[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x409e5a26)
            OrientationChanged();
        if (Screen.safeArea != _0x61998d87)
            SafeAreaChanged();
        if (Screen.width != _0x5fceb455.x || Screen.height != _0x5fceb455.y)
            ResolutionChanged();
    }

    private static UnityEvent _0xe5ab4353 = new();
    private RectTransform _0x60bce932;
    private static Rect _0x61998d87 = Rect.zero;
    private static void OrientationChanged()
    {
        _0x409e5a26 = Screen.orientation;
        _0x5fceb455.x = Screen.width;
        _0x5fceb455.y = Screen.height;
        _0x61998d87 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xe5ab4353.Invoke();
    }

    private Canvas _0x3ae4467f;
    private static ScreenOrientation _0x409e5a26 = ScreenOrientation.LandscapeLeft;
    private void Awake()
    {
        if (!_0x1357ed9e.Contains(this))
            _0x1357ed9e.Add(this);
        this._0x3ae4467f = this.GetComponent<Canvas>();
        this._0x2b107d46 = this.GetComponent<CanvasScaler>();
        if (this._0x2b107d46 != null)
            this._0x433b0aa5 = this._0x2b107d46.referenceResolution;
        this._0x60bce932 = this.GetComponent<RectTransform>();
        this._0x265ee6cb = this.transform.Find(_0xee93f664._0xc7c98c01(new byte[8] { 120, 74, 77, 78, 106, 89, 78, 74 }, 43)) as RectTransform;
        if (!_0x01c35867)
        {
            _0x409e5a26 = Screen.orientation;
            _0x5fceb455.x = Screen.width;
            _0x5fceb455.y = Screen.height;
            _0x61998d87 = Screen.safeArea;
            _0x01c35867 = true;
        }

        this._0x55339251();
    }

    private static void ResolutionChanged()
    {
        _0x5fceb455.x = Screen.width;
        _0x5fceb455.y = Screen.height;
        _0x61998d87 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xe5ab4353.Invoke();
    }

    private void _0x55339251()
    {
        if (this._0x265ee6cb == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0xea1a10ba = Screen.safeArea;
        Vector2 _0x5eabc8ac = _0xea1a10ba.position;
        Vector2 _0x33e181cf = _0xea1a10ba.position + _0xea1a10ba.size;
        _0x5eabc8ac.x /= screenWidth;
        _0x5eabc8ac.y /= screenHeight;
        _0x33e181cf.x /= screenWidth;
        _0x33e181cf.y /= screenHeight;
        this._0x265ee6cb.anchorMin = _0x5eabc8ac;
        this._0x265ee6cb.anchorMax = _0x33e181cf;
        this._0x265ee6cb.offsetMin = Vector2.zero;
        this._0x265ee6cb.offsetMax = Vector2.zero;
        if (this._0x2b107d46 == null)
            return;
        Vector2 _0x83cec818 = _0x33e181cf - _0x5eabc8ac;
        float _0xa3f9a59a = 2f - _0x83cec818.x;
        float _0x2518827a = 2f - _0x83cec818.y;
        this._0x2b107d46.referenceResolution = this._0x433b0aa5 * new Vector2(_0xa3f9a59a, _0x2518827a);
    }

    private CanvasScaler _0x2b107d46;
    private static void ApplySafeAreaToAll()
    {
        for (int _0x06723ea6 = 0; _0x06723ea6 < _0x1357ed9e.Count; _0x06723ea6++)
            _0x1357ed9e[_0x06723ea6]._0x55339251();
    }

    private static Vector2 _0x5fceb455 = Vector2.zero;
    private RectTransform _0x265ee6cb;
    private void Start()
    {
    }

    private static void SafeAreaChanged()
    {
        _0x61998d87 = Screen.safeArea;
        ApplySafeAreaToAll();
    }
}

internal static class _0xee93f664
{
    internal static string _0xc7c98c01(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}