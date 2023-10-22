public partial class EButton
{
    public class BeginVerticalAttribute : EButtonBaseAttribute
    {
        public string text;

        public BeginVerticalAttribute()
        {

        }

        public BeginVerticalAttribute(string text)
        {
            this.text = text;
        }
    }
}