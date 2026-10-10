using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum _0x36461a36
{
    Aiming,
    Flight,
    Dropping,
    Rescuing,
    Cleared,
    Ended,
    Held,
}

// The climb itself: world build, round clock, ascent field, result cards.
public sealed class _0x7ee8ca42 : MonoBehaviour
{
    // ---- result cards ------------------------------------------------------
    private void _0xbec19701(bool _0xa2fd75c9, bool _0x029a00c9)
    {
        if (this._0x1b9f4a9c)
        {
            return;
        }

        this._0x1b9f4a9c = true;
        this._0xe6a4fe8a = _0xa2fd75c9 ? _0x36461a36.Cleared : _0x36461a36.Ended;
        if (this._0x4ec49df1 != null)
        {
            this._0x4ec49df1._0xdd72f2d7(false);
        }

        int _0xd0b25be7 = _0xa2fd75c9 ? this._0xf56aa51a._0xf5383d4c : this._0x007f010d;
        _0x69baa7e4.StoreBest(this._0x0dbee6fb, _0xd0b25be7);
        if (_0xa2fd75c9)
        {
            _0x69baa7e4.Unlock(this._0x0dbee6fb);
        }

        int _0x8938042a = Mathf.Max(0, Mathf.CeilToInt(this._0xf56aa51a.RoundSeconds - this._0x94adb4ff));
        string _0x14838d43 = _0x31a38939._0x68c1e15b(new byte[5] { 74, 87, 83, 91, 62 }, 30) + (_0x8938042a / 60).ToString(_0x31a38939._0x68c1e15b(new byte[2] { 198, 198 }, 246)) + _0x31a38939._0x68c1e15b(new byte[1] { 59 }, 1) + (_0x8938042a % 60).ToString(_0x31a38939._0x68c1e15b(new byte[2] { 64, 64 }, 112));
        if (_0xa2fd75c9)
        {
            _0x8e511e3c _0xa895f9c4 = _0xc1414747.Instance._0x0a70eb9c(_0x682bf997._0x6a7890bf.WIN);
            RectTransform _0xacc36768 = this._popDresser._0x01567c65(_0xa895f9c4, _0x682bf997._0x6a7890bf.WIN);
            if (_0xacc36768 == null)
            {
                this._0x253d349f();
                return;
            }

            this._popDresser._0xa5da216b(_0xacc36768, _0x31a38939._0x68c1e15b(new byte[10] { 11, 12, 8, 10, 6, 7, 105, 5, 0, 29 }, 73), _0x31a38939._0x68c1e15b(new byte[7] { 92, 74, 76, 91, 64, 93, 47 }, 15) + (this._0x0dbee6fb + 1).ToString() + _0x31a38939._0x68c1e15b(new byte[8] { 212, 183, 184, 177, 181, 166, 177, 176 }, 244), _0x31a38939._0x68c1e15b(new byte[9] { 251, 246, 238, 243, 238, 239, 254, 255, 154 }, 186) + _0xd0b25be7.ToString() + _0x31a38939._0x68c1e15b(new byte[3] { 66, 47, 104 }, 98) + _0x14838d43 + _0x31a38939._0x68c1e15b(new byte[7] { 32, 108, 107, 102, 102, 121, 10 }, 42) + (MaxCharges - this._0x4718db30).ToString());
            Button _0xd207be25 = this._popDresser._0x36059deb(_0xacc36768);
            _0xd207be25.onClick.AddListener(() => this._0x253d349f());
            Button _0xa93612b9 = this._popDresser._0xe0dafa0b(_0xacc36768, 0, _0x31a38939._0x68c1e15b(new byte[11] { 77, 70, 91, 87, 35, 80, 70, 64, 87, 76, 81 }, 3), _0xf18456f5.Accent);
            _0xa93612b9.onClick.AddListener(() => this._0x42fa63b9());
            Button _0x5116c228 = this._popDresser._0xe0dafa0b(_0xacc36768, 1, _0x31a38939._0x68c1e15b(new byte[6] { 240, 231, 242, 238, 227, 251 }, 162), _0xf18456f5.Gold);
            _0x5116c228.onClick.AddListener(() => this._0xc8ee33b1());
            Button _0x688d18e3 = this._popDresser._0xe0dafa0b(_0xacc36768, 2, _0x31a38939._0x68c1e15b(new byte[4] { 99, 107, 96, 123 }, 46), _0xf18456f5.Violet);
            _0x688d18e3.onClick.AddListener(() => this._0x253d349f());
            DOVirtual.DelayedCall(1.1f, () => _0xc1414747.Instance._0x40f6426c(_0x682bf997._0x6a7890bf.WIN)).SetLink(this.gameObject);
            return;
        }

        _0x8e511e3c _0x7aff8617 = _0xc1414747.Instance._0x0a70eb9c(_0x682bf997._0x6a7890bf.LOSE);
        RectTransform _0x0e5f00e1 = this._popDresser._0x01567c65(_0x7aff8617, _0x682bf997._0x6a7890bf.LOSE);
        if (_0x0e5f00e1 == null)
        {
            this._0x253d349f();
            return;
        }

        this._popDresser._0xa5da216b(_0x0e5f00e1, _0x029a00c9 ? _0x31a38939._0x68c1e15b(new byte[10] { 119, 120, 116, 125, 117, 17, 117, 126, 102, 127 }, 49) : _0x31a38939._0x68c1e15b(new byte[9] { 203, 199, 218, 205, 168, 196, 199, 219, 220 }, 136), _0x31a38939._0x68c1e15b(new byte[8] { 134, 145, 149, 151, 156, 145, 144, 244 }, 212) + _0xd0b25be7.ToString() + _0x31a38939._0x68c1e15b(new byte[6] { 230, 139, 230, 137, 128, 230 }, 198) + this._0xf56aa51a._0xf5383d4c.ToString() + _0x31a38939._0x68c1e15b(new byte[2] { 122, 23 }, 90), _0x31a38939._0x68c1e15b(new byte[9] { 107, 102, 126, 99, 126, 127, 110, 111, 10 }, 42) + _0xd0b25be7.ToString() + _0x31a38939._0x68c1e15b(new byte[3] { 153, 244, 179 }, 185) + _0x14838d43 + _0x31a38939._0x68c1e15b(new byte[6] { 72, 0, 7, 17, 22, 98 }, 66) + _0x69baa7e4.BestFor(this._0x0dbee6fb).ToString() + _0x31a38939._0x68c1e15b(new byte[2] { 241, 156 }, 209));
        Button _0xac7dfa65 = this._popDresser._0x36059deb(_0x0e5f00e1);
        _0xac7dfa65.onClick.AddListener(() => this._0x253d349f());
        Button _0x92befddb = this._popDresser._0xe0dafa0b(_0x0e5f00e1, 0, _0x31a38939._0x68c1e15b(new byte[5] { 210, 197, 212, 210, 217 }, 128), _0xf18456f5.Accent);
        _0x92befddb.onClick.AddListener(() => this._0xc8ee33b1());
        Button _0x6a91e5b9 = this._popDresser._0xe0dafa0b(_0x0e5f00e1, 1, _0x31a38939._0x68c1e15b(new byte[4] { 51, 59, 48, 43 }, 126), _0xf18456f5.Violet);
        _0x6a91e5b9.onClick.AddListener(() => this._0x253d349f());
        DOVirtual.DelayedCall(0.8f, () => _0xc1414747.Instance._0x40f6426c(_0x682bf997._0x6a7890bf.LOSE)).SetLink(this.gameObject);
    }

