using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject endScreen;
    [SerializeField] Image attackedImage;

   
    public void enableEndScreen()
    {
        endScreen.SetActive(true);
    }
    public void enableAttackedImage()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(attackedImage.DOFade(.15f, .3f));
        sequence.SetLoops(5, LoopType.Yoyo);
    }
}
