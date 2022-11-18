using System.Reflection;

using DocumentFormat.OpenXml.Vml.Spreadsheet;

namespace ModelGen;

public class MyCustomAttributeData
{

  public Type AttributeType { get; set; }

  public virtual ConstructorInfo? Constructor { get; set; }
  public virtual IList<CustomAttributeTypedArgument> ConstructorArguments { get; set; } = new List<CustomAttributeTypedArgument>();
  public virtual IList<CustomAttributeNamedArgument> NamedArguments { get; set; } = new List<CustomAttributeNamedArgument>();

  public MyCustomAttributeData(Type attributeType)
  {
    AttributeType = attributeType;
  }

  public MyCustomAttributeData(Type attributeType, ConstructorInfo? constructor = null, 
    IEnumerable<CustomAttributeTypedArgument>? constructorArguments = null, IEnumerable<CustomAttributeNamedArgument>? namedArguments = null)
  {
    AttributeType = attributeType;
    Constructor = constructor;
    if (constructorArguments!=null)
      ConstructorArguments = new List<CustomAttributeTypedArgument>(constructorArguments);
    if (namedArguments!=null)
    NamedArguments = new List<CustomAttributeNamedArgument>(namedArguments);
  }

  public MyCustomAttributeData(CustomAttributeData other) : base()
  {
    this.AttributeType = other.AttributeType;
    this.ConstructorArguments = other.ConstructorArguments;
    this.ConstructorArguments = other.ConstructorArguments.ToList();
    this.NamedArguments = other.NamedArguments.ToList();
  }

  public static implicit operator MyCustomAttributeData(CustomAttributeData other) { return new MyCustomAttributeData(other); }
}