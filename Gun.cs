using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "Gun")]
public class Gun : ScriptableObject
{
    public string name;

    public float firerate;
    public float bloom;
    public float recoil;
    public float kickback;
    public float aimSpeed;
    public float reload;

    public int damage;
    public int ammo;
    public int clipsize;
    public int burst; // 0 semi | 1 auto | 2+ burst fire

    public GameObject prefab;

    private int clip; //current bullets in the clip
    private int stash; //current ammo

    public void Initialize()
    {
        stash = ammo;
        clip = clipsize;
    }

    public bool fireBullet()
    {
        if (clip > 0)
        {
            clip -= 1;
            return true;
        }
        else return false;
    }

    public void Reload()
    {
        stash += clip;
        clip = Mathf.Min(clipsize, stash);
        stash -= clip;
    }

    public int GetStash() { return stash; }
    public int GetClip() { return clip; }
}
