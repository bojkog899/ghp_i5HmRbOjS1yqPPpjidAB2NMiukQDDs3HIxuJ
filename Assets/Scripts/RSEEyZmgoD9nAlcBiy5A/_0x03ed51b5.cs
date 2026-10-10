using DG.Tweening;
using UnityEngine;

// One perch in the shaft. Width is set through SpriteRenderer.size so the authored
// Sliced draw mode stays the single source of truth (C.0).
public sealed class _0x03ed51b5 : MonoBehaviour
{
    public bool _0x04a04db4
    {
        get
        {
            return this._isAnchor;
        }
    }

    private float _0x6f0771e8 = 0.5f;
    public void _0x37b24914(float _0x209ed8f4)
    {
        this._0x6f0771e8 = _0x209ed8f4;
        if (this._renderer == null)
        {
            return;
        }

        float height = this._isAnchor ? 0.34f : 0.26f;
        this._renderer.size = new Vector2(_0x209ed8f4 * 2f, height);
        this._0x8b7819db = this._isAnchor ? _0xf18456f5.Gold : _0xf18456f5.Accent;
        this._renderer.color = this._0x8b7819db;
    }

    [SerializeField]
    private bool _isAnchor;
    public void _0xe10d84cf()
    {
        if (this._renderer == null)
        {
            return;
        }

        DOTween.Kill(this._renderer, true);
        this._renderer.color = _0xf18456f5.Paper;
        this._renderer.DOColor(this._0x8b7819db, 0.25f).SetLink(this._renderer.gameObject);
    }

    public float _0x194ad11e
    {
        get
        {
            return this._0x6f0771e8;
        }
    }

    public float _0x4938eaf6
    {
        get
        {
            return this.transform.position.y + 0.13f;
        }
    }

    private Color _0x8b7819db = Color.white;
    [SerializeField]
    private SpriteRenderer _renderer;
    public void _0x32c41849()
    {
        if (this._renderer == null)
        {
            return;
        }

        Vector2 _0x6c1f1f42 = this._renderer.size;
        Vector2 _0xd2bf1708 = new Vector2(_0x6c1f1f42.x * 1.12f, _0x6c1f1f42.y * 1.12f);
        DOTween.Kill(this._renderer, true);
        DOTween.To(() => this._renderer.size, _0x220e27cf => this._renderer.size = _0x220e27cf, _0xd2bf1708, 0.15f).SetEase(Ease.OutQuad).OnComplete(() => DOTween.To(() => this._renderer.size, _0x220e27cf => this._renderer.size = _0x220e27cf, _0x6c1f1f42, 0.15f));
    }
}