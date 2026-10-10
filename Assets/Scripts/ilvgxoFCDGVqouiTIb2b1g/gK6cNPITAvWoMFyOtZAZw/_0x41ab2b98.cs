using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x41ab2b98 : MonoBehaviour
{
    internal bool isApplicationPause = false;
    internal bool ContainsIgnoreCase(string _0x19956c4f, string _0xc846b272)
    {
        if (string.IsNullOrEmpty(_0x19956c4f) || string.IsNullOrEmpty(_0xc846b272))
            return false;
        return _0x19956c4f.IndexOf(_0xc846b272, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private async Task<bool> _0xcd7809e0()
    {
        {
#if B_LOGS
            Debug.Log(_0x7b5cc563._0xab54347a(new byte[29] { 34, 45, 28, 10, 13, 36, 89, 48, 10, 41, 11, 16, 15, 24, 26, 0, 56, 23, 29, 42, 24, 15, 28, 29, 58, 17, 28, 26, 18 }, 121));
#endif
        }

        string _0x9fbfadd8 = "";
        for (int _0xac94f2dd = 0; _0xac94f2dd < 2; _0xac94f2dd++)
        {
            if (await _0xa749abc1(1, 100))
            {
                await _0x3b026a8a(_0x7b5cc563._0xab54347a(new byte[7] { 162, 172, 175, 163, 171, 165, 164 }, 192));
                _0xb665039c();
                return true;
            }

            _0x9fbfadd8 = await _0x98a092be(1, 100);
            if (!string.IsNullOrEmpty(_0x9fbfadd8))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x9fbfadd8))
            {
                if (!string.IsNullOrEmpty(_0x88429545))
                {
                    _0x9fbfadd8 = _0xbb82621e(_0x9fbfadd8, _0x88429545);
                    {
#if B_LOGS
                        Debug.Log(_0x7b5cc563._0xab54347a(new byte[53] { 1, 14, 63, 41, 46, 7, 122, 25, 59, 57, 50, 63, 62, 122, 60, 51, 52, 59, 54, 15, 40, 54, 122, 45, 51, 46, 50, 122, 41, 63, 52, 62, 51, 62, 122, 184, 220, 200, 122, 41, 50, 53, 45, 122, 13, 63, 56, 12, 51, 63, 45, 96, 122 }, 90) + _0x9fbfadd8);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x7b5cc563._0xab54347a(new byte[39] { 61, 50, 3, 21, 18, 59, 70, 37, 7, 5, 14, 3, 2, 70, 0, 15, 8, 7, 10, 51, 20, 10, 70, 132, 224, 244, 70, 21, 14, 9, 17, 70, 49, 3, 4, 48, 15, 3, 17 }, 102));
#endif
                    }
                }

                _0x3b93685a = true;
                _0x6dfac2b4(_0x9fbfadd8);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x7b5cc563._0xab54347a(new byte[44] { 67, 76, 125, 107, 108, 69, 56, 93, 96, 123, 125, 104, 108, 113, 119, 118, 56, 111, 112, 113, 116, 125, 56, 123, 112, 125, 123, 115, 113, 118, 127, 56, 107, 121, 110, 125, 124, 56, 116, 113, 118, 115, 34, 56 }, 24) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private async Task _0xf0d1c5a7()
    {
        if (await _0x8ff8eb94())
            return;
        if (await _0xc9a0877b())
            return;
        if (await _0xcd7809e0())
            return;
        _0xa2539779();
        await _0x6bd1891a(_0x31789677());
        _0x4da1342b = await _0x7f9d2ca6();
        await _0x3d8dc435();
    }

    private string _0x5d4aeebc { get; set; }

    private bool _0x2d1123e0()
    {
        var _0x1a28dee3 = _0x9bfef1bb();
        if (_0x1a28dee3 == null)
            return false;
        WLog(_0x7b5cc563._0xab54347a(new byte[31] { 98, 75, 88, 78, 93, 75, 88, 79, 10, 72, 75, 73, 65, 10, 7, 20, 10, 90, 69, 90, 95, 90, 10, 109, 69, 104, 75, 73, 65, 16, 10 }, 42) + _0x1a28dee3.Id);
        _0x1a28dee3.GoBack();
        return true;
    }

    private void OnApplicationFocus(bool _0xfe1a3663)
    {
        isApplicationFocus = _0xfe1a3663;
        if (_0xfe1a3663 && _0xde5de23f)
        {
            _0x6fdfbbc1();
        }
    }

    private IEnumerator _0xd0080e9a(float _0x21e47a85)
    {
        yield return new WaitForSeconds(_0x21e47a85);
        if (!_0x5395936d)
        {
            _0x5395936d = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x9124152c}");
                }
#endif
            }
        }
    }

    private IEnumerator _0x31789677()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x7b5cc563._0xab54347a(new byte[26] { 56, 55, 6, 16, 23, 62, 67, 42, 13, 10, 23, 10, 2, 15, 10, 25, 6, 49, 6, 5, 5, 6, 17, 6, 17, 67 }, 99));
            }
#endif
        }

        bool _0x0428bdff = false;
        InstallReferrer.GetReferrer((_0xd9c55eb4) =>
        {
            Debug.Log(_0x7b5cc563._0xab54347a(new byte[24] { 149, 154, 171, 189, 186, 238, 156, 171, 168, 171, 188, 188, 171, 188, 147, 238, 169, 171, 186, 238, 44, 72, 92, 238 }, 206) + _0x9124152c);
            if (_0xd9c55eb4.IsSuccess)
            {
                _0x9124152c = _0xd9c55eb4.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x7b5cc563._0xab54347a(new byte[28] { 145, 158, 175, 185, 190, 234, 152, 175, 172, 175, 184, 184, 175, 184, 151, 234, 153, 191, 169, 169, 175, 185, 185, 234, 40, 76, 88, 234 }, 202) + _0x9124152c);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x7b5cc563._0xab54347a(new byte[27] { 123, 116, 69, 83, 84, 0, 114, 69, 70, 69, 82, 82, 69, 82, 125, 0, 102, 65, 73, 76, 69, 68, 0, 194, 166, 178, 0 }, 32) + _0xd9c55eb4);
#endif
                }

                _0x9124152c = "";
            }

            _0x5395936d = true;
        });
        StartCoroutine(_0xd0080e9a(2f));
        yield return new WaitUntil(() => _0x5395936d);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x9124152c}");
#endif
        }

        bool _0xe3097e7c = _0x9124152c.Contains(_0x7b5cc563._0xab54347a(new byte[6] { 170, 174, 161, 164, 169, 240 }, 205));
        _0x0428bdff = _0xe3097e7c || _0x9124152c.Contains(_0x7b5cc563._0xab54347a(new byte[18] { 144, 129, 129, 130, 223, 152, 159, 130, 133, 144, 150, 131, 144, 156, 223, 146, 158, 156 }, 241)) || _0x9124152c.Contains(_0x7b5cc563._0xab54347a(new byte[17] { 10, 27, 27, 24, 69, 13, 10, 8, 14, 9, 4, 4, 0, 69, 8, 4, 6 }, 107));
        _0x23a6b285 = _0xe3097e7c ? "" : (_0x0428bdff ? "" : _0x23a6b285);
        _0x23a6b285 = _0x23a6b285 ?? "";
        _0x5d4aeebc = _0x5d4aeebc ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x23a6b285}");
#endif
        }
    }

    private IEnumerator _0x32ccdfeb(string _0xb3f4725c)
    {
        if (Permission.HasUserAuthorizedPermission(_0xb3f4725c))
            yield break;
        bool _0xb352d269 = false;
        var _0x2a64f161 = new PermissionCallbacks();
        _0x2a64f161.PermissionGranted += _0xb558456a => _0xb352d269 = true;
        _0x2a64f161.PermissionDenied += _0xb558456a => _0xb352d269 = true;
        Permission.RequestUserPermission(_0xb3f4725c, _0x2a64f161);
        yield return new WaitUntil(() => _0xb352d269);
    }

    private string _0x3572078c = "";
    private string _0x2d2e39eb()
    {
        string _0x5beef340 = _0x7b5cc563._0xab54347a(new byte[62] { 242, 241, 240, 247, 246, 245, 244, 251, 250, 249, 248, 255, 254, 253, 252, 227, 226, 225, 224, 231, 230, 229, 228, 235, 234, 233, 210, 209, 208, 215, 214, 213, 212, 219, 218, 217, 216, 223, 222, 221, 220, 195, 194, 193, 192, 199, 198, 197, 196, 203, 202, 201, 163, 162, 161, 160, 167, 166, 165, 164, 171, 170 }, 147);
        System.Random _0x42e05105 = new System.Random();
        int _0xf2a56733 = _0x42e05105.Next(8, 16);
        return new string (Enumerable.Repeat(_0x5beef340, _0xf2a56733).Select(_0x63a7678c => _0x63a7678c[_0x42e05105.Next(_0x63a7678c.Length)]).ToArray());
    }

    private string _0xf09dcafd = "";
    // WEB VIEW LOGIC
    public bool _0xde5de23f { get; set; }

    private Canvas _0x034ea48d;
    private void _0x167cd2e0(string _0xd878201d)
    {
        if (string.IsNullOrEmpty(_0xd878201d))
            return;
        if (TryOpenExternalLikeChrome(_0xd878201d))
            return;
        OpenUrlExternally(_0xd878201d);
    }

    private void _0x2fd59684()
    {
        if (_0x5ffac795 == null)
            return;
        if (_0x42233c1b)
            _0x5ffac795.SetUserAgent(_0xc3e061f8());
        else
            _0x5ffac795.SetUserAgent("");
    }

    private bool _0xfde49a69 = false;
    private void WLog(string _0x8afd0af1)
    {
#if B_LOGS
        {
            Debug.Log(_0x7b5cc563._0xab54347a(new byte[7] { 98, 109, 92, 74, 77, 100, 25 }, 57) + _0x8afd0af1);
        }
#endif
    }

    private RectTransform _0x2a0f218b;
    private async Task<bool> _0xc9a0877b()
    {
        _0x35d08ad8.Instance?._0xaf242c69();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x7d40c2a4) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x7b5cc563._0xab54347a(new byte[32] { 162, 173, 156, 138, 141, 164, 217, 172, 151, 144, 141, 128, 217, 169, 140, 138, 145, 217, 183, 150, 141, 144, 159, 144, 154, 152, 141, 144, 150, 151, 195, 217 }, 249) + string.Join(_0x7b5cc563._0xab54347a(new byte[1] { 45 }, 36), _0x7d40c2a4));
                }
#endif
            }
        };
        try
        {
            _0x8fcf30e2 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x7b5cc563._0xab54347a(new byte[31] { 151, 152, 169, 191, 184, 145, 236, 138, 173, 165, 160, 169, 168, 236, 184, 163, 236, 171, 169, 184, 236, 188, 185, 191, 164, 236, 184, 163, 167, 169, 162 }, 204));
                }
#endif
            }

            _0x8fcf30e2 = "";
        }

        _0x7963a440 = !string.IsNullOrEmpty(_0x8fcf30e2);
        _0x238d7bf9 = _0x96e336c5();
        {
#if B_LOGS
            Debug.Log(_0x7b5cc563._0xab54347a(new byte[25] { 190, 177, 128, 150, 145, 184, 197, 176, 139, 140, 145, 156, 197, 181, 144, 150, 141, 197, 177, 138, 142, 128, 139, 223, 197 }, 229) + _0x8fcf30e2);
#endif
        }

        _0x35d08ad8.Instance?._0xa23ad7b8();
        return false;
    }

    internal bool IsHttpUrl(string _0x78350b29)
    {
        if (string.IsNullOrEmpty(_0x78350b29))
            return false;
        return _0x78350b29.StartsWith(_0x7b5cc563._0xab54347a(new byte[7] { 250, 230, 230, 226, 168, 189, 189 }, 146), StringComparison.OrdinalIgnoreCase) || _0x78350b29.StartsWith(_0x7b5cc563._0xab54347a(new byte[8] { 253, 225, 225, 229, 230, 175, 186, 186 }, 149), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x1124ca83 = "";
    private void _0x7f45caf5()
    {
        _0x42233c1b = true;
        if (_0x5ffac795 != null)
            _0x5ffac795.SetUserAgent(_0xc3e061f8());
    }

    // WS_SOURCE MONO
    public static _0x41ab2b98 _0xac2e2cd9 { get; private set; }

    private static readonly string WindowsDesktopUserAgent = _0x7b5cc563._0xab54347a(new byte[111] { 158, 188, 169, 186, 191, 191, 178, 252, 230, 253, 227, 243, 251, 132, 186, 189, 183, 188, 164, 160, 243, 157, 135, 243, 226, 227, 253, 227, 232, 243, 132, 186, 189, 229, 231, 232, 243, 171, 229, 231, 250, 243, 146, 163, 163, 191, 182, 132, 182, 177, 152, 186, 167, 252, 230, 224, 228, 253, 224, 229, 243, 251, 152, 155, 135, 158, 159, 255, 243, 191, 186, 184, 182, 243, 148, 182, 176, 184, 188, 250, 243, 144, 187, 161, 188, 190, 182, 252, 226, 225, 227, 253, 227, 253, 227, 253, 227, 243, 128, 178, 181, 178, 161, 186, 252, 230, 224, 228, 253, 224, 229 }, 211);
    internal bool IsAboutBlank(string _0xaf5bb996)
    {
        if (string.IsNullOrEmpty(_0xaf5bb996))
            return false;
        return _0xaf5bb996.StartsWith(_0x7b5cc563._0xab54347a(new byte[11] { 244, 247, 250, 224, 225, 175, 247, 249, 244, 251, 254 }, 149), StringComparison.OrdinalIgnoreCase);
    }

    private AndroidJavaObject _0x8256312a { get; set; }

    private JObject _0x489897c0(params string[] _0x0dc9f1cb)
    {
        JObject _0x3b0a4a7a = new JObject();
        foreach (var _0x6d445697 in _0x0dc9f1cb)
        {
            string _0xb6b47575 = _0x2d2e39eb();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0xb6b47575} val={_0x6d445697}");
#endif
            }

            _0x3b0a4a7a.Add(_0xb6b47575, _0x6d445697 == null ? "" : _0x6d445697);
        }

        return _0x3b0a4a7a;
    }

    private string _0x96e336c5()
    {
        float _0x8e99bb9b = Time.realtimeSinceStartup;
        if (_0x8e99bb9b < 0f)
            _0x8e99bb9b = 0f;
        int _0x877a92f8 = (int)(_0x8e99bb9b * 1000f);
        int _0x13153647 = _0x877a92f8 / 60000;
        int _0x3a19e7b2 = (_0x877a92f8 / 1000) % 60;
        int _0xff638314 = _0x877a92f8 % 1000;
        return string.Format(_0x7b5cc563._0xab54347a(new byte[21] { 194, 137, 131, 137, 137, 196, 131, 194, 136, 131, 137, 137, 196, 131, 194, 139, 131, 137, 137, 137, 196 }, 185), _0x13153647, _0x3a19e7b2, _0xff638314);
    }

    private bool TryOpenExternalLikeChrome(string _0x3b45ca10)
    {
        if (string.IsNullOrEmpty(_0x3b45ca10))
            return false;
        if (_0x3b45ca10.StartsWith(_0x7b5cc563._0xab54347a(new byte[9] { 3, 4, 30, 15, 4, 30, 80, 69, 69 }, 106), StringComparison.OrdinalIgnoreCase))
            return _0xd7807c8e(_0x3b45ca10);
        if (_0x88d7b00b(_0x3b45ca10))
            return _0x1cef3465(_0x3b45ca10, null);
        if (!_0x3b45ca10.StartsWith(_0x7b5cc563._0xab54347a(new byte[7] { 120, 100, 100, 96, 42, 63, 63 }, 16), StringComparison.OrdinalIgnoreCase) && !_0x3b45ca10.StartsWith(_0x7b5cc563._0xab54347a(new byte[8] { 205, 209, 209, 213, 214, 159, 138, 138 }, 165), StringComparison.OrdinalIgnoreCase) && !_0x3b45ca10.StartsWith(_0x7b5cc563._0xab54347a(new byte[11] { 1, 2, 15, 21, 20, 90, 2, 12, 1, 14, 11 }, 96), StringComparison.OrdinalIgnoreCase))
        {
            return _0xe10af77c(_0x3b45ca10);
        }

        return false;
    }

    // MAIN FLOW
    private bool _0x5395936d { get; set; }

    private string _0xe1da9aaa = "";
    private void _0x6dfac2b4(string _0x0bb77d65)
    {
        _0x6fdfbbc1();
        StartCoroutine(_0xcc71a69a(_0x0bb77d65));
    }

    internal void _0xe8f84fb5()
    {
        Rect _0xfba5c43a = Screen.safeArea;
        Vector2 _0x5c3d2353 = new Vector2(Screen.width, Screen.height);
        if (_0xfba5c43a == lastSafe && _0x5c3d2353 == lastSize)
            return;
        // Apply manual padding
        _0xfba5c43a.xMin += _0xb7898298;
        _0xfba5c43a.xMax -= _0x070e7474;
        _0xfba5c43a.yMin += _0xf1cc6d88;
        _0xfba5c43a.yMax -= _0x3b5d8534;
        // Convert Unity safe area -> native WebView frame
        Rect _0x772b671f = new Rect(_0xfba5c43a.x, _0x5c3d2353.y - _0xfba5c43a.y - _0xfba5c43a.height, // Y flip for native coordinate system
 _0xfba5c43a.width, _0xfba5c43a.height);
        _0x5ffac795.Frame = _0x772b671f;
        lastSafe = Screen.safeArea;
        lastSize = _0x5c3d2353;
    }

    public void _0xd93372f3()
    {
        if (_0xde5de23f)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x7b5cc563._0xab54347a(new byte[33] { 219, 212, 229, 243, 244, 221, 160, 212, 233, 237, 229, 242, 160, 239, 245, 244, 160, 173, 190, 160, 237, 239, 246, 229, 160, 244, 239, 160, 243, 227, 229, 238, 229 }, 128));
            }
