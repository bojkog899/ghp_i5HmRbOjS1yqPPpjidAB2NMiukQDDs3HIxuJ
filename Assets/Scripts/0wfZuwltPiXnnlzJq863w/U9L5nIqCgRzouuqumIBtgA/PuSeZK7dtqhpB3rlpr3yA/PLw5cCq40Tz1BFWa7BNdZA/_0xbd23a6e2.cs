using UnityEngine;
using UnityEngine.UI;

public class _0xbd23a6e2 : MonoBehaviour
{
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0xcefca5e5.Instance._0x19693c4d(this.IsPhysicsRunOnClick));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsPhysicsRunOnClick;
    public Button Button;
}