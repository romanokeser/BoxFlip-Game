using UnityEngine;

public class ConfettiEffect : MonoBehaviour
{
    [SerializeField] private ParticleSystem _confettiParticles;

    private void Awake()
    {
        FinishLevel.OnLevelFinish += PlayConfettiEffect;
    }

    private void PlayConfettiEffect()
    {
        _confettiParticles.Play();
    }
}
