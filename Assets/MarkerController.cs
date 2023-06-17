using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MarkerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(transform.DOMoveY(1.5f, .9f)).SetRelative().SetLoops(1000,LoopType.Yoyo);
    }
}
