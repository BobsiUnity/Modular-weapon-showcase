public partial class EButtonAttribute : EButtonBaseAttribute
{
    public string text;

    public EButtonAttribute()
    {

    }

    public EButtonAttribute(string text)
    {
        this.text = text;
    }
}