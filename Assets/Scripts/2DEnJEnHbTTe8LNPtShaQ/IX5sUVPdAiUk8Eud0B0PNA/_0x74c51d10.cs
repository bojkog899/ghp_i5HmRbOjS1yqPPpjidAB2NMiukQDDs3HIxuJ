using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x74c51d10 : MonoBehaviour
{
    private TMP_Text _0xe3e17ed2;
    private Image _0x847bc2aa;
    private void Update()
    {
        this._0x488fd762();
    }

    private void _0x488fd762()
    {
        if (this._0x847bc2aa.canvasRenderer.GetColor() != this._0xe3e17ed2.canvasRenderer.GetColor())
            this._0xe3e17ed2.canvasRenderer.SetColor(this._0x847bc2aa.canvasRenderer.GetColor());
    }
}