using UnityEngine;
using UnityEngine.UI;

public class _0x73460a34 : MonoBehaviour
{
    private void Awake()
    {
        if (this._0x24e93a62 == null)
            if (!this.TryGetComponent(out this._0x24e93a62))
                this._0x24e93a62 = this.GetComponentInChildren<Button>();
    }

    private int _0xa0e36ba3;
    private Button _0x24e93a62;
    private bool _0x06f322f0;
    private void Start()
    {
        if (this._0x06f322f0)
            this._0x24e93a62.onClick.AddListener(() => _0x42b5233b.Instance._0xa352bdac());
        else
            this._0x24e93a62.onClick.AddListener(() => _0x42b5233b.Instance._0x948050d1(this._0xa0e36ba3));
    }
}