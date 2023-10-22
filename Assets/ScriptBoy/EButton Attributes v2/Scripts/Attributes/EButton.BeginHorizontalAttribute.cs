public partial class EButton
{
    public class BeginHorizontalAttribute : EButtonBaseAttribute
    {
        public string text;

        public BeginHorizontalAttribute()
        {

        }

        public BeginHorizontalAttribute(string text)
        {
            this.text = text;
        }
    }
}