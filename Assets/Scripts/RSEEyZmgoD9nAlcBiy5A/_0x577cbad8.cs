using DG.Tweening;
using UnityEngine;

// The energy core. The climb is integrated by hand here, so nothing in the shaft is
// driven by the 2D solver: the body components the asset stage hangs on the generated
// prefabs are authored kinematic and non-simulated, and the template's SetPhysicsRun
// freeze cannot desync the climb.
public sealed class _0x577cbad8 : MonoBehaviour
{
    private Vector2 _0xaaf46069;
    [SerializeField]
    private SpriteRenderer _brakeRing;
    private bool _0x7a610b25;
    public bool _0xfeb5ed50()
    {
        if (!this._0x4d70894e)
        {
            return false;
        }

        this._0x21dae62b = true;
        this._0x7f8d6eee = BrakeHold;
        this._0xaaf46069.x *= BrakeLateral;
        this._0x2d280485();
        return true;
    }

    public void _0xf9a007ea(float _0xffee10a9)
    {
        float _0x73a1c9a9 = _0xffee10a9 * Mathf.Deg2Rad;
        this._0xaaf46069 = new Vector2(Mathf.Cos(_0x73a1c9a9), Mathf.Sin(_0x73a1c9a9)) * _0x9422dea6.LaunchSpeed;
        this._0x7a610b25 = true;
        this._0x21dae62b = false;
        this._0x7f8d6eee = 0f;
    }

    [SerializeField]
    private SpriteRenderer _renderer;
    public Vector2 _0x635a179a
    {
        get
        {
            return this.transform.position;
        }
    }

    private const float BrakeFallCap = -1.30f;
    // A shutter does not end the round: it drops the arc and lets gravity decide.
    public void _0x0ff0f510()
    {
        this._0xaaf46069 = new Vector2(this._0xaaf46069.x * 0.25f, Mathf.Min(this._0xaaf46069.y, -0.4f));
        if (this._renderer != null)
        {
            this._renderer.color = _0xf18456f5.Danger;
        }
    }

    private void Awake()
    {
        if (this._renderer != null)
        {
            this._renderer.size = new Vector2(0.46f, 0.46f);
            this._renderer.color = _0xf18456f5.Accent;
        }

        if (this._brakeRing != null)
        {
            this._brakeRing.size = new Vector2(RingRest, RingRest);
            this._brakeRing.color = _0xf18456f5.Alpha(_0xf18456f5.Accent, 0f);
        }
    }

    public void _0x09839f40(SpriteRenderer _0x0347d522, SpriteRenderer _0x873781bd)
    {
        this._renderer = _0x0347d522;
        this._brakeRing = _0x873781bd;
    }

    private float _0x7f8d6eee;
    private const float RingRest = 0.46f;
    private bool _0x21dae62b;
    public Vector2 _0x9582ba78
    {
        get
        {
            return this._0xaaf46069;
        }
    }

    private void _0x2d280485()
    {
        if (this._brakeRing == null)
        {
            return;
        }

        DOTween.Kill(this._brakeRing, true);
        this._brakeRing.size = new Vector2(RingRest, RingRest);
        this._brakeRing.color = _0xf18456f5.Alpha(_0xf18456f5.Accent, 0.9f);
        Vector2 _0xecfada8f = new Vector2(RingOpen, RingOpen);
        DOTween.To(() => this._brakeRing.size, _0x220e27cf => this._brakeRing.size = _0x220e27cf, _0xecfada8f, 0.12f).SetEase(Ease.OutBack).SetLink(this.gameObject);
        this._brakeRing.DOFade(0f, 0.33f).SetDelay(0.12f).SetLink(this._brakeRing.gameObject);
    }

    public const float BrakeHold = 0.45f;
    public const float Radius = 0.23f;
    public bool _0x4d70894e
    {
        get
        {
            return this._0x7a610b25 && !this._0x21dae62b;
        }
    }

    private const float RingOpen = 0.86f;
    public void _0x9e1e3e69()
    {
        this._0x7a610b25 = false;
        this._0xaaf46069 = Vector2.zero;
        this._0x21dae62b = false;
        this._0x7f8d6eee = 0f;
        if (this._renderer != null)
        {
            this._renderer.color = _0xf18456f5.Accent;
        }
    }

    private const float WallBounce = -0.72f;
    public bool _0xbf49b27e
    {
        get
        {
            return this._0x7a610b25;
        }
    }

    private const float BrakeLateral = 0.22f;
    public void _0x31e4f1e0(Vector2 _0x531d62ff)
    {
        this.transform.position = new Vector3(_0x531d62ff.x, _0x531d62ff.y, 0f);
        this._0xaaf46069 = Vector2.zero;
        this._0x7a610b25 = false;
        this._0x21dae62b = false;
        this._0x7f8d6eee = 0f;
        if (this._renderer != null)
        {
            this._renderer.color = _0xf18456f5.Accent;
        }
    }

    public void _0x9bbc626a(float deltaTime, float _0x5dd93a5f)
    {
        if (!this._0x7a610b25)
        {
            return;
        }

        this._0xaaf46069.x += _0x5dd93a5f * deltaTime;
        this._0xaaf46069.y -= _0x9422dea6.Gravity * deltaTime;
        if (this._0x7f8d6eee > 0f)
        {
            this._0x7f8d6eee -= deltaTime;
            if (this._0xaaf46069.y < BrakeFallCap)
            {
                this._0xaaf46069.y = BrakeFallCap;
            }
        }

        Vector3 _0xd6c58275 = this.transform.position;
        _0xd6c58275.x += this._0xaaf46069.x * deltaTime;
        _0xd6c58275.y += this._0xaaf46069.y * deltaTime;
        float _0xbc8f3595 = _0x9422dea6.InnerHalfWidth - Radius;
        if (_0xd6c58275.x > _0xbc8f3595)
        {
            _0xd6c58275.x = _0xbc8f3595;
            this._0xaaf46069.x *= WallBounce;
        }
        else if (_0xd6c58275.x < -_0xbc8f3595)
        {
            _0xd6c58275.x = -_0xbc8f3595;
            this._0xaaf46069.x *= WallBounce;
        }

        this.transform.position = _0xd6c58275;
    }
}