#endif
        }

        _0xb665039c();
    }

    private string _0x1e17981f = "";
    private void _0x29b7d909()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private string _0xbb82621e(string _0x602d0599, string _0x383009d4)
    {
        if (string.IsNullOrEmpty(_0x383009d4))
            return _0x602d0599;
        if (_0x602d0599.Contains(_0x7b5cc563._0xab54347a(new byte[1] { 232 }, 215)))
            return _0x602d0599 + _0x7b5cc563._0xab54347a(new byte[8] { 58, 111, 121, 114, 120, 117, 120, 33 }, 28) + UnityWebRequest.EscapeURL(_0x383009d4);
        else
            return _0x602d0599 + _0x7b5cc563._0xab54347a(new byte[8] { 169, 229, 243, 248, 242, 255, 242, 171 }, 150) + UnityWebRequest.EscapeURL(_0x383009d4);
    }

    private string _0xc3e061f8()
    {
        if (string.IsNullOrEmpty(_0x5acf56cb) && _0x5ffac795 != null)
            _0x5acf56cb = _0x5ffac795.GetUserAgent();
        if (string.IsNullOrEmpty(_0x5acf56cb))
            return string.Empty;
        string _0xc735b7b8 = Regex.Replace(_0x5acf56cb, _0x7b5cc563._0xab54347a(new byte[11] { 58, 21, 76, 93, 58, 21, 76, 17, 16, 58, 4 }, 102), string.Empty);
        _0xc735b7b8 = Regex.Replace(_0xc735b7b8, _0x7b5cc563._0xab54347a(new byte[15] { 93, 114, 42, 67, 116, 104, 109, 101, 46, 90, 95, 58, 40, 92, 42 }, 1), string.Empty);
        _0xc735b7b8 = Regex.Replace(_0xc735b7b8, _0x7b5cc563._0xab54347a(new byte[15] { 202, 249, 238, 239, 245, 243, 242, 179, 168, 192, 178, 172, 192, 239, 182 }, 156), string.Empty);
        return Regex.Replace(_0xc735b7b8, _0x7b5cc563._0xab54347a(new byte[6] { 195, 236, 228, 173, 179, 226 }, 159), _0x7b5cc563._0xab54347a(new byte[1] { 151 }, 183)).Trim();
    }

    private bool _0x7963a440 = false;
    private string _0x8fcf30e2 = "";
    private static bool IsPrivacyItemTrue(Item _0x4e6969d7)
    {
        if (_0x4e6969d7.Key != _0x7b5cc563._0xab54347a(new byte[9] { 197, 223, 252, 222, 197, 218, 205, 207, 213 }, 172))
            return false;
        try
        {
            var _0x7d3706b3 = _0x4e6969d7.Value.GetAs<object>();
            return _0x7d3706b3 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private Text _0x67e92786;
    // NATIVE WEB VIEW METHODS
    private UniWebView _0x5ffac795 = null;
    private bool _0x721ed220(string _0x00630297)
    {
        if (string.IsNullOrEmpty(_0x00630297))
            return false;
        try
        {
            using (var _0xa738d5fd = new AndroidJavaClass(_0x7b5cc563._0xab54347a(new byte[30] { 60, 48, 50, 113, 42, 49, 54, 43, 38, 108, 59, 113, 47, 51, 62, 38, 58, 45, 113, 10, 49, 54, 43, 38, 15, 51, 62, 38, 58, 45 }, 95)))
            using (var _0x0889d271 = _0xa738d5fd.GetStatic<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[15] { 206, 216, 223, 223, 200, 195, 217, 236, 206, 217, 196, 219, 196, 217, 212 }, 173)))
            using (var _0x4e4ac8be = _0x0889d271.Call<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[17] { 211, 209, 192, 228, 213, 215, 223, 213, 211, 209, 249, 213, 218, 213, 211, 209, 198 }, 180)))
            using (var _0xc948163b = _0x4e4ac8be.Call<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[25] { 139, 137, 152, 160, 141, 153, 130, 143, 132, 165, 130, 152, 137, 130, 152, 170, 131, 158, 188, 141, 143, 135, 141, 139, 137 }, 236), _0x00630297))
            {
                if (_0xc948163b == null)
                    return false;
                WLog(_0x7b5cc563._0xab54347a(new byte[37] { 33, 10, 16, 13, 15, 7, 46, 11, 9, 7, 66, 14, 3, 23, 12, 1, 10, 66, 11, 12, 17, 22, 3, 14, 14, 7, 6, 66, 18, 3, 1, 9, 3, 5, 7, 88, 66 }, 98) + _0x00630297);
                _0xc948163b.Call<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[8] { 104, 109, 109, 79, 101, 104, 110, 122 }, 9), 0x10000000);
                _0x0889d271.Call(_0x7b5cc563._0xab54347a(new byte[13] { 146, 149, 128, 147, 149, 160, 130, 149, 136, 151, 136, 149, 152 }, 225), _0xc948163b);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private readonly string[] _0x2ddf52e1 = new string[]
    {
        _0x7b5cc563._0xab54347a(new byte[60] { 43, 68, 85, 107, 251, 143, 179, 190, 251, 169, 190, 190, 183, 168, 251, 186, 169, 190, 251, 179, 180, 175, 251, 169, 178, 188, 179, 175, 251, 181, 180, 172, 251, 57, 91, 72, 251, 191, 180, 181, 57, 91, 66, 175, 251, 182, 178, 168, 168, 251, 162, 180, 174, 169, 251, 168, 171, 178, 181, 250 }, 219),
        _0x7b5cc563._0xab54347a(new byte[52] { 218, 181, 167, 170, 10, 99, 94, 10, 73, 69, 95, 70, 78, 10, 72, 79, 10, 83, 69, 95, 88, 10, 70, 95, 73, 65, 83, 10, 71, 69, 71, 79, 68, 94, 10, 200, 170, 185, 10, 93, 66, 83, 10, 89, 94, 69, 90, 10, 68, 69, 93, 21 }, 42),
        _0x7b5cc563._0xab54347a(new byte[66] { 149, 237, 214, 152, 207, 248, 87, 53, 30, 16, 87, 0, 30, 25, 4, 87, 22, 5, 18, 87, 31, 30, 3, 3, 30, 25, 16, 87, 26, 24, 5, 18, 87, 24, 17, 3, 18, 25, 87, 3, 24, 19, 22, 14, 87, 149, 247, 228, 87, 4, 3, 22, 14, 87, 30, 25, 87, 3, 31, 18, 87, 16, 22, 26, 18, 89 }, 119),
        _0x7b5cc563._0xab54347a(new byte[54] { 16, 127, 117, 114, 192, 180, 136, 137, 147, 192, 137, 147, 192, 144, 146, 137, 141, 133, 192, 148, 137, 141, 133, 192, 2, 96, 115, 192, 148, 136, 133, 192, 130, 133, 147, 148, 192, 144, 140, 129, 153, 133, 146, 147, 192, 144, 140, 129, 153, 192, 142, 143, 151, 206 }, 224),
        _0x7b5cc563._0xab54347a(new byte[48] { 48, 95, 84, 101, 224, 153, 175, 181, 178, 224, 183, 169, 174, 174, 169, 174, 167, 224, 179, 180, 178, 165, 161, 171, 224, 163, 175, 181, 172, 164, 224, 162, 165, 224, 175, 174, 165, 224, 179, 176, 169, 174, 224, 161, 183, 161, 185, 238 }, 192),
        _0x7b5cc563._0xab54347a(new byte[65] { 114, 29, 24, 2, 162, 200, 227, 225, 233, 242, 237, 246, 241, 162, 227, 240, 231, 162, 239, 237, 240, 231, 162, 227, 225, 246, 235, 244, 231, 162, 246, 237, 236, 235, 229, 234, 246, 162, 96, 2, 17, 162, 241, 246, 227, 251, 162, 227, 236, 230, 162, 246, 240, 251, 162, 251, 237, 247, 240, 162, 238, 247, 225, 233, 172 }, 130),
        _0x7b5cc563._0xab54347a(new byte[55] { 62, 81, 64, 124, 238, 139, 184, 171, 188, 183, 238, 189, 190, 167, 160, 238, 173, 161, 187, 160, 186, 189, 238, 44, 78, 93, 238, 186, 166, 171, 238, 160, 171, 182, 186, 238, 161, 160, 171, 238, 173, 161, 187, 162, 170, 238, 172, 171, 238, 183, 161, 187, 188, 189, 224 }, 206),
        _0x7b5cc563._0xab54347a(new byte[63] { 39, 104, 85, 42, 125, 74, 229, 149, 169, 164, 188, 160, 183, 182, 229, 183, 172, 162, 173, 177, 229, 171, 170, 178, 229, 164, 183, 160, 229, 178, 172, 171, 171, 172, 171, 162, 229, 39, 69, 86, 229, 161, 170, 171, 39, 69, 92, 177, 229, 178, 164, 169, 174, 229, 164, 178, 164, 188, 229, 188, 160, 177, 235 }, 197),
        _0x7b5cc563._0xab54347a(new byte[51] { 181, 218, 202, 195, 101, 10, 43, 41, 60, 101, 49, 45, 42, 54, 32, 101, 50, 45, 42, 101, 54, 49, 36, 60, 101, 44, 43, 101, 49, 45, 32, 101, 34, 36, 40, 32, 101, 50, 44, 43, 101, 49, 45, 32, 101, 53, 55, 44, 63, 32, 107 }, 69),
        _0x7b5cc563._0xab54347a(new byte[64] { 147, 235, 208, 158, 201, 254, 81, 60, 30, 28, 20, 31, 5, 4, 28, 81, 24, 2, 81, 20, 7, 20, 3, 8, 5, 25, 24, 31, 22, 81, 147, 241, 226, 81, 26, 20, 20, 1, 81, 2, 1, 24, 31, 31, 24, 31, 22, 81, 23, 30, 3, 81, 8, 30, 4, 3, 81, 18, 25, 16, 31, 18, 20, 95 }, 113)
    };
    private void _0x46728a7d()
    {
        if (_0x4e460ab8)
        {
            WLog(_0x7b5cc563._0xab54347a(new byte[18] { 225, 220, 205, 208, 132, 197, 200, 214, 193, 197, 192, 221, 132, 215, 204, 203, 211, 202 }, 164));
            return;
        }

        _0xf8f33c07(false);
        WLog(_0x7b5cc563._0xab54347a(new byte[46] { 102, 74, 66, 69, 11, 124, 78, 73, 125, 66, 78, 92, 11, 123, 94, 88, 67, 11, 101, 68, 95, 66, 77, 66, 72, 74, 95, 66, 68, 69, 11, 3, 67, 74, 89, 79, 92, 74, 89, 78, 11, 73, 74, 72, 64, 2 }, 43));
        ++_0x008d997b;
        _0xa336794b();
        if (_0x008d997b <= 1)
            return;
        if (_0xfd45488b())
        {
            WLog(_0x7b5cc563._0xab54347a(new byte[37] { 218, 231, 246, 235, 191, 236, 244, 246, 239, 239, 250, 251, 191, 178, 161, 191, 239, 240, 239, 234, 239, 236, 191, 236, 235, 246, 243, 243, 191, 240, 239, 250, 241, 250, 251, 165, 191 }, 159) + _0x420c196b.Count);
            return;
        }

        Application.Quit();
    }

    private void OnApplicationPause(bool _0x93a425ea)
    {
        isApplicationPause = _0x93a425ea;
    }

    private void _0x86d55b90(UniWebView _0x571c54bd)
    {
        if (_0xc68adf74)
            return;
        _0xc68adf74 = true;
        _0x571c54bd.AddUrlScheme(_0x7b5cc563._0xab54347a(new byte[2] { 142, 157 }, 250));
        _0x571c54bd.AddUrlScheme(_0x7b5cc563._0xab54347a(new byte[6] { 96, 103, 125, 108, 103, 125 }, 9));
        _0x571c54bd.AddUrlScheme(_0x7b5cc563._0xab54347a(new byte[6] { 233, 229, 246, 239, 225, 240 }, 132));
        _0x571c54bd.OnMessageReceived += (_0x0c02d5bb, _0xdc5d16c7) =>
        {
            if (TryOpenExternalLikeChrome(_0xdc5d16c7.RawMessage))
            {
                _0xf8f33c07(false);
                return;
            }
        };
        _0x571c54bd.RegisterShouldHandleRequest(_0x39e26a8a =>
        {
            string _0xe47ed580 = _0x39e26a8a != null ? _0x39e26a8a.Url : string.Empty;
            if (string.IsNullOrEmpty(_0xe47ed580))
                return true;
            WLog(_0x7b5cc563._0xab54347a(new byte[21] { 80, 107, 108, 118, 111, 103, 75, 98, 109, 103, 111, 102, 81, 102, 114, 118, 102, 112, 119, 57, 35 }, 3) + _0xe47ed580);
            if (TryOpenExternalLikeChrome(_0xe47ed580))
            {
                _0xf8f33c07(false);
                return false;
            }

            if (_0x39e26a8a != null && _0x39e26a8a.IsMainFrame && IsGoogleAuthFlowUrl(_0xe47ed580) && !_0x42233c1b)
            {
                WLog(_0x7b5cc563._0xab54347a(new byte[62] { 3, 47, 39, 32, 110, 25, 43, 44, 24, 39, 43, 57, 110, 42, 43, 58, 43, 45, 58, 43, 42, 110, 9, 33, 33, 41, 34, 43, 110, 47, 59, 58, 38, 110, 27, 28, 2, 110, 99, 112, 110, 60, 43, 34, 33, 47, 42, 110, 57, 39, 58, 38, 110, 9, 33, 33, 41, 34, 43, 110, 27, 15 }, 78));
                _0x42233c1b = true;
                _0xf8f33c07(true);
                _0x5ffac795.SetUserAgent(_0xc3e061f8());
                _0x5ffac795.Load(_0xe47ed580);
                return false;
            }

            return true;
        });
        _0x571c54bd.OnLoadingErrorReceived += (_0x0c02d5bb, _0x08fb8abe, _0xdc5d16c7, _0x4e02f588) =>
        {
            WLog(_0x7b5cc563._0xab54347a(new byte[25] { 191, 147, 155, 156, 210, 165, 151, 144, 164, 155, 151, 133, 210, 183, 128, 128, 157, 128, 200, 210, 145, 157, 150, 151, 207 }, 242) + _0x08fb8abe + _0x7b5cc563._0xab54347a(new byte[9] { 37, 104, 96, 118, 118, 100, 98, 96, 56 }, 5) + _0xdc5d16c7);
            string _0x5426022f = GetFailingUrl(_0x4e02f588);
            if (string.IsNullOrEmpty(_0x5426022f) || IsAboutBlank(_0x5426022f))
                return;
            _ = _0x3b026a8a(_0x7b5cc563._0xab54347a(new byte[8] { 64, 65, 104, 82, 69, 69, 88, 69 }, 55));
            WLog(_0x7b5cc563._0xab54347a(new byte[45] { 193, 237, 229, 226, 172, 219, 233, 238, 218, 229, 233, 251, 172, 234, 237, 229, 224, 229, 226, 235, 172, 217, 222, 192, 172, 161, 178, 172, 227, 252, 233, 226, 172, 233, 244, 248, 233, 254, 226, 237, 224, 224, 245, 182, 172 }, 140) + _0x5426022f);
            StopCurrentFailedLoad(_0x0c02d5bb);
            _0x167cd2e0(_0x5426022f);
        };
        _0x571c54bd.OnPageStarted += (_0x0c02d5bb, _0xd0f37762) =>
        {
            _0x008d997b = 0;
            if (_0x49605254 && IsAboutBlank(_0xd0f37762))
            {
                WLog(_0x7b5cc563._0xab54347a(new byte[27] { 59, 25, 14, 28, 10, 25, 6, 75, 10, 9, 4, 30, 31, 81, 9, 7, 10, 5, 0, 75, 24, 31, 10, 25, 31, 14, 15 }, 107));
                return;
            }

            WLog(_0x7b5cc563._0xab54347a(new byte[29] { 184, 148, 156, 155, 213, 162, 144, 151, 163, 156, 144, 130, 213, 186, 155, 165, 148, 146, 144, 166, 129, 148, 135, 129, 144, 145, 207, 213, 222 }, 245) + (Time.realtimeSinceStartup - _0x6ccb3d38).ToString(_0x7b5cc563._0xab54347a(new byte[5] { 168, 182, 168, 168, 168 }, 152)) + _0x7b5cc563._0xab54347a(new byte[2] { 48, 99 }, 67) + _0xd0f37762);
            if (TryOpenExternalLikeChrome(_0xd0f37762))
            {
                StopCurrentFailedLoad(_0x0c02d5bb);
                return;
            }

            if (ContainsIgnoreCase(_0xd0f37762, _0x7b5cc563._0xab54347a(new byte[8] { 18, 31, 31, 23, 88, 23, 6, 6 }, 118)) || ContainsIgnoreCase(_0xd0f37762, _0x7b5cc563._0xab54347a(new byte[15] { 29, 12, 20, 67, 26, 4, 9, 10, 8, 25, 67, 15, 1, 2, 10 }, 109)) || _0xd0f37762.StartsWith(_0x7b5cc563._0xab54347a(new byte[25] { 80, 76, 76, 72, 75, 2, 23, 23, 90, 72, 95, 84, 87, 90, 89, 84, 94, 89, 78, 22, 84, 81, 78, 93, 23 }, 56), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x0c02d5bb);
                OpenUrlExternally(_0xd0f37762);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0xd0f37762))
            {
                _0xf8f33c07(true);
                WLog(_0x7b5cc563._0xab54347a(new byte[41] { 154, 178, 178, 186, 177, 184, 253, 188, 168, 169, 181, 253, 187, 177, 178, 170, 253, 185, 184, 169, 184, 190, 169, 184, 185, 253, 240, 227, 253, 182, 184, 184, 173, 253, 171, 180, 174, 180, 191, 177, 184 }, 221));
                return;
            }

            _0xa218b5cc = true;
            _0xf8f33c07(true);
            WLog(_0x7b5cc563._0xab54347a(new byte[43] { 240, 194, 197, 241, 206, 194, 208, 135, 203, 200, 198, 195, 206, 201, 192, 136, 213, 194, 195, 206, 213, 194, 196, 211, 206, 201, 192, 135, 138, 153, 135, 204, 194, 194, 215, 135, 209, 206, 212, 206, 197, 203, 194 }, 167));
        };
        _0x571c54bd.OnPageCommitted += (_0x0c02d5bb, _0xd0f37762) =>
        {
            if (_0x49605254 && IsAboutBlank(_0xd0f37762))
                return;
            WLog(_0x7b5cc563._0xab54347a(new byte[31] { 63, 19, 27, 28, 82, 37, 23, 16, 36, 27, 23, 5, 82, 61, 28, 34, 19, 21, 23, 49, 29, 31, 31, 27, 6, 6, 23, 22, 72, 82, 89 }, 114) + (Time.realtimeSinceStartup - _0x6ccb3d38).ToString(_0x7b5cc563._0xab54347a(new byte[5] { 189, 163, 189, 189, 189 }, 141)) + _0x7b5cc563._0xab54347a(new byte[2] { 165, 246 }, 214) + _0xd0f37762);
            if (!firstLoadShown && IsHttpUrl(_0xd0f37762))
            {
                firstLoadShown = true;
                _0xa218b5cc = false;
                _0xf8f33c07(false);
                _0x29b7d909();
                _0xe8f84fb5();
                _0x0c02d5bb.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x3b026a8a(_0x7b5cc563._0xab54347a(new byte[9] { 249, 248, 209, 225, 254, 235, 224, 235, 234 }, 142));
                WLog(_0x7b5cc563._0xab54347a(new byte[39] { 169, 133, 141, 138, 196, 179, 129, 134, 178, 141, 129, 147, 196, 151, 140, 139, 147, 138, 196, 139, 138, 196, 135, 139, 137, 137, 141, 144, 144, 129, 128, 196, 135, 139, 138, 144, 129, 138, 144 }, 228));
            }
        };
        _0x571c54bd.OnPageProgressChanged += (_0x0c02d5bb, _0xdf831a83) =>
        {
            if (_0x49605254)
                return;
            if (!firstLoadShown && _0xdf831a83 >= 0.65f)
            {
                firstLoadShown = true;
                _0xa218b5cc = false;
                _0xf8f33c07(false);
                _0x29b7d909();
                _0xe8f84fb5();
                _0x0c02d5bb.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x3b026a8a(_0x7b5cc563._0xab54347a(new byte[9] { 88, 89, 112, 64, 95, 74, 65, 74, 75 }, 47));
                WLog(_0x7b5cc563._0xab54347a(new byte[32] { 50, 30, 22, 17, 95, 40, 26, 29, 41, 22, 26, 8, 95, 12, 23, 16, 8, 17, 95, 29, 6, 95, 15, 13, 16, 24, 13, 26, 12, 12, 69, 95 }, 127) + _0xdf831a83);
            }
        };
        _0x571c54bd.OnPageFinished += (_0x0c02d5bb, _0x08fb8abe, _0xd0f37762) =>
        {
            if (_0x49605254 && IsAboutBlank(_0xd0f37762))
            {
                _0x49605254 = false;
                WLog(_0x7b5cc563._0xab54347a(new byte[28] { 239, 205, 218, 200, 222, 205, 210, 159, 222, 221, 208, 202, 203, 133, 221, 211, 222, 209, 212, 159, 217, 214, 209, 214, 204, 215, 218, 219 }, 191));
                return;
            }

            WLog(_0x7b5cc563._0xab54347a(new byte[24] { 24, 52, 60, 59, 117, 2, 48, 55, 3, 60, 48, 34, 117, 19, 60, 59, 60, 38, 61, 48, 49, 111, 117, 126 }, 85) + (Time.realtimeSinceStartup - _0x6ccb3d38).ToString(_0x7b5cc563._0xab54347a(new byte[5] { 125, 99, 125, 125, 125 }, 77)) + _0x7b5cc563._0xab54347a(new byte[7] { 188, 239, 172, 160, 171, 170, 242 }, 207) + _0x08fb8abe + _0x7b5cc563._0xab54347a(new byte[5] { 1, 84, 83, 77, 28 }, 33) + _0xd0f37762);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0xa218b5cc = false;
                _0xf8f33c07(false);
                _0x29b7d909();
                _0xe8f84fb5();
                _0x0c02d5bb.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x3b026a8a(_0x7b5cc563._0xab54347a(new byte[9] { 248, 249, 208, 224, 255, 234, 225, 234, 235 }, 143));
                WLog(_0x7b5cc563._0xab54347a(new byte[33] { 186, 150, 158, 153, 215, 160, 146, 149, 161, 158, 146, 128, 215, 145, 158, 133, 132, 131, 215, 155, 152, 150, 147, 215, 148, 152, 154, 135, 155, 146, 131, 146, 147 }, 247));
            }
            else if (_0xa218b5cc)
            {
                _0xa218b5cc = false;
                _0xf8f33c07(false);
                _0x0c02d5bb.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x7b5cc563._0xab54347a(new byte[40] { 56, 20, 28, 27, 85, 34, 16, 23, 35, 28, 16, 2, 85, 38, 29, 26, 2, 85, 20, 19, 1, 16, 7, 85, 25, 26, 20, 17, 28, 27, 18, 85, 19, 28, 27, 28, 6, 29, 16, 17 }, 117));
            }
            else
            {
                _0xf8f33c07(false);
            }

            if (_0x42233c1b && !IsGoogleAuthFlowUrl(_0xd0f37762) && !IsGoogleAuthFlowUrl(_0xd0f37762))
            {
                WLog(_0x7b5cc563._0xab54347a(new byte[48] { 95, 119, 119, 127, 116, 125, 56, 121, 109, 108, 112, 56, 107, 125, 125, 117, 107, 56, 126, 113, 118, 113, 107, 112, 125, 124, 56, 53, 38, 56, 106, 125, 107, 108, 119, 106, 125, 56, 124, 125, 126, 121, 109, 116, 108, 56, 77, 89 }, 24));
                _0x42233c1b = false;
                _0x5ffac795.SetUserAgent("");
            }
        };
        _0x571c54bd.OnShouldClose += _0x0c02d5bb =>
        {
            WLog(_0x7b5cc563._0xab54347a(new byte[41] { 234, 229, 212, 194, 197, 236, 145, 252, 208, 216, 223, 145, 230, 212, 211, 231, 216, 212, 198, 145, 254, 223, 226, 217, 222, 196, 221, 213, 242, 221, 222, 194, 212, 145, 216, 223, 199, 222, 218, 212, 213 }, 177));
            _0x3c8c7275();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x571c54bd.SetPopupPageEventEnabled(true);
        bool _0x8a723042 = false;
        bool _0x5813cc97 = false;
        _0x571c54bd.OnMultipleWindowOpened += (_0x0c02d5bb, _0x0a7251f7) =>
        {
            _0x0c02d5bb.ScrollTo(0, 0, false);
            WLog(_0x7b5cc563._0xab54347a(new byte[43] { 12, 3, 50, 36, 35, 10, 119, 26, 54, 62, 57, 119, 0, 50, 53, 1, 62, 50, 32, 119, 26, 34, 59, 35, 62, 39, 59, 50, 0, 62, 57, 51, 56, 32, 119, 24, 39, 50, 57, 50, 51, 109, 119 }, 87) + _0x0a7251f7);
            var _0x18ea6f15 = _0x571c54bd.GetPopupWindow(_0x0a7251f7);
            if (_0x18ea6f15 == null)
                return;
            _0x420c196b.Add(_0x18ea6f15);
            Debug.Log($"[Test] Popup ID: {_0x18ea6f15.Id}");
            _0x18ea6f15.OnPageStarted += (_0x69704958, _0xd0f37762) =>
            {
                WLog(_0x7b5cc563._0xab54347a(new byte[36] { 113, 126, 79, 89, 94, 119, 10, 122, 69, 90, 95, 90, 10, 125, 79, 72, 124, 67, 79, 93, 10, 101, 68, 122, 75, 77, 79, 121, 94, 75, 88, 94, 79, 78, 16, 10 }, 42) + _0xd0f37762);
                _0x008d997b = 0;
                if (string.IsNullOrEmpty(_0xd0f37762) || IsAboutBlank(_0xd0f37762))
                    return;
                if (IsGoogleAuthFlowUrl(_0xd0f37762))
                {
                    WLog(_0x7b5cc563._0xab54347a(new byte[57] { 234, 229, 212, 194, 197, 236, 145, 225, 222, 193, 196, 193, 145, 246, 222, 222, 214, 221, 212, 145, 208, 196, 197, 217, 145, 215, 221, 222, 198, 145, 156, 143, 145, 194, 193, 222, 222, 215, 145, 246, 222, 222, 214, 221, 212, 145, 242, 217, 195, 222, 220, 212, 145, 228, 240, 139, 145 }, 177) + _0xd0f37762);
                    _0x8a723042 = false;
                    _0x7f45caf5();
                    if (_0x69704958 != null && _0x69704958.IsAlive)
                        _0x69704958.EvaluateJavaScript(_0xadd40a60());
                    return;
                }

                if (_0x5ffac795 == null)
                    return;
                if (!_0x8a723042)
                {
                    _0x8a723042 = true;
                    _0x5ffac795.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x7b5cc563._0xab54347a(new byte[39] { 197, 202, 251, 237, 234, 195, 190, 206, 241, 238, 235, 238, 190, 255, 238, 238, 242, 231, 190, 201, 247, 240, 250, 241, 233, 237, 190, 250, 251, 237, 245, 234, 241, 238, 190, 203, 223, 164, 190 }, 158) + _0xd0f37762);
                }

                if (_0x69704958 != null && _0x69704958.IsAlive)
                    _0x69704958.EvaluateJavaScript(_0xa1c5df3f());
                if (!_0x5813cc97 && _0x69704958 != null && _0x69704958.IsAlive && IsHttpUrl(_0xd0f37762))
                {
                    _0x5813cc97 = true;
                }
            };
            _0x18ea6f15.OnPageFinished += (_0x69704958, _0x4e02f588) =>
            {
                string _0x5789fcfb = _0x4e02f588 != null ? _0x4e02f588.data : string.Empty;
                WLog(_0x7b5cc563._0xab54347a(new byte[35] { 53, 58, 11, 29, 26, 51, 78, 62, 1, 30, 27, 30, 78, 57, 11, 12, 56, 7, 11, 25, 78, 40, 7, 0, 7, 29, 6, 11, 10, 84, 78, 27, 28, 2, 83 }, 110) + _0x5789fcfb);
                if (_0x69704958 == null || !_0x69704958.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x5789fcfb))
                {
                    _0x7f45caf5();
                    _0x69704958.EvaluateJavaScript(_0xadd40a60());
                    return;
                }

                if (!_0x8a723042)
                    return;
                _0x69704958.EvaluateJavaScript(_0xa1c5df3f());
            };
        };
        _0x571c54bd.OnMultipleWindowClosed += (_0x0c02d5bb, _0x0a7251f7) =>
        {
            _0x420c196b.RemoveAll(_0x336814fa => _0x336814fa == null || _0x336814fa.Id == _0x0a7251f7 || !_0x336814fa.IsAlive);
            _0xf8f33c07(false);
            if (_0x420c196b.Count == 0 && _0x5ffac795 != null)
            {
                _0x8a723042 = false;
                _0x5813cc97 = false;
                _0x2fd59684();
            }

            WLog(_0x7b5cc563._0xab54347a(new byte[43] { 94, 81, 96, 118, 113, 88, 37, 72, 100, 108, 107, 37, 82, 96, 103, 83, 108, 96, 114, 37, 72, 112, 105, 113, 108, 117, 105, 96, 82, 108, 107, 97, 106, 114, 37, 70, 105, 106, 118, 96, 97, 63, 37 }, 5) + _0x0a7251f7);
        };
        _0x571c54bd.RegisterOnRequestMediaCapturePermission(_0x39e26a8a =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private async Task<bool> _0xa749abc1(int _0x23154a8e = 5, int _0xc7088ca0 = 500)
    {
        List<EntityData> _0x0c4008ac = new List<EntityData>();
        int _0x7f8d30fc = 0;
        do
        {
            try
            {
                _0x0c4008ac = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x7b5cc563._0xab54347a(new byte[8] { 219, 199, 202, 210, 206, 217, 226, 207 }, 171), _0x7b8c3c49, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x7b5cc563._0xab54347a(new byte[9] { 38, 60, 31, 61, 38, 57, 46, 44, 54 }, 79) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x7b5cc563._0xab54347a(new byte[32] { 229, 234, 219, 205, 202, 227, 158, 207, 203, 219, 204, 199, 255, 205, 199, 208, 221, 236, 219, 205, 203, 210, 202, 205, 158, 219, 204, 204, 209, 204, 132, 158 }, 190) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0xc7088ca0);
        }
        while (_0x0c4008ac.Count == 0 && _0x7f8d30fc++ < _0x23154a8e);
        {
#if B_LOGS
            {
                Debug.Log(_0x7b5cc563._0xab54347a(new byte[32] { 218, 213, 228, 242, 245, 220, 161, 200, 242, 209, 243, 232, 247, 224, 226, 248, 161, 208, 244, 228, 243, 248, 161, 243, 228, 242, 244, 237, 245, 242, 187, 161 }, 129) + JsonConvert.SerializeObject(_0x0c4008ac, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x7b5cc563._0xab54347a(new byte[38] { 19, 28, 45, 59, 60, 21, 104, 1, 59, 24, 58, 33, 62, 41, 43, 49, 104, 25, 61, 45, 58, 49, 104, 58, 45, 59, 61, 36, 60, 59, 104, 43, 39, 61, 38, 60, 114, 104 }, 72) + _0x0c4008ac.Count);
            }
#endif
        }

        bool _0x64ec5fac = true;
        if (_0x0c4008ac.Count == 0)
        {
            _0x64ec5fac = false;
        }
        else
        {
            _0x64ec5fac = _0x0c4008ac.Any(_0x97d261fd => _0x97d261fd.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x7b5cc563._0xab54347a(new byte[25] { 38, 41, 24, 14, 9, 32, 93, 52, 14, 45, 15, 20, 11, 28, 30, 4, 93, 15, 24, 14, 8, 17, 9, 71, 93 }, 125) + _0x64ec5fac);
            }
#endif
        }

        return _0x64ec5fac;
    }

    private int _0x3b5d8534 = 5, _0xf1cc6d88 = 5, _0xb7898298 = 5, _0x070e7474 = 5;
    private IEnumerator _0xeadbd7c7()
    {
        yield return _0x32ccdfeb(Permission.Camera);
    }

    private bool _0x1cef3465(string _0x1682c4a5, string _0x000134b0)
    {
        string _0x65fbfef9 = _0x2fbcfb75(_0x1682c4a5);
        if (string.IsNullOrEmpty(_0x65fbfef9))
            _0x65fbfef9 = _0x000134b0;
        if (_0x721ed220(_0x65fbfef9))
            return true;
        string _0x4cf1885c = string.IsNullOrEmpty(_0x65fbfef9) ? _0x7b5cc563._0xab54347a(new byte[29] { 101, 121, 121, 125, 126, 55, 34, 34, 125, 97, 108, 116, 35, 106, 98, 98, 106, 97, 104, 35, 110, 98, 96, 34, 126, 121, 98, 127, 104 }, 13) : _0x7b5cc563._0xab54347a(new byte[46] { 9, 21, 21, 17, 18, 91, 78, 78, 17, 13, 0, 24, 79, 6, 14, 14, 6, 13, 4, 79, 2, 14, 12, 78, 18, 21, 14, 19, 4, 78, 0, 17, 17, 18, 78, 5, 4, 21, 0, 8, 13, 18, 94, 8, 5, 92 }, 97) + _0x65fbfef9;
        WLog(_0x7b5cc563._0xab54347a(new byte[35] { 205, 230, 252, 225, 227, 235, 194, 231, 229, 235, 174, 227, 239, 252, 229, 235, 250, 174, 232, 239, 226, 226, 236, 239, 237, 229, 174, 239, 253, 174, 249, 235, 236, 180, 174 }, 142) + _0x4cf1885c);
        return _0xe10af77c(_0x4cf1885c);
    }

    private void _0x18d78598(string _0xfc220488)
    {
        Dictionary<string, object> _0x7b6ea25c;
        try
        {
            _0x7b6ea25c = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xfc220488);
        }
        catch
        {
            return;
        }

        var _0x5516acef = ReadPushField(_0x7b6ea25c, _0x7b5cc563._0xab54347a(new byte[3] { 18, 21, 11 }, 103));
        if (string.IsNullOrWhiteSpace(_0x5516acef))
            return;
        _0x5516acef = _0x5516acef.Trim();
        if (!IsHttpUrl(_0x5516acef))
            return;
        if (string.Equals(_0x5516acef, _0x62d63e31, StringComparison.Ordinal))
            return;
        _0x62d63e31 = _0x5516acef;
        OpenUrlExternally(_0x5516acef);
    }

    internal Rect lastSafe = Rect.zero;
    private async Task _0x3d8dc435()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x2f11610c = _0x7b5cc563._0xab54347a(new byte[5] { 174, 169, 164, 187, 173 }, 200);
        _0x1124ca83 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x8ed3b386 = DateTime.UtcNow.Ticks.ToString();
        _0x437c9393 = "";
        JObject _0x2dce974a = _0x489897c0(_0x943e9c12, _0x14c4a046, _0xe1da9aaa, _0x8fcf30e2, _0x9124152c, _0x23a6b285, _0x5d4aeebc, _0x5acf56cb, _0x4da1342b, _0x5090c9e4, _0x2f11610c, _0x437c9393, _0x6dbf19fa, _0x3572078c, _0x7a055526.ToString(), _0xa172b7c6, _0x8ed3b386, _0x1124ca83, _0x7b8c3c49, _0x624b8acb, _0xf09dcafd, _0x238d7bf9, _0x96e336c5());
        var _0xc25cba08 = _0xc0a3f25f(_0x2dce974a.ToString(), _0x7b8c3c49);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x2dce974a}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x7b5cc563._0xab54347a(new byte[7] { 67, 82, 74, 95, 92, 82, 87 }, 51) + _0x7b8c3c49, _0xc25cba08 } });
            await Task.Delay(500);
            string _0xbb0f7169 = "";
            for (int _0x233015aa = 0; _0x233015aa < 20; _0x233015aa++)
            {
                if (await _0xa749abc1(1, 1))
                {
                    await _0x3b026a8a(_0x7b5cc563._0xab54347a(new byte[7] { 254, 240, 243, 255, 247, 249, 248 }, 156));
                    _0xb665039c();
                    return;
                }

                _0xbb0f7169 = await _0x98a092be(1, 500);
                if (!string.IsNullOrEmpty(_0xbb0f7169))
                    break;
            }

            _0x153a37ba(_0xbb0f7169);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x7b5cc563._0xab54347a(new byte[22] { 156, 147, 130, 148, 147, 154, 231, 128, 162, 169, 162, 181, 166, 171, 231, 162, 181, 181, 168, 181, 253, 231 }, 199) + e.Message);