    // ---- world -------------------------------------------------------------
    private void _0xe70306a9()
    {
        GameObject _0xaf4eaa48 = new GameObject(_0x31a38939._0x68c1e15b(new byte[5] { 122, 65, 72, 79, 93 }, 41));
        this._0x3df3649f = _0xaf4eaa48.transform;
        this._0x3df3649f.SetParent(this.transform, false);
        this._0x3df3649f.localPosition = Vector3.zero;
        this._0x3df3649f.localScale = Vector3.one;
        Transform _0x47b8c2d6 = null;
        if (this._shaftBackPrefab != null)
        {
            GameObject _0x54369c15 = Instantiate(this._shaftBackPrefab, this._0x3df3649f);
            _0x54369c15.transform.localScale = Vector3.one;
            _0x47b8c2d6 = _0x54369c15.transform;
        }

        Transform[] _0x53faae47 = new Transform[RingCount];
        if (this._shaftRingPrefab != null)
        {
            for (int _0x655c0067 = 0; _0x655c0067 < RingCount; _0x655c0067++)
            {
                GameObject _0x3fed9504 = Instantiate(this._shaftRingPrefab, this._0x3df3649f);
                _0x3fed9504.transform.localScale = Vector3.one;
                SpriteRenderer _0x3475eea8 = _0x3fed9504.GetComponent<SpriteRenderer>();
                if (_0x3475eea8 != null)
                {
                    _0x3475eea8.color = _0xf18456f5.Alpha(_0xf18456f5.Violet, 0.5f);
                }

                _0x53faae47[_0x655c0067] = _0x3fed9504.transform;
            }
        }

        if (this._shaftWallPrefab != null)
        {
            for (int _0x88104381 = -1; _0x88104381 <= 1; _0x88104381 += 2)
            {
                GameObject _0xedc17bff = Instantiate(this._shaftWallPrefab, this._0x3df3649f);
                _0xedc17bff.transform.localScale = Vector3.one;
                _0xedc17bff.transform.position = new Vector3(_0x88104381 * 2.16f, 0f, 0.4f);
                SpriteRenderer _0x85e48c69 = _0xedc17bff.GetComponent<SpriteRenderer>();
                if (_0x85e48c69 != null)
                {
                    _0x85e48c69.color = _0xf18456f5.Alpha(_0xf18456f5.Accent, 0.55f);
                }
            }
        }

        for (int _0xe41ff932 = 0; _0xe41ff932 < this._0xf5158278.Ledges.Count; _0xe41ff932++)
        {
            _0x80f9d849 _0x46d180c9 = this._0xf5158278.Ledges[_0xe41ff932];
            GameObject _0x05b43971 = _0x46d180c9.IsAnchor ? this._anchorPrefab : this._ledgePrefab;
            if (_0x05b43971 == null)
            {
                continue;
            }

            GameObject _0xd261a095 = Instantiate(_0x05b43971, this._0x3df3649f);
            _0xd261a095.transform.localScale = Vector3.one;
            _0xd261a095.transform.position = new Vector3(_0x46d180c9.Centre.x, _0x46d180c9.Centre.y, 0f);
            _0x03ed51b5 _0xb1e9c2cd = _0xd261a095.GetComponent<_0x03ed51b5>();
            if (_0xb1e9c2cd != null)
            {
                _0xb1e9c2cd._0x37b24914(_0x46d180c9.HalfWidth);
            }

            this._0xefecaf00.Add(_0xb1e9c2cd);
        }

        for (int _0x446a7812 = 0; _0x446a7812 < this._0xf5158278.Hazards.Count; _0x446a7812++)
        {
            _0x1d616098 _0x3eecab0e = this._0xf5158278.Hazards[_0x446a7812];
            GameObject _0x79a6cc2d = _0x3eecab0e.IsFan ? this._fanPrefab : this._shutterPrefab;
            if (_0x79a6cc2d == null)
            {
                continue;
            }

            GameObject _0x62f0ec77 = Instantiate(_0x79a6cc2d, this._0x3df3649f);
            _0x62f0ec77.transform.localScale = Vector3.one;
            _0x62f0ec77.transform.position = new Vector3(_0x3eecab0e.Centre.x, _0x3eecab0e.Centre.y, 0f);
            if (_0x3eecab0e.IsFan)
            {
                _0x6dfee5b0 _0x37a9e740 = _0x62f0ec77.GetComponent<_0x6dfee5b0>();
                if (_0x37a9e740 != null)
                {
                    _0x37a9e740._0xcea174a2(_0x3eecab0e.Direction);
                    this._0x11e5d249.Add(_0x37a9e740);
                }
            }
            else
            {
                _0xf589fabc _0xbd86e649 = _0x62f0ec77.GetComponent<_0xf589fabc>();
                if (_0xbd86e649 != null)
                {
                    _0xbd86e649._0x99c5ee39(_0x3eecab0e.Phase, _0x3eecab0e.Direction);
                    this._0x8947fca5.Add(_0xbd86e649);
                }
            }
        }

        if (this._beaconPrefab != null)
        {
            GameObject _0xb9cc2fb2 = Instantiate(this._beaconPrefab, this._0x3df3649f);
            _0xb9cc2fb2.transform.localScale = Vector3.one;
            _0xb9cc2fb2.transform.position = new Vector3(this._0xf5158278.Beacon.x, this._0xf5158278.Beacon.y, 0f);
            SpriteRenderer _0xc2ed2af1 = _0xb9cc2fb2.GetComponent<SpriteRenderer>();
            if (_0xc2ed2af1 != null)
            {
                _0xc2ed2af1.color = _0xf18456f5.Gold;
            }

            this._0x86145f69 = _0xb9cc2fb2.transform;
        }

        if (this._corePrefab != null)
        {
            GameObject _0xff3eb1a9 = Instantiate(this._corePrefab, this._0x3df3649f);
            _0xff3eb1a9.transform.localScale = Vector3.one;
            this._0x00ad6514 = _0xff3eb1a9.AddComponent<_0x577cbad8>();
            SpriteRenderer _0xf357d5b9 = null;
            if (this._brakeRingPrefab != null)
            {
                GameObject _0x70fe95fe = Instantiate(this._brakeRingPrefab, _0xff3eb1a9.transform);
                _0x70fe95fe.transform.localScale = Vector3.one;
                _0x70fe95fe.transform.localPosition = Vector3.zero;
                _0xf357d5b9 = _0x70fe95fe.GetComponent<SpriteRenderer>();
            }

            this._0x00ad6514._0x09839f40(_0xff3eb1a9.GetComponent<SpriteRenderer>(), _0xf357d5b9);
        }

        if (this._aimPrefab != null)
        {
            GameObject _0x52643f8a = Instantiate(this._aimPrefab, this._0x3df3649f);
            _0x52643f8a.transform.localScale = Vector3.one;
            this._0x4ec49df1 = _0x52643f8a.GetComponent<_0x7a394be8>();
        }

        if (this._sparkPrefab != null)
        {
            for (int _0x9007e183 = 0; _0x9007e183 < 8; _0x9007e183++)
            {
                GameObject _0x8c784dd1 = Instantiate(this._sparkPrefab, this._0x3df3649f);
                _0x8c784dd1.transform.localScale = Vector3.one;
                SpriteRenderer _0x1e1c5b14 = _0x8c784dd1.GetComponent<SpriteRenderer>();
                if (_0x1e1c5b14 != null)
                {
                    _0x1e1c5b14.color = _0xf18456f5.Alpha(_0xf18456f5.Accent, 0f);
                }

                this._0xaffbb1a8.Add(_0x1e1c5b14);
            }
        }

        if (this._cameraRig != null)
        {
            this._cameraRig._0x840499c7(Camera.main, _0x47b8c2d6, _0x53faae47, RingSpacing);
            float _0xa0234f09 = this._0xf5158278.Ledges[0].Centre.y + 2.2f;
            this._cameraRig._0xb19b389a(_0xa0234f09, this._0xf5158278.Beacon.y);
            this._cameraRig._0xe54d4180(_0xa0234f09);
        }
    }

