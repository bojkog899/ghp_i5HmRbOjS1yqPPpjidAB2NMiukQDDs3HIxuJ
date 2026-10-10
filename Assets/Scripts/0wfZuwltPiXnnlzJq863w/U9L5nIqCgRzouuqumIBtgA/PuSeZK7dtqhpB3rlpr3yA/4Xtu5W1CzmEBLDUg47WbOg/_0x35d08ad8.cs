using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x35d08ad8 : MonoBehaviour
{
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x682bf997._0x03d597f1.SCENE_0 && !_0x8c8e85be)
        {
            this._0x8e3a8556();
        }
        else
        {
            this._0x266075ae();
        }
    }

    public void _0xaf242c69()
    {
        this._0x30575f4a?.Pause();
    }

    public GameObject Content;
    public void _0xa23ad7b8()
    {
        this._0x30575f4a?.Play();
    }

    public float SecondPassSliderValue = 0.5f;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x35d08ad8>();
    }

    private void _0x8e3a8556()
    {
        this.AnimationSlider.value = 0.05f;
        _0x8c8e85be = !_0x8c8e85be;
        this._0x30575f4a = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xa9b23571 => this.AnimationSlider.value = _0xa9b23571, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x41ab2b98._0xac2e2cd9?._0xd93372f3();
        });
    }

    public GameObject Error;
    private Sequence _0x30575f4a;
    public void _0x5abe8283()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x30575f4a?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x8c8e85be = false;
    }

    public void _0x266075ae()
    {
        this._0x5ca399dd();
        bool _0xf5c59bd7 = _0x8c8e85be;
        this._0x30575f4a = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xa9b23571 => this.AnimationSlider.value = _0xa9b23571, _0xf5c59bd7 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x8c8e85be = !_0x8c8e85be;
    }

    public void _0x5ca399dd()
    {
        this._0x30575f4a?.Kill();
        this.AnimationSlider.value = _0x8c8e85be ? this.SecondPassSliderValue : 0.05f;
    }

    public static _0x35d08ad8 Instance;
    public float DefaultAnimationTime = 0.4f;
    public Slider AnimationSlider;
    private static bool _0x8c8e85be = false;
    public GameObject Background;
    public float FirstAnimationTime = 10.0f;
}