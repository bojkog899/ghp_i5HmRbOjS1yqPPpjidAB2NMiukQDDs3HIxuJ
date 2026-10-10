using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x5e2efedd : MonoBehaviour
{
    private static void OrientationChanged()
    {
        _0x6be27ceb = Screen.orientation;
        _0xafce4061.x = Screen.width;
        _0xafce4061.y = Screen.height;
        _0x3528fd80.Invoke();
    }

    private static void ResolutionChanged()
    {
        _0xafce4061.x = Screen.width;
        _0xafce4061.y = Screen.height;
        _0x3528fd80.Invoke();
    }

    private RectTransform _0xe51127e0;
    private void Awake()
    {
        if (!_0xe88e36fb.Contains(this))
            _0xe88e36fb.Add(this);
        this._0x0e0fde25 = this.GetComponent<Canvas>();
        this._0xe51127e0 = this.GetComponent<RectTransform>();
        this._0x107ab456 = this.transform.Find(_0x0f3bbf15._0x3f8629dc(new byte[8] { 188, 142, 137, 138, 174, 157, 138, 142 }, 239)) as RectTransform;
        if (!_0xe083c24c)
        {
            _0x6be27ceb = Screen.orientation;
            _0xafce4061.x = Screen.width;
            _0xafce4061.y = Screen.height;
            _0x49644946 = Screen.safeArea;
            _0xe083c24c = true;
        }

        this._0x27f7c750();
    }

    private RectTransform _0x107ab456;
    private void Update()
    {
        if (_0xe88e36fb[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x6be27ceb)
            OrientationChanged();
        if (Screen.safeArea != _0x49644946)
            SafeAreaChanged();
        if (Screen.width != _0xafce4061.x || Screen.height != _0xafce4061.y)
            ResolutionChanged();
    }

    private static Rect _0x49644946 = Rect.zero;
    private static readonly List<_0x5e2efedd> _0xe88e36fb = new();
    private void _0x27f7c750()
    {
        if (this._0x107ab456 == null)
            return;
        Rect _0x60036c16 = Screen.safeArea;
        Vector2 _0x46d62b15 = _0x60036c16.position;
        Vector2 _0xba666519 = _0x60036c16.position + _0x60036c16.size;
        _0x46d62b15.x /= this._0x0e0fde25.pixelRect.width;
        _0x46d62b15.y /= this._0x0e0fde25.pixelRect.height;
        _0xba666519.x /= this._0x0e0fde25.pixelRect.width;
        _0xba666519.y /= this._0x0e0fde25.pixelRect.height;
        this._0x107ab456.anchorMin = _0x46d62b15;
        this._0x107ab456.anchorMax = _0xba666519;
    }

    private static UnityEvent _0x3528fd80 = new();
    private static void SafeAreaChanged()
    {
        _0x49644946 = Screen.safeArea;
        for (int _0x4fa4b43d = 0; _0x4fa4b43d < _0xe88e36fb.Count; _0x4fa4b43d++)
            _0xe88e36fb[_0x4fa4b43d]._0x27f7c750();
    }

    private Canvas _0x0e0fde25;
    private static Vector2 _0xafce4061 = Vector2.zero;
    private static bool _0xe083c24c;
    private void OnDestroy()
    {
        if (_0xe88e36fb != null && _0xe88e36fb.Contains(this))
            _0xe88e36fb.Remove(this);
    }

    private static ScreenOrientation _0x6be27ceb = ScreenOrientation.LandscapeLeft;
}

internal static class _0x0f3bbf15
{
    internal static string _0x3f8629dc(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}