    private void _0x6f242b31(int _0xf7fdda86)
    {
        _0x03ed51b5 _0x89af933c = this._0xefecaf00[_0xf7fdda86];
        this._0x00ad6514._0x9e1e3e69();
        this._0x00ad6514._0x31e4f1e0(new Vector2(this._0x00ad6514._0x635a179a.x, _0x89af933c._0x4938eaf6 + _0x577cbad8.Radius));
        _0x89af933c._0xe10d84cf();
        this._0x4b41f78a = _0xf7fdda86;
        if (_0xf7fdda86 > this._0xe75434bb)
        {
            this._0xe75434bb = _0xf7fdda86;
            if (this._hud != null)
            {
                this._hud._0x421ec28d(this._0x007f010d, this._0xf56aa51a._0xf5383d4c);
                this._hud._0xe77ae458();
            }
        }

        if (_0x89af933c._0x04a04db4)
        {
            this._0x0fe125bc = _0xf7fdda86;
            _0x89af933c._0x32c41849();
            if (this._0x4718db30 < MaxCharges)
            {
                this._0x4718db30++;
                if (this._pipColumn != null)
                {
                    this._pipColumn._0x08718919(this._0x4718db30);
                }
            }
        }

        this._0x67b8192e(_0xf7fdda86);
    }

