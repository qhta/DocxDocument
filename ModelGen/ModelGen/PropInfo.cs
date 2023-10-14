using System.ComponentModel;

using Namotion.Reflection;

namespace ModelGen;

public class PropInfo : MemberElement
{
  //[XmlIgnore]
  //public TypeInfo? DeclaringType => (TypeInfo?)Owner;
  [XmlIgnore]
  public PropertyInfo? PropertyInfo { get => ReflectionInfo as PropertyInfo; set => ReflectionInfo = value; }
  [XmlIgnore]
  public TypeInfo PropertyType { get; set; }
  [XmlIgnore]
  public TypeInfo? TargetPropertyType { get; set; }
  [XmlIgnore]
  public FullTypeName? TargetPropertyTypeName { get; set; }

  public string OriginalType
  {
    get => PropertyType.OriginalName;
    set { }
  }

  [XmlIgnore]
  public TypeInfo? TargetType { get; set; }

  [DefaultValue(false)]
  public bool IsReadonly { get; set; }

  [DefaultValue(false)]
  public bool IsStatic { get; set; }

  [DefaultValue(false)]
  public bool IsAbstract { get; set; }

  [DefaultValue(false)]
  public bool IsVirtual { get; set; }

  [DefaultValue(false)]
  public bool IsOverriden { get; set; }

  [DefaultValue(false)]
  public bool IsNew { get; set; }

  [DefaultValue(false)]
  public bool IsConstrained { get; set; }

  [DefaultValue(false)]
  public bool IsRequired { get; set; }

  [DefaultValue(false)]
  public bool IsEnum { get; set; }

  [DefaultValue(false)]
  public bool IsList { get; set; }

  public string? RealTypeName { get; set; }

  [XmlIgnore]
  public Constraints? Constraints { get; set; }

  /// <summary>
  /// String description assigned to this element or to target type.
  /// </summary>
  public override string? GetDescription()
  {
    var result = base.GetDescription();
    if (result==null)
      return TargetType?.GetDescription();
    return result;
  }

  /// <summary>
  /// Xml documentation assigned to this element or to target type.
  /// </summary>
  public override IEnumerable<XElement>? GetDocumentation()
  {
    var result = base.GetDocumentation();
    if (result==null)
      return TargetType?.GetDocumentation();
    return result;
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

    if (ModelConfig.Instance.ExcludedProperties.Contains(propertyInfo.Name))
      SetRejected(PPS.ScanSource);
    var xmlDocsElement = propertyInfo.GetXmlDocsElement();
    if (xmlDocsElement != null)
      CommentDocsParser.ParseDocumentation(this, xmlDocsElement);
    if (propertyInfo.CustomAttributes.Any())
    {
      foreach (var item in propertyInfo.CustomAttributes)
        Add(new CustomAttribInfo(item));
    }
  }

  public PropInfo(string name, TypeInfo typeInfo) : this(name, typeInfo.Type)
  {
    if (ModelConfig.Instance.ExcludedProperties.Contains(typeInfo.Name))
      SetRejected(PPS.ScanSource);
  }

  public override string ToString() => $"Prop({Name}: {PropertyType})"
                                       + ((Owner == null) ? "" : $" in {Owner.ToString}");
}