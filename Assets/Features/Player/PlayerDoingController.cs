using Features.Weapon;
using UnityEngine;


namespace Features.Player
{
    public class PlayerDoingController : MonoBehaviour
    {
        [SerializeField] private Transform weaponParent;
        [SerializeField] private Rigidbody rigidbody;
        [SerializeField] private PlayerData data;
        private WeaponController _currentWeapon = default;

        public void OnMove(float xAxis, float zAxis)
        {
            Vector3 forward = transform.forward * zAxis;
            Vector3 right = transform.right * xAxis;
            Vector3 velocity = forward + right;
            velocity.y = rigidbody.velocity.y;
            rigidbody.velocity = velocity;
        }

        public void OnThrow()
        {
            if (!_currentWeapon)
                return;
            _currentWeapon.Pickup(false);
            _currentWeapon.transform.parent = null;
            _currentWeapon.Throw(transform.forward, data.ThrowForce);
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.transform.TryGetComponent(out WeaponController controller))
            {
                _currentWeapon = controller;
                _currentWeapon.Pickup(true);
                _currentWeapon.transform.parent = weaponParent;
                _currentWeapon.transform.localPosition = Vector3.zero;
            }
        }
    }
}
