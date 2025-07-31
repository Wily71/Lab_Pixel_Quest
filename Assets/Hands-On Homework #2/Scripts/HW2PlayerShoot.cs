using UnityEngine;

public class HW2PlayerShoot : MonoBehaviour
{
    public GameObject prefab;
    public Transform bulletTrash;
    public Transform bulletSpawn;
    public GameObject prefab2;
    public Transform bullet1;

    private const float Timer = 0.1f;
    private float _currentTime = 0.1f;
    private bool _canShoot = true;

    private void Update()
    {
        TimerMethod();
        Shoot();
    }

    private void TimerMethod()
    {
        if (!_canShoot)
        {
            _currentTime -= Time.deltaTime;

            if (_currentTime < 0)
            {
                _canShoot = true;
                _currentTime = Timer;
            }
        }
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && _canShoot)
        {
            GameObject bullet = Instantiate(prefab, bulletSpawn.position, Quaternion.identity);

            bullet.transform.SetParent(bulletTrash);

            _canShoot = false;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1) && _canShoot)
        {

            GameObject bullet = Instantiate(prefab2, bulletSpawn.position, Quaternion.identity);

            bullet.transform.SetParent(bullet1);

            _canShoot = false;
        }
    }
}
