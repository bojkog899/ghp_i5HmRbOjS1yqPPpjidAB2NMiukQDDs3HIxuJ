using System.Collections.Generic;
using UnityEngine;

public sealed class _0x80f9d849
{
    public bool IsAnchor;
    public float HalfWidth;
    public Vector2 Centre;
}

public sealed class _0x1d616098
{
    public float Phase;
    public float Direction;
    public Vector2 Centre;
    public bool IsFan;
}

public sealed class _0x4ac7f1cc
{
    public List<_0x80f9d849> Ledges = new List<_0x80f9d849>();
    public Vector2 Beacon;
    public List<_0x1d616098> Hazards = new List<_0x1d616098>();
    public bool UsedFallback;
}

// Seeded shaft builder. Every attempt gets its own route; the ballistic reach of
// each consecutive pair is proved before the layout is handed to the game (C.11).
public static class _0x9422dea6
{
    private const float StepCeiling = 1.70f;
    public const float BaseY = -3.6f;
    public const float InnerHalfWidth = 2.0f;
    public static int SeedFor(int _0x29eebb83, int _0xbb1783e5)
    {
        return (_0x29eebb83 * 7919) ^ (_0xbb1783e5 * 104729);
    }

    private const int AnchorEvery = 5;
    // Hard-wired safety net, never the game itself.
    private static _0x4ac7f1cc Fallback(_0x2b6114b1 _0x89e5133e)
    {
        _0x4ac7f1cc _0xcd3f7640 = new _0x4ac7f1cc();
        float _0x4161c046 = _0x9422dea6.BaseY;
        for (int _0x7676701e = 0; _0x7676701e < _0x89e5133e.Ledges; _0x7676701e++)
        {
            float _0x8152fb40 = _0x89e5133e.Ledges <= 1 ? 0f : (float)_0x7676701e / (_0x89e5133e.Ledges - 1);
            _0x80f9d849 _0xf33e97eb = new _0x80f9d849();
            _0xf33e97eb.Centre = new Vector2((_0x7676701e % 2 == 0) ? -0.45f : 0.45f, _0x4161c046);
            _0xf33e97eb.HalfWidth = Mathf.Lerp(_0x89e5133e.WidestLedge, _0x89e5133e.NarrowestLedge, _0x8152fb40) * 0.5f;
            _0xf33e97eb.IsAnchor = _0x7676701e > 0 && (_0x7676701e % AnchorEvery) == 0;
            _0xcd3f7640.Ledges.Add(_0xf33e97eb);
            _0x4161c046 += _0x89e5133e.RiseStep;
        }

        float _0xbb903c31 = _0xcd3f7640.Ledges[_0xcd3f7640.Ledges.Count - 1].Centre.x;
        _0xcd3f7640.Beacon = new Vector2(_0xbb903c31, _0xcd3f7640.Ledges[_0xcd3f7640.Ledges.Count - 1].Centre.y + BeaconRise);
        return _0xcd3f7640;
    }

    public const float Gravity = 9.6f;
    private static float NextRange(System.Random _0x83c3d901, float _0xbf806907, float _0xf587405b)
    {
        return _0xbf806907 + ((float)_0x83c3d901.NextDouble() * (_0xf587405b - _0xbf806907));
    }

    public const float LaunchSpeed = 6.2f;
    private const float ReachMargin = 0.08f;
    public const float MinAngleDeg = 25f;
    private const float BeaconRise = 1.20f;
    private const float MinStepX = 0.45f;
    // How far sideways a jump of this height can still carry, straight out of the
    // same ballistic form the validator uses - so a drawn route is reachable by
    // construction and the fallback stays a safety net rather than the game.
    public static float WidestStepFor(float _0xe6ba350b)
    {
        float _0xfa92b350 = LaunchSpeed * LaunchSpeed;
        float _0x6c6d1ce5 = _0xfa92b350 * _0xfa92b350;
        float _0x0d8193d2 = ((1f - ReachMargin) * _0x6c6d1ce5) - (Gravity * 2f * _0xe6ba350b * _0xfa92b350);
        if (_0x0d8193d2 <= 0f)
        {
            return 0f;
        }

        float _0x7bf27f7f = Mathf.Sqrt(_0x0d8193d2 / (Gravity * Gravity)) - 0.08f;
        return Mathf.Clamp(_0x7bf27f7f, 0f, StepCeiling);
    }

