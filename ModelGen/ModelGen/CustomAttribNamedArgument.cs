namespace ModelGen;

public class CustomAttribNamedArgument: CustomAttribTypedArgument
{
  public string Name { [DebuggerStepThrough] get; set; }

  public CustomAttribNamedArgument(string name, Type type, object? value): base(type, value)
  {
    Name = name;
  }

  //private static Type GetType(MemberInfo memberInfo)
  //{
  //  Type type = memberInfo switch
  //  {
  //    FieldInfo field => field.FieldType,
  //    PropertyInfo property => property.PropertyType,
  //    _ => throw new ArgumentException("Invalid Member For Named Argument")
  //  };
  //  return type;
  //}
  public CustomAttribNamedArgument(CustomAttributeNamedArgument namedArgument): base(namedArgument.TypedValue.ArgumentType, namedArgument.TypedValue.Value)
  {
    Name = namedArgument.MemberInfo.Name ?? throw new ArgumentNullException(nameof(MemberElement));
  }

  public override string ToString()
  {
    if (Name is null)
      return base.ToString()!;

    return $"{Name} = {base.ToString(Type.Type != typeof(object))}";
  }

  public override int GetHashCode()
  {
    return base.GetHashCode();
  }

  public override bool Equals(object? obj)
  {
    return obj == (object)this;
  }

  public static bool operator ==(CustomAttribNamedArgument left, CustomAttribNamedArgument right) => left.Equals(right);
  public static bool operator !=(CustomAttribNamedArgument left, CustomAttribNamedArgument right) => !left.Equals(right);

}

