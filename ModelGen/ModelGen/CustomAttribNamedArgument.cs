namespace ModelGen;

public class CustomAttribNamedArgument: IOwnedElement
{
  public static bool operator ==(CustomAttribNamedArgument left, CustomAttribNamedArgument right) => left.Equals(right);
  public static bool operator !=(CustomAttribNamedArgument left, CustomAttribNamedArgument right) => !left.Equals(right);

  public object? Owner { get; set; }
  public MemberInfo MemberInfo { get; }
  public CustomAttribTypedArgument TypedValue { get; }

  public CustomAttribNamedArgument(MemberInfo memberInfo, object? value)
  {
    Type type = memberInfo switch
    {
      FieldInfo field => field.FieldType,
      PropertyInfo property => property.PropertyType,
      _ => throw new ArgumentException("Invalid Member For Named Argument")
    };

    MemberInfo = memberInfo;
    TypedValue = new CustomAttribTypedArgument(type, value);
  }

  public CustomAttribNamedArgument(MemberInfo memberInfo, CustomAttributeTypedArgument typedArgument)
  {
    MemberInfo = memberInfo;
    TypedValue = new CustomAttribTypedArgument(typedArgument.Value) { Owner = this };
  }

  public CustomAttribNamedArgument(CustomAttributeNamedArgument namedArgument)
  {
    MemberInfo = namedArgument.MemberInfo ?? throw new ArgumentNullException(nameof(MemberInfo));
    TypedValue = new CustomAttribTypedArgument(namedArgument.TypedValue.Value);
  }

  public override string ToString()
  {
    if (MemberInfo is null)
      return base.ToString()!;

    return $"{MemberInfo.Name} = {TypedValue.ToString(ArgumentType != typeof(object))}";
  }

  public override int GetHashCode()
  {
    return base.GetHashCode();
  }

  public override bool Equals(object? obj)
  {
    return obj == (object)this;
  }

  internal Type ArgumentType =>
      MemberInfo is FieldInfo fi ?
          fi.FieldType :
          ((PropertyInfo)MemberInfo).PropertyType;

  public string MemberName => MemberInfo.Name;
  public bool IsField => MemberInfo is FieldInfo;
}