    private static _0x4ac7f1cc Draw(_0x2b6114b1 _0x86a69766, System.Random _0x91b1413b)
    {
        _0x4ac7f1cc _0x303d69c6 = new _0x4ac7f1cc();
        float _0x5159ee30 = 0f;
        float _0xf005b163 = _0x9422dea6.BaseY;
        int _0x2c211780 = _0x91b1413b.Next(0, 2) == 0 ? -1 : 1;
        for (int _0x2d905239 = 0; _0x2d905239 < _0x86a69766.Ledges; _0x2d905239++)
        {
            float _0x4da1c736 = _0x86a69766.Ledges <= 1 ? 0f : (float)_0x2d905239 / (_0x86a69766.Ledges - 1);
            float _0x85cea79b = Mathf.Lerp(_0x86a69766.WidestLedge, _0x86a69766.NarrowestLedge, _0x4da1c736) * 0.5f;
            if (_0x2d905239 > 0)
            {
                float rise = _0x86a69766.RiseStep + _0x9422dea6.NextRange(_0x91b1413b, -0.04f, 0.06f);
                float _0x3d08dc46 = _0x9422dea6.WidestStepFor(rise);
                float _0x71a70d14 = _0x9422dea6.InnerHalfWidth - _0x85cea79b - 0.08f;
                float _0x36364404 = _0x9422dea6.NextRange(_0x91b1413b, MinStepX, Mathf.Max(MinStepX + 0.05f, _0x3d08dc46));
                if (_0x91b1413b.Next(0, 100) < 32)
                {
                    _0x2c211780 = -_0x2c211780;
                }

                float _0xf7656829 = _0x5159ee30 + (_0x2c211780 * _0x36364404);
                if (_0xf7656829 > _0x71a70d14 || _0xf7656829 < -_0x71a70d14)
                {
                    _0x2c211780 = -_0x2c211780;
                    _0xf7656829 = _0x5159ee30 + (_0x2c211780 * _0x36364404);
                }

                _0x5159ee30 = Mathf.Clamp(_0xf7656829, -_0x71a70d14, _0x71a70d14);
                _0xf005b163 += rise;
            }

            _0x80f9d849 _0x9c771425 = new _0x80f9d849();
            _0x9c771425.Centre = new Vector2(_0x5159ee30, _0xf005b163);
            _0x9c771425.HalfWidth = _0x85cea79b;
            _0x9c771425.IsAnchor = _0x2d905239 > 0 && (_0x2d905239 % AnchorEvery) == 0;
            _0x303d69c6.Ledges.Add(_0x9c771425);
        }

        // The lamp sits one short hop above the top ledge: a jump that high can only
        // carry a narrow sideways offset, so it stays over the same column.
        float _0xaf037c5f = Mathf.Clamp(_0x5159ee30, -1.2f, 1.2f);
        float _0x3bb4b2e9 = _0x9422dea6.WidestStepFor(BeaconRise);
        _0x303d69c6.Beacon = new Vector2(Mathf.Clamp(_0xaf037c5f, _0x5159ee30 - _0x3bb4b2e9, _0x5159ee30 + _0x3bb4b2e9), _0xf005b163 + BeaconRise);
        _0x9422dea6.ScatterHazards(_0x86a69766, _0x91b1413b, _0x303d69c6);
        return _0x303d69c6;
    }

    private static void ScatterHazards(_0x2b6114b1 _0x853009a8, System.Random _0x8b7e13e8, _0x4ac7f1cc _0xd75de67c)
    {
        int _0xb0b47881 = _0x853009a8.Shutters + _0x853009a8.Fans;
        if (_0xb0b47881 <= 0 || _0xd75de67c.Ledges.Count < 4)
        {
            return;
        }

        List<int> _0x9895bbfb = new List<int>();
        for (int _0xf255d28a = 2; _0xf255d28a < _0xd75de67c.Ledges.Count - 1; _0xf255d28a++)
        {
            _0x9895bbfb.Add(_0xf255d28a);
        }

        for (int _0x8cfd685b = _0x9895bbfb.Count - 1; _0x8cfd685b > 0; _0x8cfd685b--)
        {
            int _0x70f970a9 = _0x8b7e13e8.Next(0, _0x8cfd685b + 1);
            int _0xe0d3417c = _0x9895bbfb[_0x8cfd685b];
            _0x9895bbfb[_0x8cfd685b] = _0x9895bbfb[_0x70f970a9];
            _0x9895bbfb[_0x70f970a9] = _0xe0d3417c;
        }

        int _0x1495bb73 = 0;
        for (int _0x2b55244a = 0; _0x2b55244a < _0x9895bbfb.Count && _0x1495bb73 < _0xb0b47881; _0x2b55244a++)
        {
            int _0xc78460e9 = _0x9895bbfb[_0x2b55244a];
            _0x80f9d849 _0x1528dff0 = _0xd75de67c.Ledges[_0xc78460e9 - 1];
            _0x80f9d849 _0xfc6b99a5 = _0xd75de67c.Ledges[_0xc78460e9];
            _0x1d616098 _0x36064f12 = new _0x1d616098();
            _0x36064f12.IsFan = _0x1495bb73 >= _0x853009a8.Shutters;
            _0x36064f12.Centre = new Vector2(_0x9422dea6.NextRange(_0x8b7e13e8, -1.15f, 1.15f), Mathf.Lerp(_0x1528dff0.Centre.y, _0xfc6b99a5.Centre.y, 0.55f));
            _0x36064f12.Phase = _0x9422dea6.NextRange(_0x8b7e13e8, 0f, 6.2831f);
            _0x36064f12.Direction = _0x8b7e13e8.Next(0, 2) == 0 ? -1f : 1f;
            _0xd75de67c.Hazards.Add(_0x36064f12);
            _0x1495bb73++;
        }
    }

