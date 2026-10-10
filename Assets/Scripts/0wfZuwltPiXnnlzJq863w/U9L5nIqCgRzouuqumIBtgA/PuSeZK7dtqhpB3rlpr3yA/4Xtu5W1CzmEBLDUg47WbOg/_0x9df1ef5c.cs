using UnityEngine;
using UnityEngine.UI;

public class _0x9df1ef5c : MonoBehaviour
{
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x42b5233b.Instance._0x948050d1(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0xcefca5e5.Instance._0xf4ffba89());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x42b5233b.Instance._0x948050d1(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x42b5233b.Instance._0x948050d1(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0xcefca5e5.Instance._0xf4ffba89());
        }
    }

    public bool IsTutorialEndPanel;
    public int EndTutorialPanelIndex = 1;
    public Button TutorialEndButton;
    public int NextTutorialPanelIndex;
    public Button NextTutorialButton;
}