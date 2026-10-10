using UnityEngine;

// Vertical follow for the climb camera plus the parallax backdrop that rides with it.
public sealed class _0xd1c540ae : MonoBehaviour
{
    public void _0xb19b389a(float _0x074ff5a6, float _0x798f7c08)
    {
        this._0x53c33e96 = _0x074ff5a6;
        this._0x8515ac48 = Mathf.Max(_0x798f7c08, _0x074ff5a6);
    }

    public void _0x4b33501a(float _0x88506dc8, float _0xba77d508)
    {
        if (this._camera == null)
        {
            return;
        }

        float _0x8d4d1d2a = Mathf.Clamp(_0x88506dc8, this._0x53c33e96, this._0x8515ac48);
        float _0xcb5526c7 = Mathf.SmoothDamp(this._camera.transform.position.y, _0x8d4d1d2a, ref this._0xd6b59527, 0.18f, 40f, _0xba77d508);
        this._0xe405523f(_0xcb5526c7);
    }

    private float _0xe1b25905 = 1.6f;
    [SerializeField]
    private Camera _camera;
    public float _0x722d23d9
    {
        get
        {
            return this._camera == null ? 5f : this._camera.orthographicSize;
        }
    }

    public void _0xe54d4180(float _0x4ae5e676)
    {
        this._0xd6b59527 = 0f;
        this._0xe405523f(Mathf.Clamp(_0x4ae5e676, this._0x53c33e96, this._0x8515ac48));
    }

    private Transform _0x3752368b;
    private void _0xe405523f(float _0x7d4c9929)
    {
        Vector3 _0x44416e23 = this._camera.transform.position;
        _0x44416e23.y = _0x7d4c9929;
        this._camera.transform.position = _0x44416e23;
        if (this._0x3752368b != null)
        {
            this._0x3752368b.position = new Vector3(0f, _0x7d4c9929, 1f);
        }

        if (this._0x7cf110e3 == null || this._0x7cf110e3.Length == 0)
        {
            return;
        }

        float _0xf5e430fd = _0x7d4c9929 * 0.45f;
        float _0x7a43d4e0 = this._0xe1b25905 * this._0x7cf110e3.Length;
        for (int _0x4d0c30be = 0; _0x4d0c30be < this._0x7cf110e3.Length; _0x4d0c30be++)
        {
            if (this._0x7cf110e3[_0x4d0c30be] == null)
            {
                continue;
            }

            float _0x26b8c5a9 = (_0x4d0c30be * this._0xe1b25905) - _0xf5e430fd;
            float _0xb60af860 = Mathf.Repeat(_0x26b8c5a9 - _0x7d4c9929 + (_0x7a43d4e0 * 0.5f), _0x7a43d4e0) + _0x7d4c9929 - (_0x7a43d4e0 * 0.5f);
            this._0x7cf110e3[_0x4d0c30be].position = new Vector3(0f, _0xb60af860, 0.5f);
        }
    }

    private float _0x8515ac48;
    public void _0x840499c7(Camera _0xfa20edad, Transform _0xafafec70, Transform[] _0x53c91067, float _0x5843f44a)
    {
        this._camera = _0xfa20edad;
        this._0x3752368b = _0xafafec70;
        this._0x7cf110e3 = _0x53c91067;
        this._0xe1b25905 = _0x5843f44a;
    }

    public float _0x0cd87f69
    {
        get
        {
            return this._0x722d23d9 * (this._camera == null ? 0.46154f : this._camera.aspect);
        }
    }

    private float _0xd6b59527;
    private float _0x53c33e96;
    private Transform[] _0x7cf110e3;
}