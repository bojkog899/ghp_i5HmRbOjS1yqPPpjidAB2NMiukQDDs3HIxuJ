using UnityEngine;

// The swinging arrow above the core. It ping-pongs between 25 and 155 degrees, so
// a locked jump always carries the core upward - there is no "jump down".
public sealed class _0x7a394be8 : MonoBehaviour
{
    public void _0xc596e1a3(float _0xb8c4e253)
    {
        this._0x5de6df28 = Mathf.Clamp(_0xb8c4e253, LowAngle, HighAngle);
        this._0x154d6de1 = 1f;
    }

    public const float SweepSpeed = 150f;
    public float _0x83088a67
    {
        get
        {
            return this._0x5de6df28;
        }
    }

    public void _0xb61a6e44(float deltaTime, Vector2 _0xd940d434)
    {
        if (!this._0xf0f6b407)
        {
            return;
        }

        this._0x5de6df28 += SweepSpeed * this._0x154d6de1 * deltaTime;
        if (this._0x5de6df28 >= HighAngle)
        {
            this._0x5de6df28 = HighAngle;
            this._0x154d6de1 = -1f;
        }
        else if (this._0x5de6df28 <= LowAngle)
        {
            this._0x5de6df28 = LowAngle;
            this._0x154d6de1 = 1f;
        }

        float _0x1c22f0ce = this._0x5de6df28 * Mathf.Deg2Rad;
        Vector2 _0x2230b57b = new Vector2(Mathf.Cos(_0x1c22f0ce), Mathf.Sin(_0x1c22f0ce)) * Reach;
        this.transform.position = new Vector3(_0xd940d434.x + _0x2230b57b.x, _0xd940d434.y + _0x2230b57b.y, 0f);
        this.transform.rotation = Quaternion.Euler(0f, 0f, this._0x5de6df28);
        if (this._renderer != null)
        {
            this._renderer.size = new Vector2(0.78f, 0.78f);
            this._renderer.color = _0xf18456f5.Accent;
        }
    }

    private const float Reach = 0.62f;
    [SerializeField]
    private SpriteRenderer _renderer;
    public const float LowAngle = 25f;
    public const float HighAngle = 155f;
    private float _0x5de6df28 = 90f;
    private float _0x154d6de1 = 1f;
    private bool _0xf0f6b407 = true;
    public void _0xdd72f2d7(bool _0xe4c41804)
    {
        this._0xf0f6b407 = _0xe4c41804;
        if (this._renderer != null)
        {
            this._renderer.enabled = _0xe4c41804;
        }
    }
}