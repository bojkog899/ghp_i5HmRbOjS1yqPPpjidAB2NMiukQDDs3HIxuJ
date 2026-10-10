using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Menu body: abstract mark, objective, best-altitude readout and the three ways
// into the shaft. No game name appears anywhere on this screen.
public sealed class _0x72fc3c58 : MonoBehaviour
{
    private void _0x47642dc8(Transform _0xa0a5d007)
    {
        RectTransform _0x332cb42a = _0x341165e8.Node(_0xa0a5d007, _0x5eee5749._0xd8afa49d(new byte[11] { 202, 237, 251, 252, 218, 237, 233, 236, 231, 253, 252 }, 136), new Vector2(0.5f, 0.505f), Vector2.zero, new Vector2(560f, 96f));
        Image _0xd5a7ef6b = _0x341165e8.Plate(_0x332cb42a, _0x5eee5749._0xd8afa49d(new byte[9] { 205, 234, 252, 251, 223, 227, 238, 251, 234 }, 143), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(560f, 96f), _0xf18456f5.Alpha(_0xf18456f5.Surface, 0.9f), this._roundPlate);
        _0xd5a7ef6b.raycastTarget = false;
        _0x341165e8.Picture(_0x332cb42a, _0x5eee5749._0xd8afa49d(new byte[9] { 209, 246, 224, 231, 209, 242, 247, 244, 246 }, 147), this._altBadge, new Vector2(0.5f, 0.5f), new Vector2(-210f, 0f), new Vector2(62f, 62f));
        this._0xfac46e1b = _0x341165e8.Label(_0x332cb42a, _0x5eee5749._0xd8afa49d(new byte[9] { 163, 132, 146, 149, 183, 128, 141, 148, 132 }, 225), _0x5eee5749._0xd8afa49d(new byte[8] { 105, 110, 120, 127, 11, 27, 11, 102 }, 43), new Vector2(0.5f, 0.5f), new Vector2(40f, 0f), new Vector2(420f, 76f), 30f, 48f, _0xf18456f5.Gold, this._font, TextAlignmentOptions.Left);
        this._0xfac46e1b.text = _0x5eee5749._0xd8afa49d(new byte[5] { 224, 231, 241, 246, 130 }, 162) + _0x69baa7e4.OverallBest().ToString() + _0x5eee5749._0xd8afa49d(new byte[2] { 94, 51 }, 126);
    }

    [SerializeField]
    private Sprite _tutGoal;
    [SerializeField]
    private _0x0080e91a _sheet;
    [SerializeField]
    private Sprite _roundPlate;
    private void _0xa6d39dec()
    {
        if (this._sheet != null)
        {
            this._sheet._0x30402c7c();
        }

        if (this._howTo != null)
        {
            this._howTo._0x74d6221d();
        }
    }

    private void Start()
    {
        _0x69baa7e4.PublishOverallBest();
        _0x706c786a _0xd44654ee = _0x42b5233b.Instance.Panels[_0x682bf997._0x29641b38.DEFAULT];
        if (_0xd44654ee == null || _0xd44654ee.Content == null)
        {
            return;
        }

        Transform _0x6a1ce4b8 = _0xd44654ee.Content.transform;
        this._0x67af2776(_0x6a1ce4b8);
        this._0x0105cff0(_0x6a1ce4b8);
        this._0x47642dc8(_0x6a1ce4b8);
        this._0xed621a5c();
        this._0x70739653(_0x6a1ce4b8);
        if (this._sheet != null)
        {
            this._sheet._0xdd7bea86(_0x6a1ce4b8, this._chargePip, this._lockBadge, this._closeIcon, this._roundPlate, this._font);
        }

        if (this._howTo != null)
        {
            this._howTo._0x17e91ed7(_0x6a1ce4b8, this._tutAim, this._tutBrake, this._tutGoal, this._closeIcon, this._roundPlate, this._font);
        }
    }

