using UnityEngine;

// Shaft fan. It never ends a round on its own: its draught pushes the core
// sideways while the core is inside its radius.
public sealed class _0x6dfee5b0 : MonoBehaviour
{
    public float _0xf17127ea(Vector2 _0xdc90f234)
    {
        Vector2 _0xa12f32bf = this.transform.position;
        float _0xccf6c5c3 = Vector2.Distance(_0xa12f32bf, _0xdc90f234);
        if (_0xccf6c5c3 > this._radius)
        {
            return 0f;
        }

        float _0xfccdd6f7 = 1f - (_0xccf6c5c3 / this._radius);
        return this._push * this._0x2d6112c3 * _0xfccdd6f7;
    }

    [SerializeField]
    private float _push = 1.8f;
    [SerializeField]
    private SpriteRenderer _renderer;
    public void _0x58c3d7a7(float deltaTime)
    {
        this.transform.Rotate(0f, 0f, this._spinSpeed * this._0x2d6112c3 * deltaTime);
    }

    [SerializeField]
    private float _spinSpeed = 150f;
    public float _0x02394c08
    {
        get
        {
            return this._radius;
        }
    }

    public void _0xcea174a2(float _0x38b26ce8)
    {
        this._0x2d6112c3 = _0x38b26ce8 >= 0f ? 1f : -1f;
        if (this._renderer != null)
        {
            this._renderer.size = new Vector2(0.90f, 0.90f);
            this._renderer.color = _0xf18456f5.Violet;
        }
    }

    [SerializeField]
    private float _radius = 1.1f;
    private float _0x2d6112c3 = 1f;
}