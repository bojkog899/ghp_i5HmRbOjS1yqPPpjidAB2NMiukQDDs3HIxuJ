using UnityEngine;

// Persistent climb records. Keys are explicit literals so obfuscation cannot
// rename them out from under a shipped save (C "stable ids").
public static class _0x69baa7e4
{
    public static void Unlock(int _0xe23ef8d8)
    {
        int _0x2ce72e0f = Mathf.Clamp(_0xe23ef8d8 + 2, 1, _0xe6c2d6f3.Count);
        if (_0x2ce72e0f > _0x69baa7e4._0xd9497139)
        {
            PlayerPrefs.SetInt(UnlockedKey, _0x2ce72e0f);
            PlayerPrefs.Save();
        }
    }

    private static readonly string BestKeyPrefix = _0xa8798156._0x4d510e00(new byte[15] { 55, 35, 30, 35, 36, 50, 53, 30, 50, 36, 34, 53, 46, 51, 30 }, 65);
    // The setter pushes the new value into every MoneyCount under the scene Root,
    // which only exists once BasicController has woken up.
    private static void StoreCoins(int _0x0bc18901)
    {
        if (_0xcefca5e5.Instance == null)
        {
            PlayerPrefs.SetInt(_0xa8798156._0x4d510e00(new byte[5] { 113, 93, 91, 92, 65 }, 50), _0x0bc18901);
            PlayerPrefs.Save();
            return;
        }

        if (_0x682bf997._0x99de7efd._0xd2149585 != _0x0bc18901)
        {
            _0x682bf997._0x99de7efd._0xd2149585 = _0x0bc18901;
        }
    }

    public static int OverallBest()
    {
        int _0xce0a0512 = 0;
        for (int _0xe1fa8e29 = 0; _0xe1fa8e29 < _0xe6c2d6f3.Count; _0xe1fa8e29++)
        {
            _0xce0a0512 = Mathf.Max(_0xce0a0512, _0x69baa7e4.BestFor(_0xe1fa8e29));
        }

        return _0xce0a0512;
    }

    private static readonly string SelectedKey = _0xa8798156._0x4d510e00(new byte[18] { 81, 69, 120, 84, 66, 75, 66, 68, 83, 66, 67, 120, 84, 66, 68, 83, 72, 85 }, 39);
    // The template's MoneyCount reads SETTINGS.PlayerSYSTEM.Coins, and it is the only
    // readout slot the shell owns. There is no currency in this game, so that slot
    // carries the best altitude in metres instead.
    public static void PublishOverallBest()
    {
        _0x69baa7e4.StoreCoins(_0x69baa7e4.OverallBest());
    }

    private static readonly string AttemptKey = _0xa8798156._0x4d510e00(new byte[18] { 141, 153, 164, 154, 143, 143, 158, 150, 139, 143, 164, 152, 148, 142, 149, 143, 158, 137 }, 251);
    public static int _0x107c22cb
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(SelectedKey, 0), 0, _0xe6c2d6f3.Count - 1);
        }

        set
        {
            PlayerPrefs.SetInt(SelectedKey, Mathf.Clamp(value, 0, _0xe6c2d6f3.Count - 1));
            PlayerPrefs.Save();
        }
    }

    public static int BestFor(int _0xeca23217)
    {
        return PlayerPrefs.GetInt(BestKeyPrefix + _0xeca23217.ToString(), 0);
    }

    public static int NextAttempt()
    {
        int _0x572a7825 = PlayerPrefs.GetInt(AttemptKey, 0) + 1;
        PlayerPrefs.SetInt(AttemptKey, _0x572a7825);
        PlayerPrefs.Save();
        return _0x572a7825;
    }

    public static void StoreBest(int _0x74a43b78, int _0x4a11c583)
    {
        if (_0x4a11c583 <= _0x69baa7e4.BestFor(_0x74a43b78))
        {
            return;
        }

        PlayerPrefs.SetInt(BestKeyPrefix + _0x74a43b78.ToString(), _0x4a11c583);
        PlayerPrefs.Save();
        _0x69baa7e4.PublishOverallBest();
    }

    public static void ResetAll()
    {
        for (int _0x4c6fe85f = 0; _0x4c6fe85f < _0xe6c2d6f3.Count; _0x4c6fe85f++)
        {
            PlayerPrefs.DeleteKey(BestKeyPrefix + _0x4c6fe85f.ToString());
        }

        PlayerPrefs.SetInt(UnlockedKey, 1);
        PlayerPrefs.SetInt(SelectedKey, 0);
        PlayerPrefs.Save();
        _0x69baa7e4.StoreCoins(0);
    }

    public static int _0xd9497139
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(UnlockedKey, 1), 1, _0xe6c2d6f3.Count);
        }
    }

    private static readonly string UnlockedKey = _0xa8798156._0x4d510e00(new byte[19] { 221, 201, 244, 222, 197, 199, 196, 200, 192, 206, 207, 244, 216, 206, 200, 223, 196, 217, 216 }, 171);
}

internal static class _0xa8798156
{
    internal static string _0x4d510e00(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}