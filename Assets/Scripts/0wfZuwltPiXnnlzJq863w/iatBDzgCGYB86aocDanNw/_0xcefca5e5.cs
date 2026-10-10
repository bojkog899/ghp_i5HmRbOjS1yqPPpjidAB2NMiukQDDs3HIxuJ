using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x682bf997;

public class _0xcefca5e5 : MonoBehaviour
{
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xcefca5e5>();
        this.RootGameObject = GameObject.FindWithTag(_0x819ac7ce._0x3534b19a(new byte[4] { 245, 200, 200, 211 }, 167));
        if (this._0x364d82cf == _0x03d597f1.SCENE_0)
            this._0x19693c4d(true);
        else
            this._0x19693c4d(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0xda2f2e29>(true).ToList();
    }

    public static _0xcefca5e5 Instance;
    public Transform EnvironmentWithTweensToToggle;
    public Canvas MainCanvas;
    private void _0xf70a351d()
    {
        IsAfterLevelComplete = true;
        Instance._0x1484c85c(_0x03d597f1.SCENE_0);
    }

    private IEnumerator _0x80284ad8(string _0xd97958b1)
    {
        _0x42b5233b.Instance._0x948050d1(_0x29641b38.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0xbad12487 = SceneManager.LoadSceneAsync(_0xd97958b1);
        while (!_0xbad12487.isDone)
            yield return null;
    }

    public void _0xf4ffba89()
    {
        _0x49d431b3._0x92e9e7c7 = true;
    }

    private void _0x4f65b8dd(Transform _0x627e8ae2)
    {
        Transform[] _0xd0e4e099 = _0x627e8ae2.GetComponentsInChildren<Transform>();
        foreach (Transform _0x3b2239a1 in _0xd0e4e099)
            if (_0x3b2239a1 != null && DOTween.IsTweening(_0x3b2239a1))
            {
                if (this._0x67283b03)
                    DOTween.Play(_0x3b2239a1);
                else
                    DOTween.Pause(_0x3b2239a1);
            }
    }

    public static bool IsAfterLevelComplete;
    private static _0x2cf54a02 _0x84164db4 => _0x2cf54a02.ALL_SCENES_SETTING_SINGLETONS[0];

    private void Start()
    {
        if (this._0x364d82cf != _0x03d597f1.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0x1484c85c(_0x03d597f1.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x49d431b3._0x92e9e7c7 = false;
            _0xc1414747.Instance._0x3b9ea76e();
            _0x42b5233b.Instance._0x948050d1(_0x29641b38.TUTORIAL0);
        });
    }

    public void _0x2060f1db()
    {
        this._0x1484c85c(SceneManager.GetActiveScene().buildIndex);
    }

    private static void MakeGrid(List<RectTransform> _0x247e88b5, AspectRatioFitter _0x9f3e0aa5, float _0x02e528be, int _0x2ea2dd99, int _0x6c197df3)
    {
        _0x9f3e0aa5.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x9f3e0aa5.aspectRatio = _0x02e528be;
        foreach (RectTransform _0x234e62c8 in _0x247e88b5)
        {
            int _0xe6f3bf64 = _0x234e62c8.transform.GetSiblingIndex();
            _0x234e62c8.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xe6f3bf64 % _0x2ea2dd99) * (1f / _0x2ea2dd99), (_0x6c197df3 - (Mathf.FloorToInt((float)_0xe6f3bf64 / _0x2ea2dd99) % _0x6c197df3 + 1f)) * (1f / _0x6c197df3));
            _0x234e62c8.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xe6f3bf64 % _0x2ea2dd99 + 1f) * (1f / _0x2ea2dd99), (_0x6c197df3 - Mathf.FloorToInt((float)_0xe6f3bf64 / _0x2ea2dd99) % _0x6c197df3) * (1f / _0x6c197df3));
            _0x234e62c8.offsetMin = Vector2.zero;
            _0x234e62c8.offsetMax = Vector2.zero;
        }
    }

    public Button DeleteProgressDataButton;
    private static _0x2cf54a02 GAME_INDEX_SETTINGS(int _0x90f1a8e9)
    {
        return _0x2cf54a02.ALL_SCENES_SETTING_SINGLETONS[_0x90f1a8e9];
    }

    public void _0x1484c85c(int _0x48ea8476)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x3a08b6a3(_0x48ea8476));
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    public int _0x364d82cf => SceneManager.GetActiveScene().buildIndex;
    public static _0x2cf54a02 _0x49d431b3 => _0x2cf54a02.ALL_SCENES_SETTING_SINGLETONS[Instance._0x364d82cf];

    private void _0x0245de83(bool _0x52ead104)
    {
        Rigidbody2D[] _0xf3af433d = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x06c90547 in _0xf3af433d)
            if (_0x52ead104)
                _0x06c90547.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x06c90547.constraints = RigidbodyConstraints2D.None;
    }

    [HideInInspector]
    public List<_0xda2f2e29> MoneyCountContainers = new();
    private IEnumerator _0x3a08b6a3(int _0x18660714)
    {
        _0x42b5233b.Instance._0x948050d1(_0x29641b38.SPLASH);
        AsyncOperation _0x3f5967ba = SceneManager.LoadSceneAsync(_0x18660714);
        while (!_0x3f5967ba.isDone)
            yield return null;
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public void _0x24d33062()
    {
        foreach (_0xda2f2e29 _0x8d26bfbd in this.MoneyCountContainers)
            _0x8d26bfbd._0x0cd39daa();
    }

    public void _0x19693c4d(bool _0x42bd57d6)
    {
        this._0x67283b03 = _0x42bd57d6;
        this._0x0245de83(!this._0x67283b03);
        Physics2D.simulationMode = this._0x67283b03 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x4f65b8dd(this.EnvironmentWithTweensToToggle);
    }

    public static bool IsAfterLevelFailed = false;
    public Transform Environment;
    public bool _0x67283b03 { get; private set; }

    public Button ShowResetTutorialButton;
}

internal static class _0x819ac7ce
{
    internal static string _0x3534b19a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}