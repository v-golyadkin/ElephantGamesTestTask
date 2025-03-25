using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Collider2D))]
public class GreenSlimeAnimatorContoller : MonoBehaviour
{
    [SerializeField] private GameObject _clickVFX;
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnMouseUp()
    {
        _animator.SetTrigger("jump");
        AudioManager.Instance.PlaySFX("click_slime");
        Instantiate(_clickVFX, gameObject.transform.position, Quaternion.identity);
    }
}