#endif
            }

            _0xb665039c();
        }
    }

    private string _0x437c9393 = "";
    internal void Update()
    {
        if (_0x5ffac795 == null)
            return;
        if (_0x240590a0())
            _0x3c8c7275();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xe8f84fb5();
        if (_0xfde49a69 && _0x2a0f218b != null)
            _0x2a0f218b.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private string _0x5acf56cb = "";
    private string _0x8ed3b386 = "";
    private void Awake()
    {
        if (_0xac2e2cd9 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0xac2e2cd9 = gameObject.GetComponent<_0x41ab2b98>();
        DontDestroyOnLoad(gameObject);
        _0x8fcf30e2 = _0x23a6b285 = _0x5d4aeebc = "";
        _0x1e17981f = "";
        _0xde5de23f = false;
    }

    private string _0x238d7bf9 = "";
    private string _0x624b8acb = "";
    private string _0x2f11610c = "";
    private bool _0xd7807c8e(string _0x21ba86ac)
    {
        try
        {
            using (var _0xfbd7c9ad = new AndroidJavaClass(_0x7b5cc563._0xab54347a(new byte[30] { 14, 2, 0, 67, 24, 3, 4, 25, 20, 94, 9, 67, 29, 1, 12, 20, 8, 31, 67, 56, 3, 4, 25, 20, 61, 1, 12, 20, 8, 31 }, 109)))
            using (var _0xe8c5c704 = _0xfbd7c9ad.GetStatic<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[15] { 64, 86, 81, 81, 70, 77, 87, 98, 64, 87, 74, 85, 74, 87, 90 }, 35)))
            using (var _0x755eb63b = _0xe8c5c704.Call<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[17] { 50, 48, 33, 5, 52, 54, 62, 52, 50, 48, 24, 52, 59, 52, 50, 48, 39 }, 85)))
            using (var _0x36ff2200 = new AndroidJavaClass(_0x7b5cc563._0xab54347a(new byte[22] { 226, 237, 231, 241, 236, 234, 231, 173, 224, 236, 237, 247, 230, 237, 247, 173, 202, 237, 247, 230, 237, 247 }, 131)))
            using (var _0x64564bdf = _0x36ff2200.CallStatic<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[8] { 254, 239, 252, 253, 235, 219, 252, 231 }, 142), _0x21ba86ac, 1))
            {
                string _0x63e9aca4 = _0x64564bdf.Call<string>(_0x7b5cc563._0xab54347a(new byte[14] { 249, 251, 234, 205, 234, 236, 247, 240, 249, 219, 230, 234, 236, 255 }, 158), _0x7b5cc563._0xab54347a(new byte[20] { 212, 196, 217, 193, 197, 211, 196, 233, 208, 215, 218, 218, 212, 215, 213, 221, 233, 195, 196, 218 }, 182));
                string _0xa0cca7a2 = _0x64564bdf.Call<string>(_0x7b5cc563._0xab54347a(new byte[10] { 1, 3, 18, 54, 7, 5, 13, 7, 1, 3 }, 102));
                _0x64564bdf.Call<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[11] { 10, 15, 15, 40, 10, 31, 14, 12, 4, 25, 18 }, 107), _0x7b5cc563._0xab54347a(new byte[33] { 187, 180, 190, 168, 181, 179, 190, 244, 179, 180, 174, 191, 180, 174, 244, 185, 187, 174, 191, 189, 181, 168, 163, 244, 152, 136, 149, 141, 137, 155, 152, 150, 159 }, 218));
                _0x64564bdf.Call<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[11] { 143, 152, 144, 146, 139, 152, 184, 133, 137, 143, 156 }, 253), _0x7b5cc563._0xab54347a(new byte[20] { 70, 86, 75, 83, 87, 65, 86, 123, 66, 69, 72, 72, 70, 69, 71, 79, 123, 81, 86, 72 }, 36));
                if (_0x64564bdf.Call<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[15] { 94, 73, 95, 67, 64, 90, 73, 109, 79, 88, 69, 90, 69, 88, 85 }, 44), _0x755eb63b) != null)
                {
                    WLog(_0x7b5cc563._0xab54347a(new byte[24] { 135, 172, 182, 171, 169, 161, 136, 173, 175, 161, 228, 171, 180, 161, 170, 228, 173, 170, 176, 161, 170, 176, 254, 228 }, 196) + _0x21ba86ac);
                    _0x64564bdf.Call<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[8] { 119, 114, 114, 80, 122, 119, 113, 101 }, 22), 0x10000000);
                    _0xe8c5c704.Call(_0x7b5cc563._0xab54347a(new byte[13] { 125, 122, 111, 124, 122, 79, 109, 122, 103, 120, 103, 122, 119 }, 14), _0x64564bdf);
                    return true;
                }

                if (_0x721ed220(_0xa0cca7a2))
                    return true;
                if (!string.IsNullOrEmpty(_0x63e9aca4))
                {
                    WLog(_0x7b5cc563._0xab54347a(new byte[28] { 111, 68, 94, 67, 65, 73, 96, 69, 71, 73, 12, 69, 66, 88, 73, 66, 88, 12, 74, 77, 64, 64, 78, 77, 79, 71, 22, 12 }, 44) + _0x63e9aca4);
                    if (_0x88d7b00b(_0x63e9aca4))
                        return _0x1cef3465(_0x63e9aca4, _0xa0cca7a2);
                    return _0xe10af77c(_0x63e9aca4);
                }

                WLog(_0x7b5cc563._0xab54347a(new byte[30] { 73, 98, 120, 101, 103, 111, 70, 99, 97, 111, 42, 99, 100, 126, 111, 100, 126, 42, 100, 101, 42, 98, 107, 100, 110, 102, 111, 120, 48, 42 }, 10) + _0x21ba86ac);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x7b5cc563._0xab54347a(new byte[26] { 71, 108, 118, 107, 105, 97, 72, 109, 111, 97, 36, 109, 106, 112, 97, 106, 112, 36, 98, 101, 109, 104, 97, 96, 62, 36 }, 4) + e.Message);
            return true;
        }
    }

    private string _0xadd40a60()
    {
        string _0xfc625dec = _0xc3e061f8();
        if (string.IsNullOrEmpty(_0xfc625dec))
            return _0x7b5cc563._0xab54347a(new byte[7] { 255, 230, 224, 237, 169, 185, 178 }, 137);
        string _0x7c755420 = _0xfc625dec.Replace(_0x7b5cc563._0xab54347a(new byte[1] { 112 }, 44), _0x7b5cc563._0xab54347a(new byte[2] { 99, 99 }, 63)).Replace(_0x7b5cc563._0xab54347a(new byte[1] { 0 }, 39), _0x7b5cc563._0xab54347a(new byte[2] { 241, 138 }, 173));
        var _0xcedcfb53 = Regex.Match(_0xfc625dec, _0x7b5cc563._0xab54347a(new byte[12] { 116, 95, 69, 88, 90, 82, 24, 31, 107, 83, 28, 30 }, 55));
        string _0xbca2b684 = _0xcedcfb53.Success ? _0xcedcfb53.Groups[1].Value : _0x7b5cc563._0xab54347a(new byte[3] { 115, 112, 114 }, 66);
        return _0x7b5cc563._0xab54347a(new byte[12] { 96, 46, 61, 38, 43, 60, 33, 39, 38, 96, 97, 51 }, 72) + _0x7b5cc563._0xab54347a(new byte[8] { 156, 139, 152, 202, 159, 139, 215, 205 }, 234) + _0x7c755420 + _0x7b5cc563._0xab54347a(new byte[2] { 101, 121 }, 66) + _0x7b5cc563._0xab54347a(new byte[30] { 207, 216, 203, 153, 201, 203, 214, 205, 214, 132, 247, 216, 207, 208, 222, 216, 205, 214, 203, 151, 201, 203, 214, 205, 214, 205, 192, 201, 220, 130 }, 185) + _0x7b5cc563._0xab54347a(new byte[121] { 163, 176, 171, 166, 177, 172, 170, 171, 229, 161, 160, 163, 237, 170, 167, 175, 233, 174, 160, 188, 233, 179, 164, 169, 236, 190, 177, 183, 188, 190, 138, 167, 175, 160, 166, 177, 235, 161, 160, 163, 172, 171, 160, 149, 183, 170, 181, 160, 183, 177, 188, 237, 170, 167, 175, 233, 174, 160, 188, 233, 190, 162, 160, 177, 255, 163, 176, 171, 166, 177, 172, 170, 171, 237, 236, 190, 183, 160, 177, 176, 183, 171, 229, 179, 164, 169, 254, 184, 233, 166, 170, 171, 163, 172, 162, 176, 183, 164, 167, 169, 160, 255, 177, 183, 176, 160, 184, 236, 254, 184, 166, 164, 177, 166, 173, 237, 160, 236, 190, 184, 184 }, 197) + _0x7b5cc563._0xab54347a(new byte[26] { 160, 161, 162, 236, 180, 182, 171, 176, 171, 232, 227, 177, 183, 161, 182, 133, 163, 161, 170, 176, 227, 232, 177, 165, 237, 255 }, 196) + _0x7b5cc563._0xab54347a(new byte[52] { 179, 178, 177, 255, 167, 165, 184, 163, 184, 251, 240, 182, 167, 167, 129, 178, 165, 164, 190, 184, 185, 240, 251, 162, 182, 249, 165, 178, 167, 187, 182, 180, 178, 255, 248, 137, 154, 184, 173, 190, 187, 187, 182, 139, 248, 248, 251, 240, 240, 254, 254, 236 }, 215) + _0x7b5cc563._0xab54347a(new byte[37] { 43, 42, 41, 103, 63, 61, 32, 59, 32, 99, 104, 63, 35, 46, 59, 41, 32, 61, 34, 104, 99, 104, 3, 38, 33, 58, 55, 111, 46, 61, 34, 57, 119, 35, 104, 102, 116 }, 79) + _0x7b5cc563._0xab54347a(new byte[34] { 32, 33, 34, 108, 52, 54, 43, 48, 43, 104, 99, 50, 33, 42, 32, 43, 54, 99, 104, 99, 3, 43, 43, 35, 40, 33, 100, 13, 42, 39, 106, 99, 109, 127 }, 68) + _0x7b5cc563._0xab54347a(new byte[30] { 81, 80, 83, 29, 69, 71, 90, 65, 90, 25, 18, 88, 84, 77, 97, 90, 64, 86, 93, 101, 90, 92, 91, 65, 70, 18, 25, 0, 28, 14 }, 53) + _0x7b5cc563._0xab54347a(new byte[48] { 160, 166, 173, 175, 162, 181, 166, 244, 161, 181, 176, 233, 175, 182, 166, 181, 186, 176, 167, 238, 143, 175, 182, 166, 181, 186, 176, 238, 243, 151, 188, 166, 187, 185, 189, 161, 185, 243, 248, 162, 177, 166, 167, 189, 187, 186, 238, 243 }, 212) + _0xbca2b684 + _0x7b5cc563._0xab54347a(new byte[35] { 8, 82, 3, 84, 77, 93, 78, 65, 75, 21, 8, 104, 64, 64, 72, 67, 74, 15, 108, 71, 93, 64, 66, 74, 8, 3, 89, 74, 93, 92, 70, 64, 65, 21, 8 }, 47) + _0xbca2b684 + _0x7b5cc563._0xab54347a(new byte[238] { 55, 109, 60, 107, 114, 98, 113, 126, 116, 42, 55, 94, 127, 100, 45, 81, 47, 82, 98, 113, 126, 116, 55, 60, 102, 117, 98, 99, 121, 127, 126, 42, 55, 34, 36, 55, 109, 77, 60, 125, 127, 114, 121, 124, 117, 42, 100, 98, 101, 117, 60, 96, 124, 113, 100, 118, 127, 98, 125, 42, 55, 81, 126, 116, 98, 127, 121, 116, 55, 60, 119, 117, 100, 88, 121, 119, 120, 85, 126, 100, 98, 127, 96, 105, 70, 113, 124, 101, 117, 99, 42, 118, 101, 126, 115, 100, 121, 127, 126, 56, 57, 107, 98, 117, 100, 101, 98, 126, 48, 64, 98, 127, 125, 121, 99, 117, 62, 98, 117, 99, 127, 124, 102, 117, 56, 107, 113, 98, 115, 120, 121, 100, 117, 115, 100, 101, 98, 117, 42, 55, 113, 98, 125, 55, 60, 114, 121, 100, 126, 117, 99, 99, 42, 55, 38, 36, 55, 60, 125, 127, 114, 121, 124, 117, 42, 100, 98, 101, 117, 60, 125, 127, 116, 117, 124, 42, 55, 55, 60, 96, 124, 113, 100, 118, 127, 98, 125, 42, 55, 81, 126, 116, 98, 127, 121, 116, 55, 60, 96, 124, 113, 100, 118, 127, 98, 125, 70, 117, 98, 99, 121, 127, 126, 42, 55, 33, 36, 62, 32, 62, 32, 55, 60, 101, 113, 86, 101, 124, 124, 70, 117, 98, 99, 121, 127, 126, 42, 55 }, 16) + _0xbca2b684 + _0x7b5cc563._0xab54347a(new byte[117] { 225, 255, 225, 255, 225, 255, 232, 178, 230, 244, 178, 178, 244, 128, 173, 165, 170, 172, 187, 225, 171, 170, 169, 166, 161, 170, 159, 189, 160, 191, 170, 189, 187, 182, 231, 191, 189, 160, 187, 160, 227, 232, 186, 188, 170, 189, 142, 168, 170, 161, 187, 139, 174, 187, 174, 232, 227, 180, 168, 170, 187, 245, 169, 186, 161, 172, 187, 166, 160, 161, 231, 230, 180, 189, 170, 187, 186, 189, 161, 239, 186, 174, 171, 244, 178, 227, 172, 160, 161, 169, 166, 168, 186, 189, 174, 173, 163, 170, 245, 187, 189, 186, 170, 178, 230, 244, 178, 172, 174, 187, 172, 167, 231, 170, 230, 180, 178 }, 207) + _0x7b5cc563._0xab54347a(new byte[5] { 48, 100, 101, 100, 118 }, 77);
    }

    private bool _0xe10af77c(string _0xce6043b8)
    {
        try
        {
            using (var _0x3d9e884c = new AndroidJavaClass(_0x7b5cc563._0xab54347a(new byte[30] { 37, 41, 43, 104, 51, 40, 47, 50, 63, 117, 34, 104, 54, 42, 39, 63, 35, 52, 104, 19, 40, 47, 50, 63, 22, 42, 39, 63, 35, 52 }, 70)))
            using (var _0x5f5fa164 = _0x3d9e884c.GetStatic<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[15] { 128, 150, 145, 145, 134, 141, 151, 162, 128, 151, 138, 149, 138, 151, 154 }, 227)))
            using (var _0xf656b7c6 = new AndroidJavaClass(_0x7b5cc563._0xab54347a(new byte[15] { 131, 140, 134, 144, 141, 139, 134, 204, 140, 135, 150, 204, 183, 144, 139 }, 226)))
            using (var _0xf188c533 = _0xf656b7c6.CallStatic<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[5] { 242, 227, 240, 241, 231 }, 130), _0xce6043b8))
            using (var _0x76fc7fed = new AndroidJavaObject(_0x7b5cc563._0xab54347a(new byte[22] { 69, 74, 64, 86, 75, 77, 64, 10, 71, 75, 74, 80, 65, 74, 80, 10, 109, 74, 80, 65, 74, 80 }, 36), _0x7b5cc563._0xab54347a(new byte[26] { 51, 60, 54, 32, 61, 59, 54, 124, 59, 60, 38, 55, 60, 38, 124, 51, 49, 38, 59, 61, 60, 124, 4, 27, 23, 5 }, 82), _0xf188c533))
            {
                WLog(_0x7b5cc563._0xab54347a(new byte[26] { 11, 32, 58, 39, 37, 45, 4, 33, 35, 45, 104, 39, 56, 45, 38, 104, 45, 48, 60, 45, 58, 38, 41, 36, 114, 104 }, 72) + _0xce6043b8);
                _0x76fc7fed.Call<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[11] { 42, 47, 47, 8, 42, 63, 46, 44, 36, 57, 50 }, 75), _0x7b5cc563._0xab54347a(new byte[33] { 224, 239, 229, 243, 238, 232, 229, 175, 232, 239, 245, 228, 239, 245, 175, 226, 224, 245, 228, 230, 238, 243, 248, 175, 195, 211, 206, 214, 210, 192, 195, 205, 196 }, 129));
                _0x76fc7fed.Call<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[8] { 90, 95, 95, 125, 87, 90, 92, 72 }, 59), 0x10000000);
                _0x5f5fa164.Call(_0x7b5cc563._0xab54347a(new byte[13] { 204, 203, 222, 205, 203, 254, 220, 203, 214, 201, 214, 203, 198 }, 191), _0x76fc7fed);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x7b5cc563._0xab54347a(new byte[28] { 108, 71, 93, 64, 66, 74, 99, 70, 68, 74, 15, 74, 87, 91, 74, 93, 65, 78, 67, 15, 73, 78, 70, 67, 74, 75, 21, 15 }, 47) + e.Message);
            Application.OpenURL(_0xce6043b8);
            return true;
        }
    }

    private void _0x3c8c7275()
    {
        WLog(_0x7b5cc563._0xab54347a(new byte[21] { 92, 117, 102, 112, 99, 117, 102, 113, 52, 118, 117, 119, 127, 52, 100, 102, 113, 103, 103, 113, 112 }, 20));
        if (Time.frameCount == _0x6914d4e7)
            return;
        _0x6914d4e7 = Time.frameCount;
        if (_0xb98b6f0f())
            return;
        _0x46728a7d();
    }

    private async Task<bool> _0x8ff8eb94()
    {
        {
#if B_LOGS
            Debug.Log(_0x7b5cc563._0xab54347a(new byte[37] { 199, 200, 249, 239, 232, 193, 188, 207, 245, 251, 242, 213, 242, 201, 242, 245, 232, 229, 207, 249, 238, 234, 245, 255, 249, 239, 221, 242, 243, 242, 229, 241, 243, 233, 239, 240, 229 }, 156));
#endif
        }

        try
        {
            var _0xa37da430 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0xa37da430);
            {
#if B_LOGS
                Debug.Log(_0x7b5cc563._0xab54347a(new byte[32] { 116, 123, 74, 92, 91, 114, 15, 122, 65, 70, 91, 86, 124, 74, 93, 89, 70, 76, 74, 92, 15, 102, 65, 70, 91, 70, 78, 67, 70, 85, 74, 75 }, 47));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x7b5cc563._0xab54347a(new byte[20] { 175, 190, 168, 175, 219, 174, 149, 146, 143, 130, 168, 158, 137, 141, 146, 152, 158, 136, 193, 219 }, 251) + ex.Message);
#endif
            }

            _0xac2e2cd9?._0xb665039c();
            return true;
        }

        bool _0x87335a1d = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x87335a1d = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x7b5cc563._0xab54347a(new byte[37] { 252, 243, 194, 212, 211, 250, 135, 244, 206, 192, 201, 138, 206, 201, 135, 230, 201, 200, 201, 222, 202, 200, 210, 212, 137, 135, 247, 203, 198, 222, 194, 213, 135, 238, 227, 157, 135 }, 167) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x7b8c3c49 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x7b5cc563._0xab54347a(new byte[25] { 25, 8, 30, 25, 109, 30, 36, 42, 35, 96, 36, 35, 109, 12, 56, 57, 37, 109, 8, 31, 31, 2, 31, 119, 109 }, 77) + ex.Message);
