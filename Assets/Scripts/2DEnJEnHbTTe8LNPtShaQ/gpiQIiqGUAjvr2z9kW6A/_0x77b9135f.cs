using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x77b9135f : MonoBehaviour
{
    private Vector3 _0xbfb7d7e6 { get; set; }
    private Vector3 _0xe3f20d35 { get; set; }
    private Vector3 _0x8c7bacb1 { get; set; }
    private Vector3 _0x5641b1e0 { get; set; }

    private void Awake()
    {
        this._0xbd446c65 = this.GetComponent<Camera>();
        _0x986c3e9a = this;
        this._0x21e6f84a();
    }

    private _0xf8d470c4 _0xdaa0fe8a = _0xf8d470c4.Portrait;
    private static _0x77b9135f _0x986c3e9a;
    private Vector3 _0x12b08fee { get; set; }
    private Vector3 _0x295b45b3 { get; set; }

    private void _0x21e6f84a()
    {
        float _0x5a6c4ff4, _0x56e43f5a, _0xdc206128, _0x67e19d97;
        if (this._0xdaa0fe8a == _0xf8d470c4.Landscape)
            this._0xbd446c65.orthographicSize = 1f / this._0xbd446c65.aspect * this._0xd7a0c24f / 2f;
        else
            this._0xbd446c65.orthographicSize = this._0xd7a0c24f / 2f;
        this._0xb029f3d8 = 2f * this._0xbd446c65.orthographicSize;
        this._0x3e720fdb = this._0xb029f3d8 * this._0xbd446c65.aspect;
        float _0xe9332116 = this._0xbd446c65.transform.position.x;
        float _0xb9901a5c = this._0xbd446c65.transform.position.y;
        _0x5a6c4ff4 = _0xe9332116 - this._0x3e720fdb / 2;
        _0x56e43f5a = _0xe9332116 + this._0x3e720fdb / 2;
        _0xdc206128 = _0xb9901a5c + this._0xb029f3d8 / 2;
        _0x67e19d97 = _0xb9901a5c - this._0xb029f3d8 / 2;
        this._0x8c7bacb1 = new Vector3(_0x5a6c4ff4, _0x67e19d97, 0);
        this._0x12b08fee = new Vector3(_0xe9332116, _0x67e19d97, 0);
        this._0xb78c149d = new Vector3(_0x56e43f5a, _0x67e19d97, 0);
        this._0x526685ab = new Vector3(_0x5a6c4ff4, _0xb9901a5c, 0);
        this._0x5641b1e0 = new Vector3(_0xe9332116, _0xb9901a5c, 0);
        this._0xbfb7d7e6 = new Vector3(_0x56e43f5a, _0xb9901a5c, 0);
        this._0xef825b0d = new Vector3(_0x5a6c4ff4, _0xdc206128, 0);
        this._0xe3f20d35 = new Vector3(_0xe9332116, _0xdc206128, 0);
        this._0x295b45b3 = new Vector3(_0x56e43f5a, _0xdc206128, 0);
    }

    private new Camera _0xbd446c65;
    //public bool executeInUpdate;
    private float _0x3e720fdb { get; set; }
    private float _0xb029f3d8 { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0xf4cf717a;
        Matrix4x4 _0x30b58cbf = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xbd446c65.orthographic)
        {
            float _0x57af4f3c = this._0xbd446c65.farClipPlane - this._0xbd446c65.nearClipPlane;
            float _0xc144c44d = (this._0xbd446c65.farClipPlane + this._0xbd446c65.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0xc144c44d), new Vector3(this._0xbd446c65.orthographicSize * 2 * this._0xbd446c65.aspect, this._0xbd446c65.orthographicSize * 2, _0x57af4f3c));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xbd446c65.fieldOfView, this._0xbd446c65.farClipPlane, this._0xbd446c65.nearClipPlane, this._0xbd446c65.aspect);
        }

        Gizmos.matrix = _0x30b58cbf;
    }

    private float _0xd7a0c24f = 1;
    private Vector3 _0x526685ab { get; set; }

    public enum _0xf8d470c4
    {
        Landscape,
        Portrait
    }

    private Vector3 _0xef825b0d { get; set; }
    private Vector3 _0xb78c149d { get; set; }

    private Color _0xf4cf717a = Color.white;
}