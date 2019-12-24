using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    [Header("血量")]
    public int hp = 100;
    [Header("攻擊")]
    public int attack;
    [Header("玩家")]
    public Player player;
    [Header("音源")]
    public AudioSource aud;
    [Header("音效")]
    public AudioClip clip;

    private void Update()
    {
        Attack();
        
    }

    private void Attack()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            attack = Random.Range(5, 20);
            player.hp -= attack;
            aud.PlayOneShot(clip, 1);
            print("<color=red>玩家受到" + attack + "傷害。</color>");
            print("<color=red>玩家剩餘血量 : " + player.hp + "</color>");
            if (player.hp <= 0)
            {
                print("<color=red>玩家死亡</color>");
            }
        }
    }
}