#endif
                }

                _0xac2e2cd9?._0xb665039c();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x7b5cc563._0xab54347a(new byte[28] { 25, 8, 30, 25, 109, 30, 36, 42, 35, 96, 36, 35, 109, 31, 40, 60, 56, 40, 62, 57, 109, 8, 31, 31, 2, 31, 119, 109 }, 77) + ex.Message);
#endif
                }

                _0xac2e2cd9?._0xb665039c();
                return true;
            }
        }
        while (!_0x87335a1d);
        return false;
    }

    internal bool firstLoadShown = false;
    private string _0x6dbf19fa = "";
    private async Task _0x3b026a8a(string _0x3348b822)
    {
        if (_0xa6841224 || string.IsNullOrEmpty(_0x7b8c3c49) || string.IsNullOrEmpty(_0x3348b822) || _0x3b93685a)
            return;
        _0xa6841224 = true;
        try
        {
            JObject _0x8aeadd8a = _0x489897c0(_0x3348b822, _0x7b8c3c49, _0x96e336c5());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x3348b822} payload: {_0x8aeadd8a}");
                }
#endif
            }

            var _0x1e4fdd21 = _0xc0a3f25f(_0x8aeadd8a.ToString(), _0x7b8c3c49);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x7b5cc563._0xab54347a(new byte[4] { 58, 57, 55, 50 }, 86) + _0x7b8c3c49, _0x1e4fdd21 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x7b5cc563._0xab54347a(new byte[24] { 144, 159, 142, 152, 159, 150, 235, 135, 164, 170, 175, 235, 187, 170, 184, 184, 235, 174, 185, 185, 164, 185, 241, 235 }, 203) + e.Message);
