namespace ModelGen;

/// <summary>
/// Represents CustomAttribute assigned to element.
/// </summary>
public class CustomAttrib: ModelElement
{
  /// <summary>
  /// Type of the CustomAttribute.
  /// </summary>
  [XmlIgnore]
  public TypeInfo AttributeTypeInfo { get; }

  /// <summary>
  /// Represents arguments passed in the constructor of the CustomAttribute.
  /// </summary>
  [XmlIgnore]
  public OwnedCollection<CustomAttribTypedArgument> ConstructorArguments { get; }

  /// <summary>
  /// Represents name arguments set to the CustomAttribute.
  /// </summary>
  [XmlIgnore]
  public OwnedCollection<CustomAttribNamedArgument> NamedArguments { get; set; }

  public CustomAttrib(Attribute attribute) : base(attribute.GetType().Name)
  {
    AttributeTypeInfo = TypeManager.RegisterType(attribute.GetType());
    ConstructorArguments = new OwnedCollection<CustomAttribTypedArgument>(this);
    NamedArguments = new OwnedCollection<CustomAttribNamedArgument>(this);
    foreach (var prop in attribute.GetType().GetProperties())
      NamedArguments.Add(new CustomAttribNamedArgument(prop.Name, prop.PropertyType, prop.GetValue(attribute)));
  }

  public CustomAttrib(Type attributeType): base(attributeType.Name)
  {
    ConstructorArguments = new OwnedCollection<CustomAttribTypedArgument>(this);
    NamedArguments = new OwnedCollection<CustomAttribNamedArgument>(this);
    AttributeTypeInfo = TypeManager.RegisterType(attributeType);
  }

  public CustomAttrib(Type attributeType, 
    IEnumerable<CustomAttributeTypedArgument>? constructorArguments = null, IEnumerable<CustomAttributeNamedArgument>? namedArguments = null): this(attributeType)
  {
    if (constructorArguments != null)
      foreach (var item in constructorArguments)
        ConstructorArguments.Add(new CustomAttribTypedArgument(item));
    if (namedArguments!=null)
      foreach (var item in namedArguments)
        NamedArguments.Add(new CustomAttribNamedArgument(item));
  }

  public CustomAttrib(CustomAttributeData data) : this(data.AttributeType, data.ConstructorArguments, data.NamedArguments)
  {
  }

  public override string ToString() => $"CustomAttribData({AttributeTypeInfo})"
  +((Owner==null) ? "" : $" in {Owner.ToString}");
}