using TMPro;
using UnityEngine;
using static _0x682bf997;

public class _0xda2f2e29 : MonoBehaviour
{
    public void _0x0cd39daa()
    {
        this.MoneyCountText.text = _0x99de7efd._0xd2149585.ToString();
    }

    public TMP_Text MoneyCountText;
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0xc283ce79;
            if (this.gameObject.TryGetComponent(out _0xc283ce79))
                this.MoneyCountText = _0xc283ce79;
        }

        this._0x0cd39daa();
    }
}