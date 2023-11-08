using System.Text;

namespace ModelGen;

/// <summary>
/// Represents the argument of the custom attribute. This argument is passed by the constructor.
/// </summary>
public class CustomAttribTypedArgument : IOwnedElement
{
  /// <summary>
  /// Used to implement <see cref="IOwnedElement"/>
  /// </summary>
  public object? Owner { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Type of the argument
  /// </summary>
  public TypeInfo Type { [DebuggerStepThrough] get; }

  /// <summary>
  /// Value of the argument
  /// </summary>
  public object? Value { [DebuggerStepThrough] get; }

  public CustomAttribTypedArgument(Type argumentType, object? value)
  {
    Type = TypeManager.RegisterType(argumentType);
    Value = CanonicalizeValue(value);
  }

  public CustomAttribTypedArgument(object? value) : this(value?.GetType() ?? typeof(object), value)
  {
  }

  public CustomAttribTypedArgument(CustomAttributeTypedArgument? value) : this(value?.ArgumentType ?? typeof(object), value?.Value)
  {
  }

  public override string ToString() => ToString(false);

  internal string ToString(bool typed)
  {
    var argumentType = Type.Type;
    if (argumentType.IsEnum)
      return typed ? $"{Value}" : $"({argumentType.FullName}){Value}";

    if (Value is null)
      return typed ? "null" : $"({argumentType.Name})null";

    if (argumentType == typeof(string))
      return $"\"{Value}\"";

    if (argumentType == typeof(char))
      return $"'{Value}'";

    if (argumentType == typeof(Type))
      return $"typeof({((Type)Value!).FullName})";

    if (argumentType.IsArray)
    {
      IList<CustomAttribTypedArgument> array = (IList<CustomAttribTypedArgument>)Value!;
      Type elementType = argumentType.GetElementType()!;

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

    return typed ? $"{Value}" : $"({argumentType.Name}){Value}";
  }

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(object? obj) => obj == (object)this;

  private static object? CanonicalizeValue(object? value)
  {
    if (value == null)
      return null;
    if (value is string str)
      return str;
    if (value is Enum e)
      return e;
    if (value is Type type)
      return TypeManager.RegisterType(type);
    //if (value.GetType().IsValueType)
    return value;
    //throw new NotSupportedException($"Value of type {value.GetType()} not supported as CustomAttribTypedArgument");
  }

  public static bool operator ==(CustomAttribTypedArgument left, CustomAttribTypedArgument right) => left.Equals(right);
  public static bool operator !=(CustomAttribTypedArgument left, CustomAttribTypedArgument right) => !left.Equals(right);
}
