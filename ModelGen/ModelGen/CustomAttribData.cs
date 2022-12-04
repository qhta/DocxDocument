using System.Reflection;

using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Vml.Spreadsheet;

namespace ModelGen;

public class CustomAttribData: ModelElement
{

  public TypeInfo AttributeType { get; }

  public OwnedCollection<CustomAttribTypedArgument> ConstructorArguments { get; }
  public OwnedCollection<CustomAttribNamedArgument> NamedArguments { get; set; }

  public CustomAttribData(Type attributeType): base(attributeType.Name)
  {
    ConstructorArguments = new OwnedCollection<CustomAttribTypedArgument>(this);
    NamedArguments = new OwnedCollection<CustomAttribNamedArgument>(this);
    AttributeType = TypeManager.RegisterType(attributeType);
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

  public override string ToString() => $"CustomAttribData({AttributeType})"
  +((Owner==null) ? "" : $" in {Owner.ToString}");
}