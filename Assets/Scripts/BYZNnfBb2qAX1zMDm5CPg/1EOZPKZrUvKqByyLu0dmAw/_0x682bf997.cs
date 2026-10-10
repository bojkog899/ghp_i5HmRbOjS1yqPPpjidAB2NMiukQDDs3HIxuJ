using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x682bf997
{
    public class _0x2cf54a02
    {
        private static readonly _0x2cf54a02 _0x046d18fd = new();
        public static readonly _0x2cf54a02[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x046d18fd,
            _0x046d18fd,
            _0x046d18fd,
        };
        private int _0x8ce277ba => 0;
        private int _0x941c1f5f => 10;
        private string _0xcec9e1e4 => _0x1d32e28a._0x9c8df742(new byte[4] { 142, 166, 173, 182 }, 195);
        private string _0xd74d8ca5 => _0x1d32e28a._0x9c8df742(new byte[8] { 141, 132, 151, 132, 141, 186, 241, 188 }, 193);

        private int _0x2c0ee70f
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x1d32e28a._0x9c8df742(new byte[25] { 38, 16, 23, 23, 0, 11, 17, 34, 9, 10, 7, 4, 9, 38, 13, 4, 21, 17, 0, 23, 44, 11, 1, 0, 29 }, 101)))
                    PlayerPrefs.SetInt(_0x1d32e28a._0x9c8df742(new byte[25] { 126, 72, 79, 79, 88, 83, 73, 122, 81, 82, 95, 92, 81, 126, 85, 92, 77, 73, 88, 79, 116, 83, 89, 88, 69 }, 61), 0);
                return PlayerPrefs.GetInt(_0x1d32e28a._0x9c8df742(new byte[25] { 213, 227, 228, 228, 243, 248, 226, 209, 250, 249, 244, 247, 250, 213, 254, 247, 230, 226, 243, 228, 223, 248, 242, 243, 238 }, 150));
            }

            set => PlayerPrefs.SetInt(_0x1d32e28a._0x9c8df742(new byte[25] { 150, 160, 167, 167, 176, 187, 161, 146, 185, 186, 183, 180, 185, 150, 189, 180, 165, 161, 176, 167, 156, 187, 177, 176, 173 }, 213), value);
        }

        public int _0x0f7bd499
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xcec9e1e4}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0xcec9e1e4}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0xcec9e1e4}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0xcec9e1e4}CurrentLevelIndex", value);
        }

        public int _0x6b153811
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xcec9e1e4}BestScore"))
                    this._0x6b153811 = 0;
                return PlayerPrefs.GetInt($"{this._0xcec9e1e4}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0xcec9e1e4}BestScore", value);
        }

        public bool _0x92e9e7c7
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xcec9e1e4}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0xcec9e1e4}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0xcec9e1e4}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0xcec9e1e4}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x03d597f1
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0x29641b38
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0x6a7890bf
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x99de7efd
    {
        public static int _0xd2149585
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x1d32e28a._0x9c8df742(new byte[5] { 222, 242, 244, 243, 238 }, 157)))
                    PlayerPrefs.SetInt(_0x1d32e28a._0x9c8df742(new byte[5] { 178, 158, 152, 159, 130 }, 241), 0);
                return PlayerPrefs.GetInt(_0x1d32e28a._0x9c8df742(new byte[5] { 29, 49, 55, 48, 45 }, 94));
            }

            set
            {
                PlayerPrefs.SetInt(_0x1d32e28a._0x9c8df742(new byte[5] { 149, 185, 191, 184, 165 }, 214), value);
                _0xcefca5e5.Instance._0x24d33062();
            }
        }
    }
}

internal static class _0x1d32e28a
{
    internal static string _0x9c8df742(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}