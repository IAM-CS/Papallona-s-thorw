using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int _posx;
    private int _posy;
    private int _life;

    public Enemy(int x, int y, int hp)
    {
        _posx = x;
        _posy = y;
        if(hp < 1)
        {
            hp = 0;
        }
        _life = hp;
    }

    public int Posx
    {
        get
        {
            return _posx;
        }
        set
        {
            _posx = value;
        }
    }
        public int Posy
        {
            get
            {
                return _posy;
            }
            set
            {
                _posy = value;
            }
        }

    public int Life
    {
        get
        {
            return _life;
        }
        set
        {
            if(value < 1)
            {
                _life = 0;
            }

            else
            {
                _life = value;
            }
        }
    }

    public void IniPos(int x, int y)
    {
        _posx = x;
        _posy = y;
    }

    
}
