using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject endScreen;
    [SerializeField] Image attackedImage;
    [SerializeField] GameObject congratsScreen;
    [SerializeField] GameObject monitorScreen;

    public void enableEndScreen()
    {
        endScreen.SetActive(true);
    }
    public void enableAttackedImage()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(attackedImage.DOFade(.15f, .3f));
        sequence.SetLoops(3, LoopType.Yoyo);
    }

    public void enableMonitorScreen()
    {
        monitorScreen.SetActive(true);
    }
    public void enableCongratsPanel()
    {
        congratsScreen.SetActive(true);
    }
}