    private _0x7a394be8 _0x4ec49df1;
    private readonly List<_0x6dfee5b0> _0x11e5d249 = new List<_0x6dfee5b0>();
    [SerializeField]
    private GameObject _anchorPrefab;
    public int _0x007f010d
    {
        get
        {
            return this._0xe75434bb * _0xe6c2d6f3.MetresPerLedge;
        }
    }

    private int _0x79a3ef1a(Vector2 _0xe5327965)
    {
        for (int _0x0876ef3e = 0; _0x0876ef3e < this._0xefecaf00.Count; _0x0876ef3e++)
        {
            _0x03ed51b5 _0xd8b1b163 = this._0xefecaf00[_0x0876ef3e];
            if (_0xd8b1b163 == null)
            {
                continue;
            }

            float _0x21accdc9 = _0xd8b1b163._0x4938eaf6;
            if (_0xe5327965.y - _0x577cbad8.Radius > _0x21accdc9 || _0xe5327965.y - _0x577cbad8.Radius < _0x21accdc9 - 0.34f)
            {
                continue;
            }

            float _0x5f734a39 = Mathf.Abs(_0xe5327965.x - _0xd8b1b163.transform.position.x);
            if (_0x5f734a39 <= _0xd8b1b163._0x194ad11e + LandingSlack)
            {
                return _0x0876ef3e;
            }
        }

        return -1;
    }

    private void _0xc8ee33b1()
    {
        _0xc1414747.Instance._0x3b9ea76e();
        _0xcefca5e5.Instance._0x19693c4d(true);
        _0xcefca5e5.Instance._0x1484c85c(_0x682bf997._0x03d597f1.SCENE_1);
    }

