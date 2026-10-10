using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x4dab5e2e : MonoBehaviour
{
    private static _0x4dab5e2e _0xb0e2bcbf;
    private bool _0x92a147be(Touch? _0xb0f1f4b2)
    {
        if (!_0xb0f1f4b2.HasValue)
            return false;
        Vector3 _0x3aa685f1 = Camera.main.ScreenToWorldPoint(_0xb0f1f4b2.Value.screenPosition);
        Vector3 _0xd74a8ea9 = _0x3aa685f1;
        _0xd74a8ea9.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xd74a8ea9))
            return true;
        _0xb0f1f4b2 = null;
        return false;
    }

    private Touch? _0x1213c433(Bounds _0x47d1f462)
    {
        if (!_0xcefca5e5.Instance._0x67283b03)
            return null;
        foreach (Touch _0x0b3798ee in Touch.activeTouches)
            if (!_0x0b3798ee.ended)
            {
                Vector3 _0xd023ad38 = Camera.main.ScreenToWorldPoint(_0x0b3798ee.screenPosition);
                Vector3 _0x84751dd6 = new(_0xd023ad38.x, _0xd023ad38.y, _0x47d1f462.center.z);
                if (_0x47d1f462.Contains(_0x84751dd6) && this._0x92a147be(_0x0b3798ee))
                    return _0x0b3798ee;
            }

        return null;
    }

    public BoxCollider2D CameraTouchBounds;
    private Touch? _0xf721c106()
    {
        if (!_0xcefca5e5.Instance._0x67283b03)
            return null;
        foreach (Touch _0xf92ba824 in Touch.activeTouches)
            if (_0xf92ba824.ended)
                if (this._0x92a147be(_0xf92ba824))
                    return _0xf92ba824;
        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0xb0e2bcbf = this.gameObject.GetComponent<_0x4dab5e2e>();
    }

    private bool _0x5b0218d7(Touch? _0xfade17a2, Bounds _0xddf6c930, TouchPhase _0xe0346bbb)
    {
        if (!_0xcefca5e5.Instance._0x67283b03)
        {
            _0xfade17a2 = null;
            return false;
        }

        if (_0xfade17a2 != null)
            if (_0xfade17a2.Value.phase == _0xe0346bbb)
            {
                Vector3 _0x66c82450 = Camera.main.ScreenToWorldPoint(_0xfade17a2.Value.screenPosition);
                Vector3 _0xb4d9900a = new(_0x66c82450.x, _0x66c82450.y, _0xddf6c930.center.z);
                if (_0xddf6c930.Contains(_0xb4d9900a) && this._0x92a147be(_0xfade17a2.Value))
                    return true;
            }

        return false;
    }

    private Touch? _0x9ae2b27b()
    {
        if (!_0xcefca5e5.Instance._0x67283b03)
            return null;
        foreach (Touch _0x6dc6205a in Touch.activeTouches)
            if (!_0x6dc6205a.ended)
                if (this._0x92a147be(_0x6dc6205a))
                    return _0x6dc6205a;
        return null;
    }

    private void _0x4f1e9245(Touch? _0x2afad3bd)
    {
        if (!_0xcefca5e5.Instance._0x67283b03)
        {
            _0x2afad3bd = null;
            return;
        }

        int _0x9e145ca3 = _0x2afad3bd.Value.touchId;
        _0x2afad3bd = Touch.activeTouches.FirstOrDefault(_0x29415307 => _0x29415307.touchId == _0x9e145ca3);
        if (!this._0x92a147be(_0x2afad3bd.Value))
            _0x2afad3bd = null;
    }

    private Touch? _0x5ab30959(Bounds _0x59007f1e, TouchPhase _0x3a574ba1)
    {
        if (!_0xcefca5e5.Instance._0x67283b03)
            return null;
        foreach (Touch _0x30eb96a7 in Touch.activeTouches)
            if (_0x30eb96a7.phase == _0x3a574ba1)
            {
                Vector3 _0x51b1db30 = Camera.main.ScreenToWorldPoint(_0x30eb96a7.screenPosition);
                Vector3 _0xc35eaa9a = new(_0x51b1db30.x, _0x51b1db30.y, _0x59007f1e.center.z);
                if (_0x59007f1e.Contains(_0xc35eaa9a) && this._0x92a147be(_0x30eb96a7))
                    return _0x30eb96a7;
            }

        return null;
    }

    private Touch? _0x2f2ac493(Bounds _0xa4996398)
    {
        if (!_0xcefca5e5.Instance._0x67283b03)
            return null;
        foreach (Touch _0x834fe981 in Touch.activeTouches)
            if (_0x834fe981.ended)
            {
                Vector3 _0x0f5bf603 = Camera.main.ScreenToWorldPoint(_0x834fe981.screenPosition);
                Vector3 _0x1c34da4a = new(_0x0f5bf603.x, _0x0f5bf603.y, _0xa4996398.center.z);
                if (_0xa4996398.Contains(_0x1c34da4a) && this._0x92a147be(_0x834fe981))
                    return _0x834fe981;
            }

        return null;
    }
}