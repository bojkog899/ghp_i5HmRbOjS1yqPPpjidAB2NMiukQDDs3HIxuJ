using UnityEngine;

// Codegen only ever switches objects it created itself (C.2). This is the handle.
public sealed class _0x875ac168 : MonoBehaviour
{
    [SerializeField]
    private GameObject _content;
    public void _0xe2a5f96f()
    {
        if (this._content != null)
        {
            this._content.SetActive(true);
        }
    }

    public void _0x730e14dd(GameObject _0xcd4bc0f5)
    {
        this._content = _0xcd4bc0f5;
    }

    public bool _0xc2f75570
    {
        get
        {
            return this._content != null && this._content.activeSelf;
        }
    }

    public void _0xf257c7f4()
    {
        if (this._content != null)
        {
            this._content.SetActive(false);
        }
    }
}