    [SerializeField]
    private GameObject _aimPrefab;
    [SerializeField]
    private Sprite _pauseIcon;
    private _0x2b6114b1 _0xf56aa51a;
    // ---- hud ---------------------------------------------------------------
    private void _0x5477de60()
    {
        _0x706c786a _0x15d68030 = _0x42b5233b.Instance.Panels[_0x682bf997._0x29641b38.DEFAULT];
        if (_0x15d68030 == null || _0x15d68030.Content == null)
        {
            return;
        }

        Transform _0xdfe086f8 = _0x15d68030.Content.transform;
        for (int _0x96778f93 = _0xdfe086f8.childCount - 1; _0x96778f93 >= 0; _0x96778f93--)
        {
            Transform _0x67ea00ce = _0xdfe086f8.GetChild(_0x96778f93);
            if (_0x67ea00ce.GetComponentInChildren<_0x8e511e3c>(true) != null)
            {
                continue;
            }

            _0x67ea00ce.gameObject.SetActive(false);
        }

        this._0x8f5406c4 = _0x341165e8.Stretch(_0xdfe086f8, _0x31a38939._0x68c1e15b(new byte[10] { 12, 43, 48, 22, 43, 58, 12, 49, 49, 42 }, 94));
        Image _0x0a496463 = _0x341165e8.StretchPlate(this._0x8f5406c4, _0x31a38939._0x68c1e15b(new byte[7] { 156, 169, 184, 146, 167, 166, 173 }, 200), new Color(1f, 1f, 1f, 0.004f));
        _0x05079967 _0x7bddb9b8 = _0x0a496463.gameObject.AddComponent<_0x05079967>();
        _0x7bddb9b8._0x49bfe48d(_0x0a496463, () => this._0x0b45aeae(), () => this._0x6f85a49f());
        if (this._hud != null)
        {
            this._hud._0x377d335d(this._0x8f5406c4, this._font, this._roundPlate, this._0xf56aa51a._0xf5383d4c);
        }

        if (this._pipColumn != null)
        {
            this._pipColumn._0xb7f1d900(this._0x8f5406c4, this._chargePip, this._font, MaxCharges);
            this._pipColumn._0x08718919(this._0x4718db30);
        }

        if (this._hint != null)
        {
            this._hint._0xd04beedb(this._0x8f5406c4, this._font, this._roundPlate);
        }

        Button _0xd971f91c = _0x341165e8.IconCta(this._0x8f5406c4, _0x31a38939._0x68c1e15b(new byte[10] { 17, 50, 48, 56, 17, 38, 39, 39, 60, 61 }, 83), this._backIcon, new Vector2(0.122f, 0.943f), Vector2.zero, new Vector2(112f, 112f), _0xf18456f5.Alpha(_0xf18456f5.Ink, 0.95f), _0xf18456f5.Alpha(_0xf18456f5.Accent, 0.9f), this._roundPlate);
        _0xd971f91c.onClick.AddListener(() => this._0x253d349f());
        Button _0x55aac2a7 = _0x341165e8.IconCta(this._0x8f5406c4, _0x31a38939._0x68c1e15b(new byte[11] { 28, 45, 57, 63, 41, 14, 57, 56, 56, 35, 34 }, 76), this._pauseIcon, new Vector2(0.878f, 0.943f), Vector2.zero, new Vector2(112f, 112f), _0xf18456f5.Alpha(_0xf18456f5.Ink, 0.95f), _0xf18456f5.Alpha(_0xf18456f5.Violet, 0.9f), this._roundPlate);
        _0x55aac2a7.onClick.AddListener(() => this._0x94f97c20());
        if (this._popDresser != null)
        {
            this._popDresser._0x28685f10(this._closeIcon, this._roundPlate, this._font);
        }
    }

    private void _0x67b8192e(int _0xfb469bb0)
    {
        this._0xe6a4fe8a = _0x36461a36.Aiming;
        if (this._0x00ad6514 != null && this._0xefecaf00.Count > _0xfb469bb0 && this._0xefecaf00[_0xfb469bb0] != null)
        {
            _0x03ed51b5 _0x827f9755 = this._0xefecaf00[_0xfb469bb0];
            this._0x00ad6514._0x31e4f1e0(new Vector2(_0x827f9755.transform.position.x, _0x827f9755._0x4938eaf6 + _0x577cbad8.Radius));
        }

        if (this._0x4ec49df1 != null)
        {
            this._0x4ec49df1._0xdd72f2d7(true);
            this._0x4ec49df1._0xc596e1a3(_0x7a394be8.LowAngle + ((_0xfb469bb0 * 37f) % (_0x7a394be8.HighAngle - _0x7a394be8.LowAngle)));
        }
    }

    private const float RespawnSeconds = 0.45f;
    private readonly List<SpriteRenderer> _0xaffbb1a8 = new List<SpriteRenderer>();
    private float _0x2db94022;
    [SerializeField]
    private Sprite _roundPlate;
    private void _0xdb9c0b77(float delta)
    {
        if (this._0xaffbb1a8.Count == 0)
        {
            return;
        }

        this._0x2db94022 -= delta;
        if (this._0x2db94022 > 0f)
        {
            return;
        }

        this._0x2db94022 = 0.08f;
        SpriteRenderer _0xb020d7ec = this._0xaffbb1a8[this._0x53493799 % this._0xaffbb1a8.Count];
        this._0x53493799++;
        if (_0xb020d7ec == null)
        {
            return;
        }

        _0xb020d7ec.transform.position = this._0x00ad6514._0x635a179a;
        _0xb020d7ec.size = new Vector2(0.18f, 0.18f);
        DOTween.Kill(_0xb020d7ec, true);
        _0xb020d7ec.color = _0xf18456f5.Alpha(_0xf18456f5.Accent, 0.85f);
        _0xb020d7ec.DOFade(0f, 0.35f).SetLink(_0xb020d7ec.gameObject);
    }

    // ---- round loop --------------------------------------------------------
    private void Update()
    {
        if (this._0x1b9f4a9c || _0xcefca5e5.Instance == null)
        {
            return;
        }

        if (!_0xcefca5e5.Instance._0x67283b03)
        {
            this._0x21db450d();
            return;
        }

        float delta = Time.deltaTime;
        this._0x89021e15 += delta;
        this._0x94adb4ff -= delta;
        if (this._hud != null)
        {
            this._hud._0x6d415f1c(this._0x94adb4ff);
            this._hud._0x3f731ae8(1f - Mathf.Clamp01(this._0x89021e15 / AscentWindowSeconds));
            this._hud._0x6571a259(delta);
        }

        if (this._hint != null)
        {
            this._hint._0x1a18e5cd(delta);
        }

        for (int _0x9da6a516 = 0; _0x9da6a516 < this._0x8947fca5.Count; _0x9da6a516++)
        {
            this._0x8947fca5[_0x9da6a516]._0x0997790f(delta);
        }

        for (int _0x5f503481 = 0; _0x5f503481 < this._0x11e5d249.Count; _0x5f503481++)
        {
            this._0x11e5d249[_0x5f503481]._0x58c3d7a7(delta);
        }

        if (this._0x94adb4ff <= 0f)
        {
            this._0xbec19701(false, true);
            return;
        }

        switch (this._0xe6a4fe8a)
        {
            case _0x36461a36.Aiming:
                this._0x822b94ba(delta);
                break;
            case _0x36461a36.Flight:
                this._0xb1d4b94d(delta);
                break;
            case _0x36461a36.Dropping:
            case _0x36461a36.Rescuing:
                this._0xe934c3b1(delta);
                break;
        }
    }