    [SerializeField]
    private Sprite _tutAim;
    // Rule G.3 resized the template's own Play button in the scene; it is invisible by
    // construction, so its face is drawn here as a CHILD and the click bubbles up.
    private void _0xed621a5c()
    {
        if (this._playButton == null)
        {
            return;
        }

        Vector2 _0xd155f4c0 = this._playButton.sizeDelta;
        Image _0x178d42ea = _0x341165e8.Plate(this._playButton, _0x5eee5749._0xd8afa49d(new byte[8] { 46, 18, 31, 7, 59, 26, 25, 27 }, 126), new Vector2(0.5f, 0.5f), Vector2.zero, _0xd155f4c0, _0xf18456f5.Accent, this._roundPlate);
        _0x178d42ea.raycastTarget = true;
        _0x178d42ea.canvasRenderer.cullTransparentMesh = false;
        Image _0xf506df54 = _0x341165e8.Plate(this._playButton, _0x5eee5749._0xd8afa49d(new byte[8] { 63, 3, 14, 22, 41, 14, 12, 10 }, 111), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xd155f4c0.x - 10f, _0xd155f4c0.y - 10f), _0xf18456f5.Alpha(_0xf18456f5.Surface, 0.97f), this._roundPlate);
        _0xf506df54.raycastTarget = true;
        _0xf506df54.canvasRenderer.cullTransparentMesh = false;
        TextMeshProUGUI _0x49294802 = _0x341165e8.Label(this._playButton, _0x5eee5749._0xd8afa49d(new byte[9] { 245, 201, 196, 220, 233, 196, 199, 192, 201 }, 165), _0x5eee5749._0xd8afa49d(new byte[4] { 137, 149, 152, 128 }, 217), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xd155f4c0.x - 60f, _0xd155f4c0.y - 40f), 44f, 72f, _0xf18456f5.Paper, this._font, TextAlignmentOptions.Center);
        _0x49294802.transform.SetAsLastSibling();
        _0x178d42ea.transform.DOScale(1.02f, 0.9f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(_0x178d42ea.transform.gameObject);
    }

    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private Sprite _altBadge;
    private TextMeshProUGUI _0xfac46e1b;
    [SerializeField]
    private Sprite _tutBrake;
    [SerializeField]
    private Sprite _lockBadge;
    private void _0x67af2776(Transform _0xbd693104)
    {
        Image _0x03b75873 = _0x341165e8.Picture(_0xbd693104, _0x5eee5749._0xd8afa49d(new byte[10] { 251, 220, 216, 218, 214, 215, 244, 216, 203, 210 }, 185), this._markEmblem, new Vector2(0.5f, 0.745f), Vector2.zero, new Vector2(380f, 380f));
        _0x03b75873.color = Color.white;
        _0x03b75873.transform.localScale = Vector3.one * 0.94f;
        _0x03b75873.transform.DOScale(1f, 0.9f).SetEase(Ease.OutBack).SetLink(_0x03b75873.transform.gameObject);
        Image _0xf731fe4e = _0x341165e8.Plate(_0xbd693104, _0x5eee5749._0xd8afa49d(new byte[8] { 17, 61, 46, 55, 20, 61, 48, 51 }, 92), new Vector2(0.5f, 0.745f), Vector2.zero, new Vector2(440f, 440f), _0xf18456f5.Alpha(_0xf18456f5.Accent, 0.18f), this._roundPlate);
        _0xf731fe4e.transform.SetAsFirstSibling();
        _0xf731fe4e.transform.DOLocalRotate(new Vector3(0f, 0f, 360f), 22f, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
    }

    [SerializeField]
    private Sprite _closeIcon;
    private void _0x0f0d54b2()
    {
        if (this._howTo != null)
        {
            this._howTo._0x8d6a6129();
        }

        if (this._sheet != null)
        {
            this._sheet._0xe50d100b();
        }
    }

    private void _0x0105cff0(Transform _0x68417e4d)
    {
        _0x341165e8.Label(_0x68417e4d, _0x5eee5749._0xd8afa49d(new byte[13] { 115, 91, 80, 75, 113, 92, 84, 91, 93, 74, 87, 72, 91 }, 62), _0x5eee5749._0xd8afa49d(new byte[34] { 211, 210, 219, 222, 193, 210, 197, 183, 195, 223, 210, 183, 212, 216, 197, 210, 157, 195, 216, 183, 195, 223, 210, 183, 195, 216, 199, 183, 213, 210, 214, 212, 216, 217 }, 151), new Vector2(0.5f, 0.600f), Vector2.zero, new Vector2(1020f, 170f), 30f, 52f, _0xf18456f5.Paper, this._font, TextAlignmentOptions.Center);
    }

    private void _0x70739653(Transform _0x24f01104)
    {
        Button _0xa5c54889 = _0x341165e8.Cta(_0x24f01104, _0x5eee5749._0xd8afa49d(new byte[11] { 184, 144, 155, 128, 166, 144, 150, 129, 154, 135, 134 }, 245), _0x5eee5749._0xd8afa49d(new byte[7] { 33, 55, 49, 38, 61, 32, 33 }, 114), new Vector2(0.5f, 0.212f), Vector2.zero, new Vector2(560f, 132f), _0xf18456f5.Alpha(_0xf18456f5.Ink, 0.94f), _0xf18456f5.Alpha(_0xf18456f5.Violet, 0.9f), _0xf18456f5.Paper, 34f, 50f, this._font, this._roundPlate);
        _0xa5c54889.onClick.AddListener(() => this._0x0f0d54b2());
        Button _0x6ab0cc62 = _0x341165e8.Cta(_0x24f01104, _0x5eee5749._0xd8afa49d(new byte[9] { 245, 221, 214, 205, 240, 215, 207, 236, 215 }, 184), _0x5eee5749._0xd8afa49d(new byte[11] { 205, 202, 210, 165, 209, 202, 165, 213, 201, 196, 220 }, 133), new Vector2(0.5f, 0.140f), Vector2.zero, new Vector2(560f, 132f), _0xf18456f5.Alpha(_0xf18456f5.Ink, 0.94f), _0xf18456f5.Alpha(_0xf18456f5.Violet, 0.9f), _0xf18456f5.Paper, 34f, 50f, this._font, this._roundPlate);
        _0x6ab0cc62.onClick.AddListener(() => this._0xa6d39dec());
    }

    [SerializeField]
    private _0x4bdc8413 _howTo;
    [SerializeField]
    private Sprite _markEmblem;
    [SerializeField]
    private RectTransform _playButton;
    [SerializeField]
    private Sprite _chargePip;
}

internal static class _0x5eee5749
{
    internal static string _0xd8afa49d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}