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
  public TypeInfo PropertyType { [DebuggerStepThrough] get; set; }
  //[XmlIgnore]
  //public TypeInfo? TargetPropertyType { [DebuggerStepThrough] get; set; }
  [XmlIgnore]
  public FullTypeName? TargetPropertyTypeName { [DebuggerStepThrough] get; set; }

  public string OriginalType
  {
    get => PropertyType.OriginalName;
    set { }
  }

  [XmlIgnore]
  public TypeInfo? TargetType { [DebuggerStepThrough] get; set; }

  [DefaultValue(false)]
  public bool IsReadonly { [DebuggerStepThrough] get; set; }

  [DefaultValue(false)]
  public bool IsStatic { [DebuggerStepThrough] get; set; }

  [DefaultValue(false)]
  public bool IsAbstract { [DebuggerStepThrough] get; set; }

  [DefaultValue(false)]
  public bool IsVirtual { [DebuggerStepThrough] get; set; }

  [DefaultValue(false)]
  public bool IsOverriden { [DebuggerStepThrough] get; set; }

  [DefaultValue(false)]
  public bool IsNew { [DebuggerStepThrough] get; set; }

  [DefaultValue(false)]
  public bool IsConstrained { [DebuggerStepThrough] get; set; }

  [DefaultValue(false)]
  public bool IsRequired { [DebuggerStepThrough] get; set; }

  [DefaultValue(false)]
  public bool IsEnum { [DebuggerStepThrough] get; set; }

  [DefaultValue(false)]
  public bool IsList { [DebuggerStepThrough] get; set; }

  public string? RealTypeName { [DebuggerStepThrough] get; set; }

  [XmlIgnore]
  public Constraints? Constraints { [DebuggerStepThrough] get; set; }

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
    if (ModelConfig.Instance == null)
      throw new System.InvalidOperationException(CommonStrings.Model_configuration_not_defined);
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

    if (ModelConfig.Instance.RejectedProperties.Contains(propertyInfo.Name))
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
    if (ModelConfig.Instance == null)
      throw new System.InvalidOperationException(CommonStrings.Model_configuration_not_defined);
    if (ModelConfig.Instance.RejectedProperties.Contains(typeInfo.Name))
      SetRejected(PPS.ScanSource);
  }

  public override string ToString() => $"Prop({Name}: {PropertyType})"
                                       + ((Owner == null) ? "" : $" in {Owner.ToString}");
}