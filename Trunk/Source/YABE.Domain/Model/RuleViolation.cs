namespace YABE.Domain.Model
{
    public class RuleViolation
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public string Message { get; set; }

        public RuleViolation(string name, string message)
        {
            Name = name;
            Message = message;            
        }

        public RuleViolation(string name, object value, string message)
        {
            Name = name;
            Value = value;
            Message = message;
        }
    }
}