    private void _0x253d349f()
    {
        _0xc1414747.Instance._0x3b9ea76e();
        _0xcefca5e5.Instance._0x19693c4d(true);
        _0xcefca5e5.Instance._0x1484c85c(_0x682bf997._0x03d597f1.SCENE_0);
    }

    private Transform _0x86145f69;
    [SerializeField]
    private GameObject _fanPrefab;
    private readonly List<_0x03ed51b5> _0xefecaf00 = new List<_0x03ed51b5>();
    private float _0xe930f162;
    [SerializeField]
    private _0x27985489 _popDresser;
    private int _0x0fe125bc;
    private const float LandingSlack = 0.10f;
    private void _0xe934c3b1(float delta)
    {
        this._0xe930f162 -= delta;
        _0x03ed51b5 _0xde8fdfa3 = this._0xefecaf00.Count > this._0x0fe125bc ? this._0xefecaf00[this._0x0fe125bc] : null;
        if (this._0xe6a4fe8a == _0x36461a36.Dropping && this._0x00ad6514 != null)
        {
            this._0x00ad6514._0x9bbc626a(delta, 0f);
            // Stay on the falling core, not on the anchor: parking the camera on a perch
            // the core has already left leaves an empty shaft on screen and the round
            // reads as frozen (the fall is the only feedback a missed jump gives).
            if (this._cameraRig != null)
            {
                this._cameraRig._0x4b33501a(this._0x00ad6514._0x635a179a.y + 1.1f, delta);
            }
        }
        else if (_0xde8fdfa3 != null && this._cameraRig != null)
        {
            this._cameraRig._0x4b33501a(_0xde8fdfa3._0x4938eaf6 + 1.1f, delta);
        }

        if (this._0xe930f162 > 0f)
        {
            return;
        }

        if (this._0xe6a4fe8a == _0x36461a36.Dropping)
        {
            this._0xe6a4fe8a = _0x36461a36.Rescuing;
            this._0xe930f162 = RespawnSeconds;
            if (_0xde8fdfa3 != null && this._0x00ad6514 != null)
            {
                this._0x00ad6514._0x9e1e3e69();
                this._0x00ad6514._0x31e4f1e0(new Vector2(_0xde8fdfa3.transform.position.x, _0xde8fdfa3._0x4938eaf6 + _0x577cbad8.Radius));
                _0xde8fdfa3._0x32c41849();
            }

            return;
        }

        this._0x67b8192e(this._0x0fe125bc);
    }

    private void _0x0b45aeae()
    {
        if (this._0xe6a4fe8a != _0x36461a36.Aiming || this._0x00ad6514 == null || this._0x4ec49df1 == null)
        {
            return;
        }

        if (_0xcefca5e5.Instance == null || !_0xcefca5e5.Instance._0x67283b03)
        {
            return;
        }

        this._0xe6a4fe8a = _0x36461a36.Flight;
        this._0x4ec49df1._0xdd72f2d7(false);
        this._0x00ad6514._0xf9a007ea(this._0x4ec49df1._0x83088a67);
    }

    private void _0xb193e0fd()
    {
        this._0xe6a4fe8a = _0x36461a36.Dropping;
        this._0xe930f162 = FallDescentSeconds;
        if (this._0x4ec49df1 != null)
        {
            this._0x4ec49df1._0xdd72f2d7(false);
        }

        this._0x4718db30--;
        bool _0x21a782fd = this._0x89021e15 < AscentWindowSeconds;
        bool _0xd77f5301 = this._0x4718db30 <= 0 && !_0x21a782fd;
        if (this._0x4718db30 <= 0 && _0x21a782fd)
        {
            this._0x4718db30 = 1;
            if (this._hud != null)
            {
                this._hud._0x109f48b3(_0x31a38939._0x68c1e15b(new byte[12] { 138, 157, 139, 155, 141, 157, 248, 136, 141, 148, 139, 157 }, 216));
            }
        }
        else if (!_0xd77f5301 && this._hud != null)
        {
            // A miss costs the player a perch and several seconds; say so, or the
            // recovery reads as the game having stopped responding.
            this._hud._0x109f48b3(_0x31a38939._0x68c1e15b(new byte[23] { 76, 72, 82, 82, 68, 69, 33, 44, 33, 67, 64, 66, 74, 33, 85, 78, 33, 64, 79, 66, 73, 78, 83 }, 1));
        }

        if (this._pipColumn != null)
        {
            this._pipColumn._0x08718919(Mathf.Max(0, this._0x4718db30));
        }

        if (_0xd77f5301)
        {
            this._0xbec19701(false, false);
        }
    }