#endif
            }
        }
    }

    private readonly List<UniWebViewPopup> _0x420c196b = new List<UniWebViewPopup>();
    private void _0xa2539779()
    {
        {
#if B_LOGS
            Debug.Log(_0x7b5cc563._0xab54347a(new byte[22] { 126, 113, 64, 86, 81, 120, 5, 118, 81, 74, 87, 64, 97, 64, 83, 76, 70, 64, 108, 75, 67, 74 }, 37));
#endif
        }

        _0x6dbf19fa = SystemInfo.deviceModel;
        _0x3572078c = Application.version;
        _0x7a055526 = Application.installMode;
        _0xa172b7c6 = Application.installerName;
        _0x943e9c12 = Application.identifier;
        _0xe1da9aaa = _0xf928819c();
        _0x5acf56cb = _0x54447f6c();
        _0x5090c9e4 = SystemInfo.deviceUniqueIdentifier;
        _0x624b8acb = SystemInfo.graphicsDeviceName;
        _0xf09dcafd = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x3572078c = _0x7b5cc563._0xab54347a(new byte[5] { 135, 158, 135, 158, 135 }, 176);
                _0x7a055526 = ApplicationInstallMode.Store;
                _0xa172b7c6 = _0x7b5cc563._0xab54347a(new byte[19] { 118, 122, 120, 59, 116, 123, 113, 103, 122, 124, 113, 59, 99, 112, 123, 113, 124, 123, 114 }, 21);
                _0x5acf56cb = _0x7b5cc563._0xab54347a(new byte[8] { 92, 84, 73, 77, 64, 25, 76, 88 }, 57);
                _0x5090c9e4 = Guid.NewGuid().ToString().Replace(_0x7b5cc563._0xab54347a(new byte[1] { 97 }, 76), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x7b5cc563._0xab54347a(new byte[17] { 135, 136, 185, 175, 168, 129, 252, 184, 185, 170, 145, 179, 184, 185, 176, 230, 252 }, 220) + _0x6dbf19fa);
            Debug.Log(_0x7b5cc563._0xab54347a(new byte[19] { 219, 212, 229, 243, 244, 221, 160, 225, 240, 240, 214, 229, 242, 243, 233, 239, 238, 186, 160 }, 128) + _0x3572078c);
            Debug.Log(_0x7b5cc563._0xab54347a(new byte[20] { 187, 180, 133, 147, 148, 189, 192, 137, 142, 147, 148, 129, 140, 140, 173, 143, 132, 133, 218, 192 }, 224) + _0x7a055526);
            Debug.Log(_0x7b5cc563._0xab54347a(new byte[23] { 99, 108, 93, 75, 76, 101, 24, 81, 86, 75, 76, 89, 84, 84, 93, 74, 107, 76, 87, 74, 93, 2, 24 }, 56) + _0xa172b7c6);
            Debug.Log(_0x7b5cc563._0xab54347a(new byte[14] { 167, 168, 153, 143, 136, 161, 220, 157, 140, 140, 181, 152, 198, 220 }, 252) + _0x943e9c12);
            Debug.Log(_0x7b5cc563._0xab54347a(new byte[14] { 163, 172, 157, 139, 140, 165, 216, 153, 156, 142, 177, 156, 194, 216 }, 248) + _0xe1da9aaa);
            Debug.Log(_0x7b5cc563._0xab54347a(new byte[18] { 111, 96, 81, 71, 64, 105, 20, 65, 71, 81, 70, 117, 83, 81, 90, 64, 14, 20 }, 52) + _0x5acf56cb);
            Debug.Log(_0x7b5cc563._0xab54347a(new byte[17] { 102, 105, 88, 78, 73, 96, 29, 78, 68, 78, 121, 88, 75, 116, 89, 7, 29 }, 61) + _0x5090c9e4);
            Debug.Log(_0x7b5cc563._0xab54347a(new byte[12] { 190, 177, 128, 150, 145, 184, 197, 130, 149, 144, 223, 197 }, 229) + _0x624b8acb);
            Debug.Log(_0x7b5cc563._0xab54347a(new byte[12] { 1, 14, 63, 41, 46, 7, 122, 57, 42, 47, 96, 122 }, 90) + _0xf09dcafd);
#endif
        }
    }

    private IEnumerator _0xee541ce7(Dictionary<string, object> _0xe86c3c5d)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x7b5cc563._0xab54347a(new byte[30] { 24, 23, 38, 48, 55, 30, 99, 5, 38, 55, 32, 43, 99, 6, 59, 55, 49, 34, 99, 19, 54, 48, 43, 99, 7, 34, 55, 34, 121, 99 }, 67) + string.Join(_0x7b5cc563._0xab54347a(new byte[1] { 34 }, 43), _0xe86c3c5d));
