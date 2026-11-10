namespace Pr8;
class VoinT : Voin
{
    public VoinT()
    {
        img = "avares://Pr8/Img/VoinT.jpg";
    }
    public override void mdamage(float _damage)
    {
        hp -= _damage * 0.5F;
        if (hp < 0)
            hp = 0;
    }
}