    private void Start()
    {
        this._0x0dbee6fb = _0x69baa7e4._0x107c22cb;
        this._0xf56aa51a = _0xe6c2d6f3.Row(this._0x0dbee6fb);
        this._0xf5158278 = _0x9422dea6.Build(this._0x0dbee6fb, _0x69baa7e4.NextAttempt());
        this._0x94adb4ff = this._0xf56aa51a.RoundSeconds;
        this._0xe70306a9();
        this._0x5477de60();
        this._0x67b8192e(0);
        this._0xe6a4fe8a = _0x36461a36.Aiming;
    }

    private _0x4ac7f1cc _0xf5158278;
    private void _0x42fa63b9()
    {
        _0x69baa7e4._0x107c22cb = Mathf.Min(this._0x0dbee6fb + 1, _0xe6c2d6f3.Count - 1);
        this._0xc8ee33b1();
    }

    private bool _0x81d2b462;
    private const float FallDescentSeconds = 0.80f;
    private bool _0x1b9f4a9c;
    [SerializeField]
    private Sprite _backIcon;
    [SerializeField]
    private GameObject _corePrefab;
    [SerializeField]
    private Sprite _closeIcon;
    private void _0x822b94ba(float delta)
    {
        if (this._0x4ec49df1 == null || this._0x00ad6514 == null)
        {
            return;
        }

        this._0x4ec49df1._0xb61a6e44(delta, this._0x00ad6514._0x635a179a);
        if (this._cameraRig != null)
        {
            this._cameraRig._0x4b33501a(this._0x00ad6514._0x635a179a.y + 1.1f, delta);
        }
    }

    private void _0x6f85a49f()
    {
        if (this._0xe6a4fe8a != _0x36461a36.Flight || this._0x00ad6514 == null)
        {
            return;
        }

        this._0x00ad6514._0xfeb5ed50();
    }

    private int _0x4718db30 = MaxCharges;
    [SerializeField]
    private _0xe8e929b3 _hint;
    [SerializeField]
    private _0xa9ecf821 _hud;
    private _0x36461a36 _0xe6a4fe8a = _0x36461a36.Held;
    [SerializeField]
    private GameObject _shutterPrefab;
    private _0x577cbad8 _0x00ad6514;
    [SerializeField]
    private GameObject _ledgePrefab;
    private float _0x94adb4ff;
    private const int RingCount = 7;
    private float _0x89021e15;
    private void _0x94f97c20()
    {
        if (this._0x1b9f4a9c || _0xcefca5e5.Instance == null || !_0xcefca5e5.Instance._0x67283b03)
        {
            return;
        }

        _0x8e511e3c _0x40edb8e6 = _0xc1414747.Instance._0x0a70eb9c(_0x682bf997._0x6a7890bf.PAUSE);
        RectTransform _0xd30f5d1c = this._popDresser._0x01567c65(_0x40edb8e6, _0x682bf997._0x6a7890bf.PAUSE);
        if (_0xd30f5d1c == null)
        {
            return;
        }

        if (_0xd30f5d1c.childCount <= 2)
        {
            this._popDresser._0xa5da216b(_0xd30f5d1c, _0x31a38939._0x68c1e15b(new byte[4] { 2, 5, 6, 14 }, 74), _0x31a38939._0x68c1e15b(new byte[40] { 43, 62, 47, 95, 43, 48, 95, 51, 48, 60, 52, 95, 53, 42, 50, 47, 117, 59, 48, 42, 61, 51, 58, 95, 43, 62, 47, 95, 43, 48, 95, 62, 54, 45, 95, 61, 45, 62, 52, 58 }, 127), _0x31a38939._0x68c1e15b(new byte[7] { 171, 189, 187, 172, 183, 170, 216 }, 248) + (this._0x0dbee6fb + 1).ToString() + _0x31a38939._0x68c1e15b(new byte[3] { 221, 208, 221 }, 253) + this._0x007f010d.ToString() + _0x31a38939._0x68c1e15b(new byte[2] { 51, 94 }, 19));
            Button _0x833f06dd = this._popDresser._0x36059deb(_0xd30f5d1c);
            _0x833f06dd.onClick.AddListener(() => this._0xceae3c98());
            Button _0xb7f45687 = this._popDresser._0xe0dafa0b(_0xd30f5d1c, 0, _0x31a38939._0x68c1e15b(new byte[6] { 189, 170, 188, 186, 162, 170 }, 239), _0xf18456f5.Accent);
            _0xb7f45687.onClick.AddListener(() => this._0xceae3c98());
            Button _0xa428a9a7 = this._popDresser._0xe0dafa0b(_0xd30f5d1c, 1, _0x31a38939._0x68c1e15b(new byte[7] { 56, 47, 57, 62, 43, 56, 62 }, 106), _0xf18456f5.Gold);
            _0xa428a9a7.onClick.AddListener(() => this._0xc8ee33b1());
            Button _0x6cc3f5d4 = this._popDresser._0xe0dafa0b(_0xd30f5d1c, 2, _0x31a38939._0x68c1e15b(new byte[4] { 192, 200, 195, 216 }, 141), _0xf18456f5.Violet);
            _0x6cc3f5d4.onClick.AddListener(() => this._0x253d349f());
        }

        this._0xe6a4fe8a = _0x36461a36.Held;
        this._0x81d2b462 = true;
        _0xcefca5e5.Instance._0x19693c4d(false);
        _0xc1414747.Instance._0x40f6426c(_0x682bf997._0x6a7890bf.PAUSE);
    }

