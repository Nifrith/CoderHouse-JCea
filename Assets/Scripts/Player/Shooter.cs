using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [Header("General")]
    [SerializeField] GameObject projectile;
    [SerializeField] float projectileSpeed = 10f;
    [SerializeField] float projectileLifetime = 5f;
    [SerializeField] float baseFiringRate = 0.2f;

    [Header("AI")]
    [SerializeField] float firingRateVariance = 0f;
    [SerializeField] float minimunFiringRate = 0.1f;
    [SerializeField] bool useAI;


    [HideInInspector]public bool isFiring;
    Coroutine firingCoroutine;

    void Start()
    {
        if (useAI)
        {
            isFiring = true;
        }
    }


    void Update()
    {
        Fire();
    }

    void Fire()
    {
        if (isFiring && firingCoroutine == null)
        {
            firingCoroutine = StartCoroutine(FireContinuously());
        }
        else if (!isFiring && firingCoroutine != null)
        {
            StopCoroutine(firingCoroutine);
            firingCoroutine = null;
        }

    }

    IEnumerator FireContinuously()
    {
        while (true)
        {
            GameObject instance = Instantiate(projectile,
                                transform.position,
                                Quaternion.identity);

            Rigidbody2D rb = instance.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = transform.right * projectileSpeed;
            }

            Destroy(instance, projectileLifetime);
            float timeToNextProjectile = Random.Range(baseFiringRate - firingRateVariance, baseFiringRate + firingRateVariance);
            timeToNextProjectile = Mathf.Clamp(timeToNextProjectile, minimunFiringRate, float.MaxValue);
            yield return new WaitForSeconds(timeToNextProjectile);
        }
    }

}
