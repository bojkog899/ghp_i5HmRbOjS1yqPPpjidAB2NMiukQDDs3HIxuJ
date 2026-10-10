using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x706c786a : MonoBehaviour
{
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x2dee6366();
    }

    public float ScaleDuration = 0.4f;
    private void _0xa22c1fcd()
    {
        if (this.OuterBackground != null)
        {
            Image _0x58e88853 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x58e88853, true);
            _0x58e88853.DOFade(1f, 0f);
        }
    }

    public void Show()
    {
        this._0xb438ba24();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x42b5233b.Instance._0x1d2d6c8a(_0x42b5233b.Instance.CurrentPanelIndex);
            });
        }
    }

    private void _0xb438ba24()
    {
        if (this.OuterBackground != null)
        {
            Image _0x44896df9 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x44896df9, true);
            _0x44896df9.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    private void _0x2dee6366()
    {
        if (this.OuterBackground != null)
        {
            Image _0x9d7c6ad9 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x9d7c6ad9, true);
            _0x9d7c6ad9.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public TMP_Text MainText;
    public void _0x8d85d7c5()
    {
        this._0xa22c1fcd();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x42b5233b.Instance._0x1d2d6c8a(_0x42b5233b.Instance.CurrentPanelIndex);
    }

    public GameObject OuterBackground;
    public GameObject Content;
    private void _0xc42d5b86()
    {
        if (this.OuterBackground != null)
        {
            Image _0x7b1ca7ea = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x7b1ca7ea, true);
            _0x7b1ca7ea.DOFade(0f, this.ScaleDuration);
        }
    }

    public bool IsScaledDownOnAwake = true;
    public TMP_Text HeaderText;
    public Ease Ease = Ease.OutSine;
    private bool _0x4948e15f => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public void _0xfed9d7a4()
    {
        this._0xc42d5b86();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }
}