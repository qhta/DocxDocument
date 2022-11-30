using System.Reflection;

using DocumentFormat.OpenXml.Bibliography;

using Namotion.Reflection;

namespace ModelGen;

public class PropInfo: ModelElement
{
  //public Type PropertyType => PropertyTypeInfo.Type;

  public TypeInfo PropertyType { get; set; }


  public PropInfo(string name, Type type) : base(name)
  {
    PropertyType = TypeManager.RegisterType(type, this, Semantics.Value);
  }

  public PropInfo(PropertyInfo propertyInfo) : this(propertyInfo.Name, propertyInfo.PropertyType)
  {
    if (ModelData.ExcludedProperties.Contains(propertyInfo.Name))
      IsAccepted = false;
    Documentation = propertyInfo.GetXmlDocsElement();
    if (Documentation != null)
      Summary = DocumentationReader.GetSummaryFirstPara(Documentation);
    foreach (var item in propertyInfo.CustomAttributes)
      CustomAttributes.Add(new CustomAttribData(item));
  }

  public PropInfo(TypeInfo typeInfo) : this(typeInfo.Name, typeInfo.Type)
  {
    if (ModelData.ExcludedProperties.Contains(typeInfo.Name))
      IsAccepted = false;
  }

  public override string ToString() => $"Prop({Name}: {PropertyType})"
                                       +((Owner==null) ? "" : $" in {Owner.ToString}");
}