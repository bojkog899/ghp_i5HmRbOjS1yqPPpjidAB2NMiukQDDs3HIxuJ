using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x8e511e3c : MonoBehaviour
{
    private void _0x185f36bd()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public bool IsScaledDownOnAwake = true;
    public TMP_Text ContentHeaderText;
    private void Start()
    {
    // Content.SetActive(false);
    }

    public float scaleDuration = 0.4f;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x185f36bd();
    }

    public void _0x8e724431()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public TMP_Text ContentMainText;
    private bool _0x5942482e => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public Ease ease = Ease.OutSine;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public TMP_Text ContentAdditionalText;
    public Image ContentImage;
    public GameObject Content;
    public static void HideAllPops()
    {
        _0xc1414747.Instance._0x3b9ea76e();
    }

    public bool IsOnlyYScale;
}