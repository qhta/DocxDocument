using System.Reflection;

using DocumentFormat.OpenXml.Bibliography;

using Namotion.Reflection;

namespace ModelGen;

public class PropInfo: ModelElement
{
  public Type PropertyType => PropertyTypeInfo.Type;

  public TypeInfo PropertyTypeInfo { get; set; }


  public PropInfo(string name, Type type) : base(name)
  {
    PropertyTypeInfo = TypeManager.RegisterType(type, this, Semantics.Value);
  }

  public PropInfo(PropertyInfo propertyInfo) : this(propertyInfo.Name, propertyInfo.PropertyType)
  {
    var documentation = propertyInfo.GetXmlDocsElement();
    if (documentation != null)
      Summary = DocumentationReader.GetSummaryFirstPara(documentation);
    foreach (var item in propertyInfo.CustomAttributes)
      CustomAttributes.Add(new CustomAttribData(item));
  }

  public override string ToString() => $"Prop({Name}: {PropertyTypeInfo})"
                                       +((Owner==null) ? "" : $" in {Owner.ToString}");
}