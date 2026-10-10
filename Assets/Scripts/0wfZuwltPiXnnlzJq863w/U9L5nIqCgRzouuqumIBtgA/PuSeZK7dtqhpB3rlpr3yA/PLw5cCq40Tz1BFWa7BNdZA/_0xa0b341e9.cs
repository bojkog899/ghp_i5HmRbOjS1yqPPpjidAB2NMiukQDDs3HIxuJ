using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xa0b341e9 : MonoBehaviour
{
    public bool IsLoadCurrentScene;
    public int LoadSceneId;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0xcefca5e5.Instance._0x1484c85c(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0xcefca5e5.Instance._0x1484c85c(this.LoadSceneId));
    }

    public Button Button;
}