using UnityEngine;
using UnityEngine.UI;

public class _0x724fcb8d : MonoBehaviour
{
    public bool IsHideAllPops;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xc1414747.Instance._0x0c388a6e();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xc1414747.Instance._0x3b9ea76e());
        else
            this.Button.onClick.AddListener(() => _0xc1414747.Instance._0x40f6426c(this.PopToShowIndex));
    }

    public bool IsShowLastPop;
    public int PopToShowIndex;
}