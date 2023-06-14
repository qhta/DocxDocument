using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Validation.Schema;

using Namotion.Reflection;

namespace ModelGen;

public class PropInfo : ModelElement
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
  public bool IsNew { get; set; }
  public bool IsConstrained { get; set; }
  public bool IsRequired { get; set; }
  public bool IsEnum { get; set; }
  public bool IsList { get; set; }
  public string RealTypeName { get; set; }
  public Constraints? Constraints { get; set; }

  ///// <summary>
  ///// Xml documentation assigned to this element.
  ///// </summary>
  //public override XElement? Documentation
  //{
  //  get => base.Documentation ?? DeclaringType?.Documentation;
  //  set => base.Documentation = value;
  //}

  /// <summary>
  /// Xml documentation assigned to this element.
  /// </summary>
  public override ElementMetadata? Metadata 
  {
    get => base.Metadata ?? DeclaringType?.Metadata;
    set => base.Metadata = value;
  }

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
    var xmlDocsElement = propertyInfo.GetXmlDocsElement();
    if (xmlDocsElement != null)
      Metadata = DocumentationReader.GetElementMetadata(xmlDocsElement);
    foreach (var item in propertyInfo.CustomAttributes)
      CustomAttributes.Add(new CustomAttribInfo(item));
  }

  public PropInfo(string name, TypeInfo typeInfo) : this(name, typeInfo.Type)
  {
    if (ModelData.ExcludedProperties.Contains(typeInfo.Name))
      IsAccepted = false;
  }

  public override string ToString() => $"Prop({Name}: {PropertyType})"
                                       + ((Owner == null) ? "" : $" in {Owner.ToString}");
}