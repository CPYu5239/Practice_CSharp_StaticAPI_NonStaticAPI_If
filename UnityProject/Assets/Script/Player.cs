using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [Header("血量")]
    public int hp = 100;
    [Header("攻擊")]
    public int attack;
    [Header("殭屍")]
    public Zombie zombie;
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
        if (Input.GetKeyDown(KeyCode.A))
        {
            attack = Random.Range(5, 20);
            zombie.hp -= attack;
            aud.PlayOneShot(clip, 1);
            print("<color=green>殭屍受到" + attack + "傷害。</color>");
            print("<color=green>殭屍剩餘血量 : " + zombie.hp + "</color>");
            if (zombie.hp < 0)
            {
                print("<color=green>殭屍死亡</color>");
            }
        }
    }
}