    public const float MaxAngleDeg = 155f;
    public static bool IsClimbable(_0x4ac7f1cc _0x913509cc)
    {
        if (_0x913509cc == null || _0x913509cc.Ledges.Count < 2)
        {
            return false;
        }

        for (int _0xda753faf = 1; _0xda753faf < _0x913509cc.Ledges.Count; _0xda753faf++)
        {
            Vector2 _0x33e4237c = _0x913509cc.Ledges[_0xda753faf - 1].Centre;
            Vector2 _0x986522cb = _0x913509cc.Ledges[_0xda753faf].Centre;
            if (!_0x9422dea6.Reachable(_0x986522cb.x - _0x33e4237c.x, _0x986522cb.y - _0x33e4237c.y))
            {
                return false;
            }
        }

        Vector2 _0x76137046 = _0x913509cc.Ledges[_0x913509cc.Ledges.Count - 1].Centre;
        return _0x9422dea6.Reachable(_0x913509cc.Beacon.x - _0x76137046.x, _0x913509cc.Beacon.y - _0x76137046.y);
    }

    public static _0x4ac7f1cc Build(int _0x61fd68b1, int _0xdc940b5d)
    {
        _0x2b6114b1 _0xea96c672 = _0xe6c2d6f3.Row(_0x61fd68b1);
        int _0xc25dadd0 = _0x9422dea6.SeedFor(_0x61fd68b1, _0xdc940b5d);
        {
#if B_LOGS
            {
                Debug.Log($"[shaft] sector={_0x61fd68b1} attempt={_0xdc940b5d} seed={_0xc25dadd0}");
            }
#endif
        }

        for (int _0x16667693 = 0; _0x16667693 < 20; _0x16667693++)
        {
            System.Random _0x8698cdea = new System.Random(_0xc25dadd0 + (_0x16667693 * 7717));
            _0x4ac7f1cc _0xfc474029 = _0x9422dea6.Draw(_0xea96c672, _0x8698cdea);
            if (_0x9422dea6.IsClimbable(_0xfc474029))
            {
                return _0xfc474029;
            }
        }

        _0x4ac7f1cc _0x46cdc709 = _0x9422dea6.Fallback(_0xea96c672);
        _0x46cdc709.UsedFallback = true;
        {
#if B_LOGS
            {
                Debug.Log($"[shaft] fallback layout used for sector={_0x61fd68b1}");
            }
#endif
        }

        return _0x46cdc709;
    }

    // Both roots of the ballistic solution have to sit inside the arrow's sweep, with
    // eight per cent of head-room rather than "just barely".
    public static bool Reachable(float _0x5e063c0b, float _0x1ae029fe)
    {
        float _0x5fff73bc = Mathf.Abs(_0x5e063c0b);
        float _0x7cba90dc = LaunchSpeed * LaunchSpeed;
        float _0xdaca836c = _0x7cba90dc * _0x7cba90dc;
        float _0x653964c3 = _0xdaca836c - (Gravity * ((Gravity * _0x5fff73bc * _0x5fff73bc) + (2f * _0x1ae029fe * _0x7cba90dc)));
        if (_0x653964c3 < ReachMargin * _0xdaca836c)
        {
            return false;
        }

        float _0x0eaf9b5c = Gravity * _0x5fff73bc;
        if (_0x0eaf9b5c < 0.0001f)
        {
            return _0x1ae029fe > 0f;
        }

        float _0xce91b0ba = Mathf.Sqrt(_0x653964c3);
        float _0x5bc26ddc = Mathf.Atan((_0x7cba90dc + _0xce91b0ba) / _0x0eaf9b5c) * Mathf.Rad2Deg;
        float _0x2e3c9b0c = Mathf.Atan((_0x7cba90dc - _0xce91b0ba) / _0x0eaf9b5c) * Mathf.Rad2Deg;
        return _0x5bc26ddc >= MinAngleDeg && _0x5bc26ddc <= MaxAngleDeg && _0x2e3c9b0c >= MinAngleDeg && _0x2e3c9b0c <= MaxAngleDeg;
    }
}