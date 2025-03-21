using UnityEngine;

public class PianoKey : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Lấy AudioSource của phím đàn
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        // Khi người chơi nhấn vào phím, phát âm thanh
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    public class PianoManager : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A)) PlaySound("do");
            if (Input.GetKeyDown(KeyCode.S)) PlaySound("re");
            if (Input.GetKeyDown(KeyCode.D)) PlaySound("mi");
            if (Input.GetKeyDown(KeyCode.F)) PlaySound("fa");
            if (Input.GetKeyDown(KeyCode.G)) PlaySound("sol");
            if (Input.GetKeyDown(KeyCode.H)) PlaySound("la");
            if (Input.GetKeyDown(KeyCode.J)) PlaySound("si");
            if (Input.GetKeyDown(KeyCode.K)) PlaySound("do2");
        }

        void PlaySound(string noteTag)
        {
            GameObject key = GameObject.FindWithTag(noteTag);
            if (key != null)
            {
                AudioSource audio = key.GetComponent<AudioSource>();
                if (audio != null)
                {
                    audio.Play();
                }
            }
        }
    }
}

