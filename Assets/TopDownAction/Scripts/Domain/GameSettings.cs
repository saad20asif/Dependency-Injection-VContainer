// Domain/GameSettings.cs
using UnityEngine;

namespace TopdownAction.Domain
{
    [CreateAssetMenu(fileName = "GameSettings", menuName = "TopdownAction/Game Settings")]
    public class GameSettings : ScriptableObject
    {
        [Header("Player")]
        public float moveSpeed = 5f;
        public float fireRate = 0.25f;
        public int maxHealth = 100;

        [Header("Enemies")]
        public float enemySpawnInterval = 2f;
        public int enemyMaxConcurrent = 20;
    }
}