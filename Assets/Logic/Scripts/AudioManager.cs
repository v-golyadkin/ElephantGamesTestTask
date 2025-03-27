using UnityEngine;

[RequireComponent(typeof(SoundLibrary))]
[RequireComponent(typeof(MusicLibrary))]
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Audio Source")]
    [SerializeField] private AudioSource _sfxSource;
    [SerializeField] private AudioSource _musicSource;

    private SoundLibrary _sfxLibrary;
    private MusicLibrary _musicLibrary;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        _sfxLibrary = GetComponent<SoundLibrary>();
        _musicLibrary = GetComponent<MusicLibrary>();
    }

    public void Start()
    {
        ChangeMusic("main_menu");
    }

    public void PlaySFX(string sfxName)
    {
        _sfxSource.PlayOneShot(_sfxLibrary.GetClipFromName(sfxName), _sfxLibrary.GetVolume(sfxName));
    }

    public void ChangeMusic(string musicName)
    {
        _musicSource.clip = _musicLibrary.GetClipFromName(musicName);
        _musicSource.Play();
    }
}
