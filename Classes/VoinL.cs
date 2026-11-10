namespace Pr8;
class VoinL : Voin
{
    public VoinL()
    {
        img = "avares://Pr8/Img/VoinL.jpg";
    }
    public override void mdamage(int _damage)
    {
        hp -= _damage * 1.5F;
    }
}