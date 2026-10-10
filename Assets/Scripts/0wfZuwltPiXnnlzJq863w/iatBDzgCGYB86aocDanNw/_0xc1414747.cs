using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x682bf997;

public class _0xc1414747 : MonoBehaviour
{
    public _0x8e511e3c _0x0a70eb9c(int _0x7f008209)
    {
        return this.Pops[_0x7f008209];
    }

    public static _0xc1414747 Instance;
    public int CurrentPopIndex;
    public void _0x3b9ea76e()
    {
        this.LastPopIndexes.Clear();
        this._0x84017273();
        foreach (GameObject _0xc7ecb4bf in this.GameObjectsToHide)
            if (_0xc7ecb4bf != null)
                _0xc7ecb4bf.SetActive(true);
        this._0xf30188dc();
    }

    public List<_0x8e511e3c> Pops;
    public List<GameObject> GameObjectsToHide;
    public GameObject BlurBackground;
    public List<int> LastPopIndexes = new();
    public void _0x40f6426c(int _0xc52843ab)
    {
        this.CurrentPopIndex = _0xc52843ab;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x84017273(true);
        this._0xc56cc8a0();
        this.Pops[_0xc52843ab].Show();
        foreach (GameObject _0xe02ffeb5 in this.GameObjectsToHide)
            _0xe02ffeb5.SetActive(false);
    }

    private void _0x84017273(bool _0x4413c11a = false)
    {
        for (int _0x3e6a25df = 0; _0x3e6a25df < this.Pops.Count; ++_0x3e6a25df)
            if (this.Pops[_0x3e6a25df] != null && !(_0x3e6a25df == this.CurrentPopIndex && _0x4413c11a))
                this.Pops[_0x3e6a25df]._0x8e724431();
    }

    private void _0xf30188dc()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public float ScaleDuration = 0.4f;
    private void _0xc56cc8a0()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public void _0x0c388a6e()
    {
        this.LastPopIndexes.RemoveAll(_0x2451a690 => _0x2451a690 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x3b9ea76e();
        else
            this._0x40f6426c(this.LastPopIndexes.Last());
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xc1414747>();
    }

    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x8e511e3c _0x6ea13ab8 in this.Pops)
            if (_0x6ea13ab8 != null)
                _0x6ea13ab8.gameObject.SetActive(true);
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }
}