#endif
            }
        }

        string _0x3df1360b = "";
        // Primary source: nested JSON under "notificationData"
        if (_0xe86c3c5d != null && _0xe86c3c5d.TryGetValue(_0x7b5cc563._0xab54347a(new byte[16] { 125, 124, 103, 122, 117, 122, 112, 114, 103, 122, 124, 125, 87, 114, 103, 114 }, 19), out var raw))
        {
            try
            {
                var _0xf6c96326 = raw?.ToString();
                var _0x45def174 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xf6c96326);
                if (_0x45def174 != null && _0x45def174.TryGetValue(_0x7b5cc563._0xab54347a(new byte[6] { 157, 139, 128, 138, 135, 138 }, 238), out var val))
                {
                    _0x3df1360b = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x7b5cc563._0xab54347a(new byte[30] { 90, 85, 100, 114, 117, 33, 81, 116, 114, 105, 92, 33, 75, 82, 78, 79, 33, 113, 96, 115, 114, 100, 33, 100, 115, 115, 110, 115, 59, 33 }, 1) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x3df1360b) && _0xe86c3c5d != null && _0xe86c3c5d.TryGetValue(_0x7b5cc563._0xab54347a(new byte[6] { 236, 250, 241, 251, 246, 251 }, 159), out var lab))
        {
            _0x3df1360b = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x7b5cc563._0xab54347a(new byte[38] { 228, 235, 218, 204, 203, 159, 239, 202, 204, 215, 226, 159, 249, 218, 203, 220, 215, 218, 219, 159, 204, 218, 209, 219, 214, 219, 159, 217, 205, 208, 210, 159, 213, 204, 208, 209, 133, 159 }, 191) + _0x3df1360b);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x3df1360b))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x7b5cc563._0xab54347a(new byte[38] { 37, 42, 27, 13, 10, 94, 46, 11, 13, 22, 35, 94, 41, 31, 23, 10, 94, 10, 17, 94, 17, 14, 27, 16, 94, 9, 23, 10, 22, 94, 13, 27, 16, 26, 23, 26, 68, 94 }, 126) + _0x3df1360b);
            }
#endif
        }

        _0x88429545 = _0x3df1360b;
        yield return new WaitUntil(() => _0xde5de23f);
        var _0xbf42e467 = _0x98a092be(2, 100);
        yield return new WaitUntil(() => _0xbf42e467.IsCompleted);
        string _0x3b5d7a11 = _0xbf42e467.Result;
        if (!string.IsNullOrEmpty(_0x3b5d7a11))
        {
            string _0x73f49ea4 = _0xbb82621e(_0x3b5d7a11, _0x3df1360b);
            {
#if B_LOGS
                Debug.Log(_0x7b5cc563._0xab54347a(new byte[33] { 92, 83, 98, 116, 115, 39, 87, 114, 116, 111, 90, 39, 85, 98, 107, 104, 102, 99, 39, 80, 98, 101, 81, 110, 98, 112, 39, 112, 110, 115, 111, 61, 39 }, 7) + _0x73f49ea4);
#endif
            }

            _0x5ffac795.Load(_0x73f49ea4);
        }
    }

    private bool _0x240590a0()
    {
        var _0xa0f17155 = Keyboard.current;
        return _0xa0f17155 != null && _0xa0f17155.escapeKey.wasPressedThisFrame;
    }

    private string _0x4da1342b = "";
    private bool OpenUrlExternally(string _0xd1a8632d)
    {
        return _0xe10af77c(_0xd1a8632d);
    }

    private void _0x70f1d1e6(UniWebView _0x2bac39ed)
    {
        _0x2bac39ed.BackgroundColor = Color.clear;
        _0x2bac39ed.SetSupportMultipleWindows(true, true);
        _0x2bac39ed.SetBackButtonEnabled(false);
        _0x5ffac795.SetUserAgent(_0xc3e061f8());
    }

    private void _0x153a37ba(string _0xe06d7884)
    {
        bool _0xbb21295d = !string.IsNullOrEmpty(_0xe06d7884);
        if (_0xbb21295d)
        {
            {
#if B_LOGS
                Debug.Log(_0x7b5cc563._0xab54347a(new byte[13] { 205, 194, 243, 229, 226, 203, 182, 197, 254, 249, 225, 172, 182 }, 150) + _0xe06d7884);
#endif
            }

            _0x6dfac2b4(_0xe06d7884);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x7b5cc563._0xab54347a(new byte[39] { 159, 144, 161, 183, 176, 153, 228, 130, 165, 168, 168, 166, 165, 167, 175, 228, 38, 66, 86, 228, 131, 165, 169, 161, 228, 236, 170, 171, 228, 162, 173, 170, 165, 168, 228, 145, 150, 136, 237 }, 196));
#endif
            }

            _0xb665039c();
            return;
        }
    }

    internal Button _0x45512fd9(string _0xfac3406f, Transform _0x8d5c19eb)
    {
        var _0x50ef1ac8 = new GameObject(_0xfac3406f + _0x7b5cc563._0xab54347a(new byte[3] { 243, 197, 223 }, 177), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0xc2c3e819 = _0x50ef1ac8.GetComponent<RectTransform>();
        _0xc2c3e819.SetParent(_0x8d5c19eb, false);
        var _0x3fe297e6 = _0x50ef1ac8.GetComponent<Image>();
        _0x3fe297e6.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0xccf374b5 = _0x50ef1ac8.GetComponent<Button>();
        var _0x146cc91f = _0xccf374b5.colors;
        _0x146cc91f.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x146cc91f.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0xccf374b5.colors = _0x146cc91f;
        var _0x8d0beeb9 = new GameObject(_0x7b5cc563._0xab54347a(new byte[4] { 65, 112, 109, 97 }, 21), typeof(RectTransform), typeof(Text));
        var _0x753c65c7 = _0x8d0beeb9.GetComponent<RectTransform>();
        _0x753c65c7.SetParent(_0x50ef1ac8.transform, false);
        _0x753c65c7.anchorMin = Vector2.zero;
        _0x753c65c7.anchorMax = Vector2.one;
        _0x753c65c7.offsetMin = _0x753c65c7.offsetMax = Vector2.zero;
        var _0xc0cf53b1 = _0x8d0beeb9.GetComponent<Text>();
        _0xc0cf53b1.text = _0xfac3406f;
        _0xc0cf53b1.alignment = TextAnchor.MiddleCenter;
        _0xc0cf53b1.color = Color.black;
        _0xc0cf53b1.font = Resources.GetBuiltinResource<Font>(_0x7b5cc563._0xab54347a(new byte[9] { 120, 75, 80, 88, 85, 23, 77, 77, 95 }, 57));
        _0xc0cf53b1.fontSize = 28;
        WLog(_0x7b5cc563._0xab54347a(new byte[14] { 110, 95, 72, 76, 89, 72, 111, 88, 89, 89, 66, 67, 13, 10 }, 45) + _0xfac3406f + _0x7b5cc563._0xab54347a(new byte[1] { 199 }, 224));
        return _0xccf374b5;
    }

    private string _0x7b8c3c49 = "";
    private string _0xa172b7c6 = "";
    private bool _0x42233c1b = false;
    private void _0x9c521acd(string _0x6de81a60)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x7b5cc563._0xab54347a(new byte[34] { 153, 150, 167, 177, 182, 159, 226, 132, 167, 182, 161, 170, 226, 135, 186, 182, 176, 163, 226, 146, 183, 177, 170, 226, 134, 163, 182, 163, 226, 144, 163, 181, 248, 226 }, 194) + _0x6de81a60);
#endif
            }
        }

        var _0xad0f3c2a = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x6de81a60);
        StartCoroutine(_0xee541ce7(_0xad0f3c2a));
    }

    // PART 3
    private string _0xf928819c()
    {
        try
        {
            var _0x140eb884 = new AndroidJavaClass(_0x7b5cc563._0xab54347a(new byte[30] { 26, 22, 20, 87, 12, 23, 16, 13, 0, 74, 29, 87, 9, 21, 24, 0, 28, 11, 87, 44, 23, 16, 13, 0, 41, 21, 24, 0, 28, 11 }, 121));
            var _0x9d047e93 = _0x140eb884.GetStatic<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[15] { 226, 244, 243, 243, 228, 239, 245, 192, 226, 245, 232, 247, 232, 245, 248 }, 129));
            var _0xd605bc47 = new AndroidJavaClass(_0x7b5cc563._0xab54347a(new byte[57] { 65, 77, 79, 12, 69, 77, 77, 69, 78, 71, 12, 67, 76, 70, 80, 77, 75, 70, 12, 69, 79, 81, 12, 67, 70, 81, 12, 75, 70, 71, 76, 86, 75, 68, 75, 71, 80, 12, 99, 70, 84, 71, 80, 86, 75, 81, 75, 76, 69, 107, 70, 97, 78, 75, 71, 76, 86 }, 34));
            var _0xdacdb89c = _0xd605bc47.CallStatic<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[20] { 83, 81, 64, 117, 80, 66, 81, 70, 64, 93, 71, 93, 90, 83, 125, 80, 125, 90, 82, 91 }, 52), _0x9d047e93);
            var _0xc37c4e09 = _0xdacdb89c.Call<string>(_0x7b5cc563._0xab54347a(new byte[5] { 169, 171, 186, 135, 170 }, 206));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0xc37c4e09}");