    private int _0xe75434bb;
    private void _0x21db450d()
    {
        if (!this._0x81d2b462)
        {
            return;
        }

        _0x8e511e3c _0xb1bcae68 = _0xc1414747.Instance._0x0a70eb9c(_0x682bf997._0x6a7890bf.PAUSE);
        if (_0xb1bcae68 == null || _0xb1bcae68.Content == null || _0xb1bcae68.Content.activeSelf)
        {
            return;
        }

        this._0x81d2b462 = false;
        _0xcefca5e5.Instance._0x19693c4d(true);
    }

    public const float AscentWindowSeconds = 64f;
    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private GameObject _brakeRingPrefab;
    private int _0x4b41f78a;
    [SerializeField]
    private GameObject _sparkPrefab;
    [SerializeField]
    private Sprite _chargePip;
    [SerializeField]
    private GameObject _shaftRingPrefab;
    private readonly List<_0xf589fabc> _0x8947fca5 = new List<_0xf589fabc>();
    private int _0x0dbee6fb;
    private RectTransform _0x8f5406c4;
    public const int MaxCharges = 3;
    [SerializeField]
    private _0x4e779dfa _pipColumn;
    [SerializeField]
    private GameObject _beaconPrefab;
    private int _0x53493799;
    [SerializeField]
    private GameObject _shaftWallPrefab;
    [SerializeField]
    private _0xd1c540ae _cameraRig;
    private void _0xceae3c98()
    {
        _0xc1414747.Instance._0x3b9ea76e();
        this._0x81d2b462 = false;
        _0xcefca5e5.Instance._0x19693c4d(true);
        this._0xe6a4fe8a = this._0x00ad6514 != null && this._0x00ad6514._0xbf49b27e ? _0x36461a36.Flight : _0x36461a36.Aiming;
    }

    private Transform _0x3df3649f;
    [SerializeField]
    private GameObject _shaftBackPrefab;
    private void _0xb1d4b94d(float delta)
    {
        if (this._0x00ad6514 == null)
        {
            return;
        }

        float _0x262ac628 = 0f;
        for (int _0xfe710202 = 0; _0xfe710202 < this._0x11e5d249.Count; _0xfe710202++)
        {
            _0x262ac628 += this._0x11e5d249[_0xfe710202]._0xf17127ea(this._0x00ad6514._0x635a179a);
        }

        this._0x00ad6514._0x9bbc626a(delta, _0x262ac628);
        this._0xdb9c0b77(delta);
        if (this._cameraRig != null)
        {
            this._cameraRig._0x4b33501a(this._0x00ad6514._0x635a179a.y + 1.1f, delta);
        }

        Vector2 _0xe2a29b78 = this._0x00ad6514._0x635a179a;
        if (this._0x86145f69 != null && Vector2.Distance(_0xe2a29b78, this._0x86145f69.position) < 0.78f)
        {
            this._0xbec19701(true, false);
            return;
        }

        for (int _0x8dec9308 = 0; _0x8dec9308 < this._0x8947fca5.Count; _0x8dec9308++)
        {
            Vector2 _0x07faaeff = this._0x8947fca5[_0x8dec9308].transform.position;
            Vector2 _0x90d7cc7f = this._0x8947fca5[_0x8dec9308]._0x574e6286;
            if (Mathf.Abs(_0xe2a29b78.x - _0x07faaeff.x) <= _0x90d7cc7f.x + _0x577cbad8.Radius && Mathf.Abs(_0xe2a29b78.y - _0x07faaeff.y) <= _0x90d7cc7f.y + _0x577cbad8.Radius)
            {
                this._0x00ad6514._0x0ff0f510();
                break;
            }
        }

        if (this._0x00ad6514._0x9582ba78.y <= 0f)
        {
            int _0xfcfafe20 = this._0x79a3ef1a(_0xe2a29b78);
            if (_0xfcfafe20 >= 0)
            {
                this._0x6f242b31(_0xfcfafe20);
                return;
            }
        }

        float _0x93b82f86 = this._0xefecaf00.Count > 0 && this._0xefecaf00[this._0x0fe125bc] != null ? this._0xefecaf00[this._0x0fe125bc]._0x4938eaf6 : _0x9422dea6.BaseY;
        if (_0xe2a29b78.y < _0x93b82f86 - 0.6f)
        {
            this._0xb193e0fd();
        }
    }

    private const float RingSpacing = 1.9f;
}

internal static class _0x31a38939
{
    internal static string _0x68c1e15b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}