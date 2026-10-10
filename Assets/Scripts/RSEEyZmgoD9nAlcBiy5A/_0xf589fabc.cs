using UnityEngine;

// Armoured shutter sliding across the shaft. Touching it kills the arc without
// ending the round - the fall does that.
public sealed class _0xf589fabc : MonoBehaviour
{
    private float _0x185e8dae = 1f;
    [SerializeField]
    private float _speed = 0.55f;
    public void _0x0997790f(float deltaTime)
    {
        this._0x3f8b7916 += deltaTime * this._speed * this._0x185e8dae;
        float _0x318a42db = Mathf.Sin(this._0x3f8b7916) * this._span;
        Vector3 _0x5d52f0bf = this.transform.position;
        _0x5d52f0bf.x = Mathf.Clamp(this._0x00d59349 + _0x318a42db, -1.45f, 1.45f);
        this.transform.position = _0x5d52f0bf;
    }

    [SerializeField]
    private SpriteRenderer _renderer;
    private float _0x3f8b7916;
    public Vector2 _0x574e6286
    {
        get
        {
            return this._renderer == null ? new Vector2(0.6f, 0.15f) : this._renderer.size * 0.5f;
        }
    }

    private float _0x00d59349;
    [SerializeField]
    private float _span = 1.1f;
    public void _0x99c5ee39(float _0xf22e4da3, float _0xd655a4c7)
    {
        this._0x00d59349 = this.transform.position.x;
        this._0x3f8b7916 = _0xf22e4da3;
        this._0x185e8dae = _0xd655a4c7 >= 0f ? 1f : -1f;
        if (this._renderer != null)
        {
            this._renderer.size = new Vector2(1.25f, 0.30f);
            this._renderer.color = _0xf18456f5.Danger;
        }
    }
}