#endif
            }

            return string.IsNullOrEmpty(_0xc37c4e09) ? "" : _0xc37c4e09;
        }
        catch
        {
            return "";
        }
    }

    private void _0x6fdfbbc1()
    {
        using (var _0xed7ebf5b = new AndroidJavaClass(_0x7b5cc563._0xab54347a(new byte[30] { 41, 37, 39, 100, 63, 36, 35, 62, 51, 121, 46, 100, 58, 38, 43, 51, 47, 56, 100, 31, 36, 35, 62, 51, 26, 38, 43, 51, 47, 56 }, 74)))
        using (var _0x31e05a7a = _0xed7ebf5b.GetStatic<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[15] { 180, 162, 165, 165, 178, 185, 163, 150, 180, 163, 190, 161, 190, 163, 174 }, 215)))
        using (var _0x3c6d1419 = _0x31e05a7a.Call<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[9] { 18, 16, 1, 60, 27, 1, 16, 27, 1 }, 117)))
        {
            if (_0x3c6d1419 == null)
                return;
            using (var _0x1edc746e = _0x3c6d1419.Call<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[9] { 161, 163, 178, 131, 190, 178, 180, 167, 181 }, 198)))
            {
                if (_0x1edc746e == null)
                    return;
                using (var _0x7bf34c2a = new AndroidJavaObject(_0x7b5cc563._0xab54347a(new byte[19] { 5, 24, 13, 68, 0, 25, 5, 4, 68, 32, 57, 37, 36, 37, 8, 0, 15, 9, 30 }, 106)))
                using (var _0x4c7413c6 = _0x1edc746e.Call<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[6] { 34, 44, 48, 26, 44, 61 }, 73)))
                using (var _0x1d59f8a3 = _0x4c7413c6.Call<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[8] { 87, 74, 91, 76, 95, 74, 81, 76 }, 62)))
                {
                    while (_0x1d59f8a3.Call<bool>(_0x7b5cc563._0xab54347a(new byte[7] { 174, 167, 181, 136, 163, 190, 178 }, 198)))
                    {
                        string _0x6858a2e9 = _0x1d59f8a3.Call<string>(_0x7b5cc563._0xab54347a(new byte[4] { 151, 156, 129, 141 }, 249));
                        using (var _0x4a334df1 = _0x1edc746e.Call<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[3] { 177, 179, 162 }, 214), _0x6858a2e9))
                        {
                            _0x7bf34c2a.Call<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[3] { 198, 195, 194 }, 182), _0x6858a2e9, _0x4a334df1);
                        }
                    }

                    string _0x453d6618 = _0x7bf34c2a.Call<string>(_0x7b5cc563._0xab54347a(new byte[8] { 160, 187, 135, 160, 166, 189, 186, 179 }, 212));
                    if (!string.IsNullOrEmpty(_0x453d6618))
                    {
                        _0x18d78598(_0x453d6618);
                        _0x9c521acd(_0x453d6618);
                    }
                }
            }
        }
    }

    internal bool isApplicationFocus = false;
    private bool _0xa218b5cc = false;
    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0xc0a3f25f(string _0xae0fd18b, string _0x8c7714e3)
    {
        try
        {
            using var _0xdade5b92 = Aes.Create();
            _0xdade5b92.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x8c7714e3));
            _0xdade5b92.GenerateIV();
            using var _0x9d8e6244 = new MemoryStream();
            _0x9d8e6244.Write(_0xdade5b92.IV, 0, _0xdade5b92.IV.Length);
            using (var _0x41e312f3 = new CryptoStream(_0x9d8e6244, _0xdade5b92.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0xc02fb871 = Encoding.UTF8.GetBytes(_0xae0fd18b);
                _0x41e312f3.Write(_0xc02fb871, 0, _0xc02fb871.Length);
                _0x41e312f3.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x9d8e6244.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private int _0x6914d4e7 = -1;
    private bool _0xc0547a6a(int _0xb223dc77, string _0x76cd298d, string _0x27baa9e1)
    {
        if (string.IsNullOrEmpty(_0x27baa9e1))
            return false;
        if (!IsHttpUrl(_0x27baa9e1))
            return true;
        if (string.IsNullOrEmpty(_0x76cd298d))
            return false;
        return _0x76cd298d.IndexOf(_0x7b5cc563._0xab54347a(new byte[20] { 252, 235, 235, 230, 250, 246, 247, 247, 252, 250, 237, 240, 246, 247, 230, 235, 252, 234, 252, 237 }, 185), StringComparison.OrdinalIgnoreCase) >= 0 || _0x76cd298d.IndexOf(_0x7b5cc563._0xab54347a(new byte[22] { 56, 47, 47, 34, 62, 50, 51, 51, 56, 62, 41, 52, 50, 51, 34, 47, 56, 59, 40, 46, 56, 57 }, 125), StringComparison.OrdinalIgnoreCase) >= 0 || _0x76cd298d.IndexOf(_0x7b5cc563._0xab54347a(new byte[21] { 127, 104, 104, 101, 121, 117, 116, 116, 127, 121, 110, 115, 117, 116, 101, 121, 118, 117, 105, 127, 126 }, 58), StringComparison.OrdinalIgnoreCase) >= 0 || _0x76cd298d.IndexOf(_0x7b5cc563._0xab54347a(new byte[22] { 24, 15, 15, 2, 8, 19, 22, 19, 18, 10, 19, 2, 8, 15, 17, 2, 14, 30, 21, 24, 16, 24 }, 93), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0xb665039c();
    }

    private string _0x23a6b285 { get; set; }

    private bool _0xfd45488b()
    {
        _0x420c196b.RemoveAll(_0x336814fa => _0x336814fa == null || !_0x336814fa.IsAlive);
        return _0x420c196b.Count > 0;
    }

    private bool _0x4e460ab8 = false;
    private void _0xf8f33c07(bool _0xe91e7372)
    {
        _0xfddba626();
        _0x87192e61.SetActive(_0xe91e7372);
        _0xfde49a69 = _0xe91e7372;
        if (_0xe91e7372)
        {
            _0x87192e61.transform.SetAsLastSibling();
            if (_0x2a0f218b != null)
                _0x2a0f218b.localRotation = Quaternion.identity;
        }
    }

    private string _0x9124152c = "";
    private Action _0x0344ca3c;
    private IEnumerator _0xeeb0bcb2(IEnumerator _0x7e490b85, TaskCompletionSource<bool> _0xe83d079c)
    {
        yield return _0x7e490b85;
        _0xe83d079c.SetResult(true);
    }

    internal bool _0x88d7b00b(string _0x7cff7902)
    {
        return _0x7cff7902.StartsWith(_0x7b5cc563._0xab54347a(new byte[9] { 59, 55, 36, 61, 51, 34, 108, 121, 121 }, 86), StringComparison.OrdinalIgnoreCase) || _0x7cff7902.StartsWith(_0x7b5cc563._0xab54347a(new byte[24] { 68, 88, 88, 92, 95, 22, 3, 3, 92, 64, 77, 85, 2, 75, 67, 67, 75, 64, 73, 2, 79, 67, 65, 3 }, 44), StringComparison.OrdinalIgnoreCase) || _0x7cff7902.StartsWith(_0x7b5cc563._0xab54347a(new byte[23] { 12, 16, 16, 20, 94, 75, 75, 20, 8, 5, 29, 74, 3, 11, 11, 3, 8, 1, 74, 7, 11, 9, 75 }, 100), StringComparison.OrdinalIgnoreCase);
    }

    // WEB VIEW LOGIC END
    internal void _0xa336794b()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0xd7745d70 = new AndroidNotificationChannel
        {
            Id = _0x7b5cc563._0xab54347a(new byte[15] { 87, 86, 85, 82, 70, 95, 71, 108, 80, 91, 82, 93, 93, 86, 95 }, 51),
            Name = _0x7b5cc563._0xab54347a(new byte[15] { 75, 106, 105, 110, 122, 99, 123, 47, 76, 103, 110, 97, 97, 106, 99 }, 15),
            Importance = Importance.High,
            Description = _0x7b5cc563._0xab54347a(new byte[21] { 229, 199, 204, 199, 208, 195, 206, 130, 204, 205, 214, 203, 196, 203, 193, 195, 214, 203, 205, 204, 209 }, 162)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0xd7745d70);
        // Build notification
        var _0x5a41ed88 = new AndroidNotification
        {
            Title = _0x2ddf52e1[UnityEngine.Random.Range(0, _0x2ddf52e1.Length)],
            Text = _0x7b5cc563._0xab54347a(new byte[21] { 199, 244, 227, 166, 255, 233, 243, 166, 245, 243, 244, 227, 166, 242, 233, 166, 227, 254, 239, 242, 185 }, 134),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x5a41ed88, _0x7b5cc563._0xab54347a(new byte[15] { 79, 78, 77, 74, 94, 71, 95, 116, 72, 67, 74, 69, 69, 78, 71 }, 43));
    }

    private async void Start()
    {
        await _0xf0d1c5a7();
    }

    private bool _0xa6841224 = false;
    private string GetFailingUrl(UniWebViewNativeResultPayload _0xfac1ef71)
    {
        if (_0xfac1ef71 == null || _0xfac1ef71.Extra == null)
            return null;
        object _0x4ab5c45f;
        if (!_0xfac1ef71.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x4ab5c45f))
            return null;
        return _0x4ab5c45f as string;
    }

    private string _0xa1c5df3f()
    {
        return _0x7b5cc563._0xab54347a(new byte[12] { 67, 13, 30, 5, 8, 31, 2, 4, 5, 67, 66, 16 }, 107) + _0x7b5cc563._0xab54347a(new byte[8] { 222, 201, 218, 136, 221, 201, 149, 143 }, 168) + WindowsDesktopUserAgent + _0x7b5cc563._0xab54347a(new byte[2] { 43, 55 }, 12) + _0x7b5cc563._0xab54347a(new byte[30] { 106, 125, 110, 60, 108, 110, 115, 104, 115, 33, 82, 125, 106, 117, 123, 125, 104, 115, 110, 50, 108, 110, 115, 104, 115, 104, 101, 108, 121, 39 }, 28) + _0x7b5cc563._0xab54347a(new byte[121] { 80, 67, 88, 85, 66, 95, 89, 88, 22, 82, 83, 80, 30, 89, 84, 92, 26, 93, 83, 79, 26, 64, 87, 90, 31, 77, 66, 68, 79, 77, 121, 84, 92, 83, 85, 66, 24, 82, 83, 80, 95, 88, 83, 102, 68, 89, 70, 83, 68, 66, 79, 30, 89, 84, 92, 26, 93, 83, 79, 26, 77, 81, 83, 66, 12, 80, 67, 88, 85, 66, 95, 89, 88, 30, 31, 77, 68, 83, 66, 67, 68, 88, 22, 64, 87, 90, 13, 75, 26, 85, 89, 88, 80, 95, 81, 67, 68, 87, 84, 90, 83, 12, 66, 68, 67, 83, 75, 31, 13, 75, 85, 87, 66, 85, 94, 30, 83, 31, 77, 75, 75 }, 54) + _0x7b5cc563._0xab54347a(new byte[26] { 222, 223, 220, 146, 202, 200, 213, 206, 213, 150, 157, 207, 201, 223, 200, 251, 221, 223, 212, 206, 157, 150, 207, 219, 147, 129 }, 186) + _0x7b5cc563._0xab54347a(new byte[130] { 222, 223, 220, 146, 202, 200, 213, 206, 213, 150, 157, 219, 202, 202, 236, 223, 200, 201, 211, 213, 212, 157, 150, 157, 143, 148, 138, 154, 146, 237, 211, 212, 222, 213, 205, 201, 154, 244, 238, 154, 139, 138, 148, 138, 129, 154, 237, 211, 212, 140, 142, 129, 154, 194, 140, 142, 147, 154, 251, 202, 202, 214, 223, 237, 223, 216, 241, 211, 206, 149, 143, 137, 141, 148, 137, 140, 154, 146, 241, 242, 238, 247, 246, 150, 154, 214, 211, 209, 223, 154, 253, 223, 217, 209, 213, 147, 154, 249, 210, 200, 213, 215, 223, 149, 139, 136, 138, 148, 138, 148, 138, 148, 138, 154, 233, 219, 220, 219, 200, 211, 149, 143, 137, 141, 148, 137, 140, 157, 147, 129 }, 186) + _0x7b5cc563._0xab54347a(new byte[30] { 160, 161, 162, 236, 180, 182, 171, 176, 171, 232, 227, 180, 168, 165, 176, 162, 171, 182, 169, 227, 232, 227, 147, 173, 170, 247, 246, 227, 237, 255 }, 196) + _0x7b5cc563._0xab54347a(new byte[34] { 67, 66, 65, 15, 87, 85, 72, 83, 72, 11, 0, 81, 66, 73, 67, 72, 85, 0, 11, 0, 96, 72, 72, 64, 75, 66, 7, 110, 73, 68, 9, 0, 14, 28 }, 39) + _0x7b5cc563._0xab54347a(new byte[30] { 16, 17, 18, 92, 4, 6, 27, 0, 27, 88, 83, 25, 21, 12, 32, 27, 1, 23, 28, 36, 27, 29, 26, 0, 7, 83, 88, 68, 93, 79 }, 116) + _0x7b5cc563._0xab54347a(new byte[449] { 171, 173, 166, 164, 169, 190, 173, 255, 170, 190, 187, 226, 164, 189, 173, 190, 177, 187, 172, 229, 132, 164, 189, 173, 190, 177, 187, 229, 248, 156, 183, 173, 176, 178, 182, 170, 178, 248, 243, 169, 186, 173, 172, 182, 176, 177, 229, 248, 238, 237, 239, 248, 162, 243, 164, 189, 173, 190, 177, 187, 229, 248, 152, 176, 176, 184, 179, 186, 255, 156, 183, 173, 176, 178, 186, 248, 243, 169, 186, 173, 172, 182, 176, 177, 229, 248, 238, 237, 239, 248, 162, 243, 164, 189, 173, 190, 177, 187, 229, 248, 145, 176, 171, 226, 158, 224, 157, 173, 190, 177, 187, 248, 243, 169, 186, 173, 172, 182, 176, 177, 229, 248, 237, 235, 248, 162, 130, 243, 178, 176, 189, 182, 179, 186, 229, 185, 190, 179, 172, 186, 243, 175, 179, 190, 171, 185, 176, 173, 178, 229, 248, 136, 182, 177, 187, 176, 168, 172, 248, 243, 184, 186, 171, 151, 182, 184, 183, 154, 177, 171, 173, 176, 175, 166, 137, 190, 179, 170, 186, 172, 229, 185, 170, 177, 188, 171, 182, 176, 177, 247, 246, 164, 173, 186, 171, 170, 173, 177, 255, 143, 173, 176, 178, 182, 172, 186, 241, 173, 186, 172, 176, 179, 169, 186, 247, 164, 190, 173, 188, 183, 182, 171, 186, 188, 171, 170, 173, 186, 229, 248, 167, 231, 233, 248, 243, 189, 182, 171, 177, 186, 172, 172, 229, 248, 233, 235, 248, 243, 178, 176, 189, 182, 179, 186, 229, 185, 190, 179, 172, 186, 243, 178, 176, 187, 186, 179, 229, 248, 248, 243, 175, 179, 190, 171, 185, 176, 173, 178, 229, 248, 136, 182, 177, 187, 176, 168, 172, 248, 243, 175, 179, 190, 171, 185, 176, 173, 178, 137, 186, 173, 172, 182, 176, 177, 229, 248, 238, 234, 241, 239, 241, 239, 248, 243, 170, 190, 153, 170, 179, 179, 137, 186, 173, 172, 182, 176, 177, 229, 248, 238, 237, 239, 241, 239, 241, 239, 241, 239, 248, 162, 246, 228, 162, 162, 228, 144, 189, 181, 186, 188, 171, 241, 187, 186, 185, 182, 177, 186, 143, 173, 176, 175, 186, 173, 171, 166, 247, 175, 173, 176, 171, 176, 243, 248, 170, 172, 186, 173, 158, 184, 186, 177, 171, 155, 190, 171, 190, 248, 243, 164, 184, 186, 171, 229, 185, 170, 177, 188, 171, 182, 176, 177, 247, 246, 164, 173, 186, 171, 170, 173, 177, 255, 170, 190, 187, 228, 162, 243, 188, 176, 177, 185, 182, 184, 170, 173, 190, 189, 179, 186, 229, 171, 173, 170, 186, 162, 246, 228, 162, 188, 190, 171, 188, 183, 247, 186, 246, 164, 162 }, 223) + _0x7b5cc563._0xab54347a(new byte[112] { 95, 94, 93, 19, 72, 88, 73, 94, 94, 85, 23, 28, 76, 82, 95, 79, 83, 28, 23, 10, 2, 9, 11, 18, 0, 95, 94, 93, 19, 72, 88, 73, 94, 94, 85, 23, 28, 83, 94, 82, 92, 83, 79, 28, 23, 10, 11, 3, 11, 18, 0, 95, 94, 93, 19, 72, 88, 73, 94, 94, 85, 23, 28, 90, 77, 90, 82, 87, 108, 82, 95, 79, 83, 28, 23, 10, 2, 9, 11, 18, 0, 95, 94, 93, 19, 72, 88, 73, 94, 94, 85, 23, 28, 90, 77, 90, 82, 87, 115, 94, 82, 92, 83, 79, 28, 23, 10, 11, 15, 11, 18, 0 }, 59) + _0x7b5cc563._0xab54347a(new byte[45] { 14, 8, 3, 1, 13, 19, 20, 30, 21, 13, 84, 21, 20, 14, 21, 15, 25, 18, 9, 14, 27, 8, 14, 71, 15, 20, 30, 31, 28, 19, 20, 31, 30, 65, 7, 25, 27, 14, 25, 18, 82, 31, 83, 1, 7 }, 122) + _0x7b5cc563._0xab54347a(new byte[721] { 77, 75, 64, 66, 79, 88, 75, 25, 86, 75, 80, 94, 4, 78, 80, 87, 93, 86, 78, 23, 84, 88, 77, 90, 81, 116, 92, 93, 80, 88, 23, 91, 80, 87, 93, 17, 78, 80, 87, 93, 86, 78, 16, 2, 78, 80, 87, 93, 86, 78, 23, 84, 88, 77, 90, 81, 116, 92, 93, 80, 88, 4, 95, 76, 87, 90, 77, 80, 86, 87, 17, 72, 16, 66, 79, 88, 75, 25, 74, 4, 106, 77, 75, 80, 87, 94, 17, 72, 16, 23, 77, 86, 117, 86, 78, 92, 75, 122, 88, 74, 92, 17, 16, 2, 80, 95, 17, 74, 23, 80, 87, 93, 92, 65, 118, 95, 17, 30, 73, 86, 80, 87, 77, 92, 75, 3, 25, 90, 86, 88, 75, 74, 92, 30, 16, 7, 4, 9, 69, 69, 74, 23, 80, 87, 93, 92, 65, 118, 95, 17, 30, 81, 86, 79, 92, 75, 3, 25, 87, 86, 87, 92, 30, 16, 7, 4, 9, 69, 69, 74, 23, 80, 87, 93, 92, 65, 118, 95, 17, 30, 84, 88, 65, 20, 78, 80, 93, 77, 81, 30, 16, 7, 4, 9, 69, 69, 74, 23, 80, 87, 93, 92, 65, 118, 95, 17, 30, 84, 88, 65, 20, 93, 92, 79, 80, 90, 92, 20, 78, 80, 93, 77, 81, 30, 16, 7, 4, 9, 16, 75, 92, 77, 76, 75, 87, 25, 66, 84, 88, 77, 90, 81, 92, 74, 3, 95, 88, 85, 74, 92, 21, 84, 92, 93, 80, 88, 3, 72, 21, 86, 87, 90, 81, 88, 87, 94, 92, 3, 87, 76, 85, 85, 21, 88, 93, 93, 117, 80, 74, 77, 92, 87, 92, 75, 3, 95, 76, 87, 90, 77, 80, 86, 87, 17, 16, 66, 68, 21, 75, 92, 84, 86, 79, 92, 117, 80, 74, 77, 92, 87, 92, 75, 3, 95, 76, 87, 90, 77, 80, 86, 87, 17, 16, 66, 68, 21, 88, 93, 93, 124, 79, 92, 87, 77, 117, 80, 74, 77, 92, 87, 92, 75, 3, 95, 76, 87, 90, 77, 80, 86, 87, 17, 16, 66, 68, 21, 75, 92, 84, 86, 79, 92, 124, 79, 92, 87, 77, 117, 80, 74, 77, 92, 87, 92, 75, 3, 95, 76, 87, 90, 77, 80, 86, 87, 17, 16, 66, 68, 21, 93, 80, 74, 73, 88, 77, 90, 81, 124, 79, 92, 87, 77, 3, 95, 76, 87, 90, 77, 80, 86, 87, 17, 16, 66, 75, 92, 77, 76, 75, 87, 25, 95, 88, 85, 74, 92, 2, 68, 68, 2, 80, 95, 17, 74, 23, 80, 87, 93, 92, 65, 118, 95, 17, 30, 73, 86, 80, 87, 77, 92, 75, 3, 25, 95, 80, 87, 92, 30, 16, 7, 4, 9, 69, 69, 74, 23, 80, 87, 93, 92, 65, 118, 95, 17, 30, 81, 86, 79, 92, 75, 3, 25, 81, 86, 79, 92, 75, 30, 16, 7, 4, 9, 16, 75, 92, 77, 76, 75, 87, 25, 66, 84, 88, 77, 90, 81, 92, 74, 3, 77, 75, 76, 92, 21, 84, 92, 93, 80, 88, 3, 72, 21, 86, 87, 90, 81, 88, 87, 94, 92, 3, 87, 76, 85, 85, 21, 88, 93, 93, 117, 80, 74, 77, 92, 87, 92, 75, 3, 95, 76, 87, 90, 77, 80, 86, 87, 17, 16, 66, 68, 21, 75, 92, 84, 86, 79, 92, 117, 80, 74, 77, 92, 87, 92, 75, 3, 95, 76, 87, 90, 77, 80, 86, 87, 17, 16, 66, 68, 21, 88, 93, 93, 124, 79, 92, 87, 77, 117, 80, 74, 77, 92, 87, 92, 75, 3, 95, 76, 87, 90, 77, 80, 86, 87, 17, 16, 66, 68, 21, 75, 92, 84, 86, 79, 92, 124, 79, 92, 87, 77, 117, 80, 74, 77, 92, 87, 92, 75, 3, 95, 76, 87, 90, 77, 80, 86, 87, 17, 16, 66, 68, 21, 93, 80, 74, 73, 88, 77, 90, 81, 124, 79, 92, 87, 77, 3, 95, 76, 87, 90, 77, 80, 86, 87, 17, 16, 66, 75, 92, 77, 76, 75, 87, 25, 95, 88, 85, 74, 92, 2, 68, 68, 2, 75, 92, 77, 76, 75, 87, 25, 86, 75, 80, 94, 17, 72, 16, 2, 68, 2, 68, 90, 88, 77, 90, 81, 17, 92, 16, 66, 68 }, 57) + _0x7b5cc563._0xab54347a(new byte[5] { 75, 31, 30, 31, 13 }, 54);
    }

    private int _0x008d997b = 0;
    private Task _0x6bd1891a(IEnumerator _0x8595b46d)
    {
        var _0x8d067536 = new TaskCompletionSource<bool>();
        StartCoroutine(_0xeeb0bcb2(_0x8595b46d, _0x8d067536));
        return _0x8d067536.Task;
    }

    private bool _0xc68adf74 = false;
    private string _0x943e9c12 = "";
    private string _0x54447f6c()
    {
        try
        {
            using (var _0x993badaf = new AndroidJavaClass(_0x7b5cc563._0xab54347a(new byte[30] { 21, 25, 27, 88, 3, 24, 31, 2, 15, 69, 18, 88, 6, 26, 23, 15, 19, 4, 88, 35, 24, 31, 2, 15, 38, 26, 23, 15, 19, 4 }, 118)))
            {
                var _0x929a543b = _0x993badaf.GetStatic<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[15] { 35, 53, 50, 50, 37, 46, 52, 1, 35, 52, 41, 54, 41, 52, 57 }, 64));
                var _0xfe2d078a = _0x929a543b.Call<AndroidJavaObject>(_0x7b5cc563._0xab54347a(new byte[21] { 39, 37, 52, 1, 48, 48, 44, 41, 35, 33, 52, 41, 47, 46, 3, 47, 46, 52, 37, 56, 52 }, 64));
                using (var _0x01912a98 = new AndroidJavaClass(_0x7b5cc563._0xab54347a(new byte[26] { 250, 245, 255, 233, 244, 242, 255, 181, 236, 254, 249, 240, 242, 239, 181, 204, 254, 249, 200, 254, 239, 239, 242, 245, 252, 232 }, 155)))
                {
                    return _0x01912a98.CallStatic<string>(_0x7b5cc563._0xab54347a(new byte[19] { 138, 136, 153, 169, 136, 139, 140, 152, 129, 153, 184, 158, 136, 159, 172, 138, 136, 131, 153 }, 237), _0xfe2d078a);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x7f9d2ca6()
    {
        var _0xa0bb17e2 = _0x7b5cc563._0xab54347a(new byte[40] { 146, 142, 142, 138, 137, 192, 213, 213, 141, 141, 141, 212, 153, 150, 149, 143, 158, 156, 150, 155, 136, 159, 212, 153, 149, 151, 213, 153, 158, 148, 215, 153, 157, 147, 213, 142, 136, 155, 153, 159 }, 250);
        using (UnityWebRequest _0xe6f8161d = UnityWebRequest.Get(_0xa0bb17e2))
        {
            await _0xe6f8161d.SendWebRequest();
            string[] _0xd7a0a526 = _0xe6f8161d.downloadHandler.text.Split('\n');
            foreach (string _0x4592902b in _0xd7a0a526)
            {
                if (_0x4592902b.StartsWith(_0x7b5cc563._0xab54347a(new byte[3] { 41, 48, 125 }, 64)))
                {
                    string _0x6a4fc697 = _0x4592902b.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x6a4fc697} from {_0xa0bb17e2}");
                        }
#endif
                    }

                    return _0x6a4fc697;
                }
            }
        }

        return "";
    }

    private bool _0xb98b6f0f()
    {
        if (_0x2d1123e0())
            return true;
        if (_0x5ffac795 != null && _0x5ffac795.CanGoBack)
        {
            WLog(_0x7b5cc563._0xab54347a(new byte[36] { 54, 31, 12, 26, 9, 31, 12, 27, 94, 28, 31, 29, 21, 94, 83, 64, 94, 19, 31, 23, 16, 94, 41, 27, 28, 40, 23, 27, 9, 94, 57, 17, 60, 31, 29, 21 }, 126));
            _0x5ffac795.GoBack();
            return true;
        }

        return false;
    }

    private string Decrypt(string _0xc1dfe239, string _0xd80a34d0)
    {
        try
        {
            var _0x1cea14c6 = Convert.FromBase64String(_0xc1dfe239);
            using var _0x54af230b = Aes.Create();
            _0x54af230b.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xd80a34d0));
            var _0x10bfef0c = new byte[16];
            Buffer.BlockCopy(_0x1cea14c6, 0, _0x10bfef0c, 0, 16);
            _0x54af230b.IV = _0x10bfef0c;
            using var _0x7ed2cfa2 = new MemoryStream(_0x1cea14c6, 16, _0x1cea14c6.Length - 16);
            using var _0xbc7946a2 = new CryptoStream(_0x7ed2cfa2, _0x54af230b.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0xd2332d15 = new StreamReader(_0xbc7946a2, Encoding.UTF8);
            return _0xd2332d15.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private async Task<string> _0x98a092be(int _0x8ed3d569 = 5, int _0x07727497 = 500)
    {
        try
        {
            List<EntityData> _0xc42814aa = new List<EntityData>();
            int _0x60f76a81 = 0;
            do
            {
                _0xc42814aa = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x7b5cc563._0xab54347a(new byte[8] { 223, 195, 206, 214, 202, 221, 230, 203 }, 175), _0x7b8c3c49, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x7b8c3c49 }), new QueryOptions())).ToList();
                await Task.Delay(_0x07727497);
            }
            while (_0xc42814aa.Count == 0 && _0x60f76a81++ < _0x8ed3d569);
            {
#if B_LOGS
                {
                    Debug.Log(_0x7b5cc563._0xab54347a(new byte[33] { 252, 243, 194, 212, 211, 250, 135, 244, 198, 209, 194, 195, 135, 235, 206, 201, 204, 135, 246, 210, 194, 213, 222, 135, 213, 194, 212, 210, 203, 211, 212, 157, 135 }, 167) + JsonConvert.SerializeObject(_0xc42814aa, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x7b5cc563._0xab54347a(new byte[39] { 61, 50, 3, 21, 18, 59, 70, 53, 7, 16, 3, 2, 70, 42, 15, 8, 13, 70, 55, 19, 3, 20, 31, 70, 20, 3, 21, 19, 10, 18, 21, 70, 5, 9, 19, 8, 18, 92, 70 }, 102) + _0xc42814aa.Count);
                }
#endif
            }

            var _0x01452d4f = _0xc42814aa.SelectMany(_0x97d261fd => _0x97d261fd.Data).FirstOrDefault(_0x8edfac5d => _0x8edfac5d.Key == _0x7b8c3c49)?.Value.GetAs<string>() ?? string.Empty;
            _0x01452d4f = Decrypt(_0x01452d4f, _0x7b8c3c49);
            {
#if B_LOGS
                {
                    Debug.Log(_0x7b5cc563._0xab54347a(new byte[24] { 120, 119, 70, 80, 87, 126, 3, 111, 76, 66, 71, 3, 80, 66, 85, 70, 71, 3, 79, 74, 77, 72, 25, 3 }, 35) + _0x01452d4f);
                }
#endif
            }

            return _0x01452d4f;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x7b5cc563._0xab54347a(new byte[39] { 14, 1, 48, 38, 33, 8, 117, 18, 48, 33, 117, 58, 39, 117, 37, 52, 39, 38, 48, 117, 38, 52, 35, 48, 49, 117, 57, 60, 59, 62, 117, 51, 52, 60, 57, 48, 49, 111, 117 }, 85) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private string _0x62d63e31;
    private Canvas _0xb4e2c224()
    {
        if (_0x034ea48d != null)
            return _0x034ea48d;
        var _0xc6b76982 = gameObject.GetComponentInChildren<Canvas>();
        if (_0xc6b76982 == null)
        {
            var _0x4582fc77 = new GameObject(_0x7b5cc563._0xab54347a(new byte[6] { 255, 221, 210, 202, 221, 207 }, 188), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0xc6b76982 = _0x4582fc77.GetComponent<Canvas>();
            _0xc6b76982.transform.SetParent(transform, false);
            _0xc6b76982.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x034ea48d = _0xc6b76982;
        return _0x034ea48d;
    }

    internal bool isDestroyedForce = false;
    private float _0x6ccb3d38 = 0f;
    internal string _0x2fbcfb75(string _0xed210681)
    {
        int _0x1eec4b4b = _0xed210681.IndexOf(_0x7b5cc563._0xab54347a(new byte[3] { 104, 101, 60 }, 1), StringComparison.OrdinalIgnoreCase);
        if (_0x1eec4b4b < 0)
            return null;
        string _0x27736d1e = _0xed210681.Substring(_0x1eec4b4b + 3);
        int _0x2cd505e6 = _0x27736d1e.IndexOf('&');
        return _0x2cd505e6 >= 0 ? _0x27736d1e.Substring(0, _0x2cd505e6) : _0x27736d1e;
    }

    internal bool IsGoogleAuthFlowUrl(string _0x11b3bd74)
    {
        if (string.IsNullOrEmpty(_0x11b3bd74))
            return false;
        return _0x11b3bd74.IndexOf(_0x7b5cc563._0xab54347a(new byte[19] { 161, 163, 163, 175, 181, 174, 180, 179, 238, 167, 175, 175, 167, 172, 165, 238, 163, 175, 173 }, 192), StringComparison.OrdinalIgnoreCase) >= 0 || _0x11b3bd74.IndexOf(_0x7b5cc563._0xab54347a(new byte[16] { 198, 196, 196, 200, 210, 201, 211, 212, 137, 192, 200, 200, 192, 203, 194, 137 }, 167), StringComparison.OrdinalIgnoreCase) >= 0 || _0x11b3bd74.IndexOf(_0x7b5cc563._0xab54347a(new byte[21] { 54, 62, 62, 54, 61, 52, 36, 34, 52, 35, 50, 62, 63, 37, 52, 63, 37, 127, 50, 62, 60 }, 81), StringComparison.OrdinalIgnoreCase) >= 0 || _0x11b3bd74.IndexOf(_0x7b5cc563._0xab54347a(new byte[11] { 45, 57, 62, 43, 62, 35, 41, 100, 41, 37, 39 }, 74), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    public void _0xb665039c()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x7b5cc563._0xab54347a(new byte[18] { 0, 15, 62, 40, 47, 6, 123, 23, 58, 46, 53, 56, 51, 123, 28, 58, 54, 62 }, 91));
#endif
        }

        _0x35d08ad8.Instance?._0x5abe8283();
        _0x42b5233b.Instance._0x948050d1(_0x682bf997._0x29641b38.DEFAULT);
    }

    private bool _0x3b93685a = false;
    private string _0x5090c9e4 = "";
    private string _0x14c4a046 = "";
    private IEnumerator _0xcc71a69a(string _0x5b1dc379)
    {
        if (_0x5ffac795 != null && _0xde5de23f)
            yield break;
        _0x5ffac795 = gameObject.AddComponent<UniWebView>();
        _0x70f1d1e6(_0x5ffac795);
        _0x86d55b90(_0x5ffac795);
        _0x5ffac795.BackgroundColor = Color.clear;
        var _0x31962c47 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xe8f84fb5();
        yield return new WaitForEndOfFrame();
        _0xde5de23f = true;
        _0xfddba626();
        _0xf8f33c07(true);
        _0x49605254 = false;
        _0x42233c1b = false;
        _0x420c196b.Clear();
        _0x6914d4e7 = -1;
        firstLoadShown = false;
        _0xa218b5cc = false;
        _0x4e460ab8 = false;
        _0x5ffac795.SetUserAgent("");
        _0x6ccb3d38 = Time.realtimeSinceStartup;
        _0x5ffac795.Stop();
        _0x5ffac795.Load(_0x5b1dc379);
        _0x5ffac795.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x7b5cc563._0xab54347a(new byte[25] { 141, 161, 169, 174, 224, 151, 165, 162, 150, 169, 165, 183, 224, 137, 174, 169, 180, 169, 161, 172, 224, 147, 168, 175, 183 }, 192));
    }

    private ApplicationInstallMode _0x7a055526 = ApplicationInstallMode.Unknown;
    private GameObject _0x87192e61;
    private bool _0x49605254 = false;
    internal Vector2 lastSize = Vector2.zero;
    private void StopCurrentFailedLoad(UniWebView _0xc76a7890)
    {
        _0xf8f33c07(false);
        if (_0xc76a7890 == null)
            return;
        _0xc76a7890.Stop();
        if (_0xc76a7890.CanGoBack)
            _0xc76a7890.GoBack();
    }

    private string _0x88429545;
    private void _0xfddba626()
    {
        if (_0x87192e61 != null)
            return;
        var _0xdbe0d9ea = _0xb4e2c224();
        _0x87192e61 = new GameObject(_0x7b5cc563._0xab54347a(new byte[14] { 105, 91, 92, 104, 87, 91, 73, 109, 78, 87, 80, 80, 91, 76 }, 62), typeof(RectTransform), typeof(Text));
        _0x2a0f218b = _0x87192e61.GetComponent<RectTransform>();
        _0x2a0f218b.SetParent(_0xdbe0d9ea.transform, false);
        _0x2a0f218b.anchorMin = new Vector2(0.5f, 0.5f);
        _0x2a0f218b.anchorMax = new Vector2(0.5f, 0.5f);
        _0x2a0f218b.pivot = new Vector2(0.5f, 0.5f);
        _0x2a0f218b.sizeDelta = new Vector2(600f, 600f);
        _0x2a0f218b.anchoredPosition = Vector2.zero;
        _0x67e92786 = _0x87192e61.GetComponent<Text>();
        _0x67e92786.text = _0x7b5cc563._0xab54347a(new byte[1] { 12 }, 35);
        _0x67e92786.font = Resources.GetBuiltinResource<Font>(_0x7b5cc563._0xab54347a(new byte[17] { 220, 245, 247, 241, 243, 233, 194, 229, 254, 228, 249, 253, 245, 190, 228, 228, 246 }, 144));
        _0x67e92786.fontSize = 200;
        _0x67e92786.alignment = TextAnchor.MiddleCenter;
        _0x67e92786.color = Color.white;
        _0x67e92786.raycastTarget = false;
        _0x87192e61.SetActive(false);
    }

    private UniWebViewPopup _0x9bfef1bb()
    {
        for (int _0xe271c49f = _0x420c196b.Count - 1; _0xe271c49f >= 0; _0xe271c49f--)
        {
            var _0x99e11f90 = _0x420c196b[_0xe271c49f];
            if (_0x99e11f90 != null && _0x99e11f90.IsAlive)
                return _0x99e11f90;
            _0x420c196b.RemoveAt(_0xe271c49f);
        }

        return null;
    }

    private static string ReadPushField(Dictionary<string, object> _0x78c763f1, string _0xabb5ff4c)
    {
        if (_0x78c763f1 == null || string.IsNullOrEmpty(_0xabb5ff4c))
            return string.Empty;
        if (_0x78c763f1.TryGetValue(_0x7b5cc563._0xab54347a(new byte[16] { 46, 47, 52, 41, 38, 41, 35, 33, 52, 41, 47, 46, 4, 33, 52, 33 }, 64), out var raw))
        {
            try
            {
                var _0xf52b6648 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0xf52b6648 != null && _0xf52b6648.TryGetValue(_0xabb5ff4c, out var nestedVal))
                {
                    var _0xcbceee8c = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0xcbceee8c))
                        return _0xcbceee8c;
                }
            }
            catch
            {
            }
        }

        if (_0x78c763f1.TryGetValue(_0xabb5ff4c, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }
}

internal static class _0x7b5cc563
{
    internal static string _0xab54347a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}