using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Validation.Schema;
using Namotion.Reflection;

namespace ModelGen;

public class PropInfo: ModelElement
{
  public TypeInfo? DeclaringType => (TypeInfo?)Owner;
  public PropertyInfo? PropertyInfo { get; set; }
  public TypeInfo PropertyType { get; set; }
  public TypeInfo? TargetType { get; set; }

  public bool IsReadonly { get; set; }
  public bool IsStatic { get; set; }
  public bool IsAbstract { get; set; }
  public bool IsVirtual { get; set; }
  public bool IsOverriden { get; set; }
  public bool IsNew { get; set;}

  public bool IsConstrained { get; set; }

  public Validators? Validators { get; set; }

  public PropInfo(string name, Type type) : base(name)
  {
    PropertyType = TypeManager.RegisterType(type);
  }

  public PropInfo(PropertyInfo propertyInfo) : this(propertyInfo.Name, propertyInfo.PropertyType)
  {
    PropertyInfo = propertyInfo;
    //var getMethod = propertyInfo.GetMethod;
    //if (getMethod != null)
    //{
    //  if (getMethod.IsVirtual)
    //    IsVirtual = true;
    //  var baseGetMethod = getMethod.GetBaseDefinition();
    //  if (baseGetMethod == null)
    //    IsNew = true;
    //  else
    //  if (baseGetMethod != getMethod)
    //    IsOverriden = true;
    //}
    //else
    //  IsAbstract = true;

    if (propertyInfo.SetMethod == null || !propertyInfo.SetMethod.IsPublic)
      IsReadonly = true;

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