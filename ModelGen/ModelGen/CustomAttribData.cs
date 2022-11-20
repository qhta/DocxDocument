using System.Reflection;

using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Vml.Spreadsheet;

namespace ModelGen;

public class CustomAttribData: IOwnedElement
{

  public object? Owner { get; set; }

  public Type AttributeType => AttributeTypeInfo.Type;
  public TypeInfo AttributeTypeInfo { get; }

  public Collection<CustomAttribTypedArgument> ConstructorArguments { get; }
  public Collection<CustomAttribNamedArgument> NamedArguments { get; set; }

  public CustomAttribData(Type attributeType)
  {
    ConstructorArguments = new Collection<CustomAttribTypedArgument>(this);
    NamedArguments = new Collection<CustomAttribNamedArgument>(this);
    AttributeTypeInfo = TypeManager.RegisterType(attributeType, this, Semantics.Attribute);
  }

  public CustomAttribData(Type attributeType, 
    IEnumerable<CustomAttributeTypedArgument>? constructorArguments = null, IEnumerable<CustomAttributeNamedArgument>? namedArguments = null): this(attributeType)
  {
    if (constructorArguments != null)
      foreach (var item in constructorArguments)
        ConstructorArguments.Add(new CustomAttribTypedArgument(item));
    if (namedArguments!=null)
      foreach (var item in namedArguments)
        NamedArguments.Add(new CustomAttribNamedArgument(item));
  }

  public CustomAttribData(CustomAttributeData data) : this(data.AttributeType, data.ConstructorArguments, data.NamedArguments)
  {
  }

  public override string ToString() => $"CustomAttribData({AttributeTypeInfo})"
  +((Owner==null) ? "" : $" in {Owner.ToString}");
}