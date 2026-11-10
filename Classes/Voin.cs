namespace Pr8;
class Voin
{
    public float hp { get; set; }
    public string img { get; set; }
    public Voin()
    {
        hp = 100;
        img = "avares://Pr8/Img/Voin.jpg";
    }
    public virtual void mdamage(float _damage)
    {
        hp -= _damage;
        if (hp < 0)
            hp = 0;
    }
}