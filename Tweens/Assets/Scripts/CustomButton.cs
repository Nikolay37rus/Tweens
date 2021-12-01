using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CustomButton : Button
{
    public static string ChangeButtonType = nameof(_buttonType);
    public static string Daration = nameof(_duration);

    [SerializeField]
    private AnimationButtonType _buttonType;

    [SerializeField]
    private float _duration;

    private RectTransform _rectTransform;

    protected override void Awake()
    {
        base.Awake();

        _rectTransform = GetComponent<RectTransform>();
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);

        ActivateAnimation();
    }

    private void ActivateAnimation()
    {
        switch (_buttonType)
        {
            case AnimationButtonType.ChangePosition:
                _rectTransform.DOShakePosition(_duration, 3, 5);
                break;

            case AnimationButtonType.ChangeRotation:
                _rectTransform.DOShakeRotation(_duration, 3, 5);
                break;

        }
    }
}
