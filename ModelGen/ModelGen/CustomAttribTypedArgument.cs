using System.Text;

namespace ModelGen;

public class CustomAttribTypedArgument: IOwnedElement
{
  public static bool operator ==(CustomAttribTypedArgument left, CustomAttribTypedArgument right) => left.Equals(right);
  public static bool operator !=(CustomAttribTypedArgument left, CustomAttribTypedArgument right) => !left.Equals(right);

  public object? Owner { get; set; }
  public Type ArgumentType => ArgumentTypeInfo.Type;
  public TypeInfo ArgumentTypeInfo { get; }

  public object? Value { get; }

  public CustomAttribTypedArgument(Type argumentType, object? value)
  {
    ArgumentTypeInfo = TypeManager.RegisterType(argumentType, this, Semantics.AttributeArg);
    Value = CanonicalizeValue(value);
  }

  public CustomAttribTypedArgument(object value) : this(value.GetType(), value)
  {
  }
  
  public override string ToString() => ToString(false);
  internal string ToString(bool typed)
  {

    if (ArgumentType.IsEnum)
      return typed ? $"{Value}" : $"({ArgumentType.FullName}){Value}";

    if (Value is null)
      return typed ? "null" : $"({ArgumentType.Name})null";

    if (ArgumentType == typeof(string))
      return $"\"{Value}\"";

    if (ArgumentType == typeof(char))
      return $"'{Value}'";

    if (ArgumentType == typeof(Type))
      return $"typeof({((Type)Value!).FullName})";

    if (ArgumentType.IsArray)
    {
      IList<CustomAttribTypedArgument> array = (IList<CustomAttribTypedArgument>)Value!;
      Type elementType = ArgumentType.GetElementType()!;

      var result = new StringBuilder();
      result.Append("new ");
      result.Append(elementType.IsEnum ? elementType.FullName : elementType.Name);
      result.Append('[');
      int count = array.Count;
      result.Append(count.ToString());
      result.Append("] { ");

      for (int i = 0; i < count; i++)
      {
        if (i != 0)
        {
          result.Append(", ");
        }
        result.Append(array[i].ToString(elementType != typeof(object)));
      }

      result.Append(" }");

      return result.ToString();
    }

    return typed ? $"{Value}" : $"({ArgumentType.Name}){Value}";
  }

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(object? obj) => obj == (object)this;

  private static object? CanonicalizeValue(object? value) => (value is Enum e) ? e : value;
}
