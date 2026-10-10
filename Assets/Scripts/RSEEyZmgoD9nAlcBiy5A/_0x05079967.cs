using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// A full-panel hit layer. UGUI gives taps that respect button raycasts, which raw
// EnhancedTouch would not; the template's InputController cannot be used from
// generated code (its Instance and every getter are private).
public sealed class _0x05079967 : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private Image _surface;
    public void _0x49bfe48d(Image _0xeff6a0eb, System.Action _0xfabef308, System.Action _0x9264258e)
    {
        this._surface = _0xeff6a0eb;
        this._0x72572f52 = _0xfabef308;
        this._0x186721b0 = _0x9264258e;
        if (this._surface != null)
        {
            // A fully transparent graphic is culled by the raycaster, so the hit layer
            // keeps a trace of alpha and opts out of transparent-mesh culling.
            this._surface.color = new Color(1f, 1f, 1f, 0.004f);
            this._surface.raycastTarget = true;
            this._surface.canvasRenderer.cullTransparentMesh = false;
        }
    }

    public const float DoubleTapWindow = 0.26f;
    public void OnPointerClick(PointerEventData _0x895fa964)
    {
        float _0xd53e41b9 = Time.unscaledTime;
        bool _0x2f19732a = (_0xd53e41b9 - this._0xa48d1171) <= DoubleTapWindow;
        this._0xa48d1171 = _0xd53e41b9;
        if (_0x2f19732a)
        {
            this._0xa48d1171 = -10f;
            if (this._0x186721b0 != null)
            {
                this._0x186721b0.Invoke();
            }

            return;
        }

        if (this._0x72572f52 != null)
        {
            this._0x72572f52.Invoke();
        }
    }

    private float _0xa48d1171 = -10f;
    private System.Action _0x186721b0;
    private System.Action _0x72572f52;
}