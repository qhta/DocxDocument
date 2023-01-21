namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Constraint.
/// </summary>
public static class ConstraintConverter
{
  /// <summary>
  /// Constraint Type
  /// </summary>
  private static DMDrawsDgms.ConstraintKind? GetType(DXDrawDgms.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DMDrawsDgms.ConstraintKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DXDrawDgms.Constraint openXmlElement, DMDrawsDgms.ConstraintKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DMDrawsDgms.ConstraintKind>(value);
  }
  
  /// <summary>
  /// For
  /// </summary>
  private static DMDrawsDgms.ConstraintRelationshipKind? GetFor(DXDrawDgms.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DMDrawsDgms.ConstraintRelationshipKind>(openXmlElement?.For?.Value);
  }
  
  private static void SetFor(DXDrawDgms.Constraint openXmlElement, DMDrawsDgms.ConstraintRelationshipKind? value)
  {
    openXmlElement.For = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DMDrawsDgms.ConstraintRelationshipKind>(value);
  }
  
  /// <summary>
  /// For Name
  /// </summary>
  private static String? GetForName(DXDrawDgms.Constraint openXmlElement)
  {
    return openXmlElement?.ForName?.Value;
  }
  
  private static void SetForName(DXDrawDgms.Constraint openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ForName = new StringValue { Value = value };
    else
      openXmlElement.ForName = null;
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  private static DMDrawsDgms.ElementKind? GetPointType(DXDrawDgms.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDrawsDgms.ElementKind>(openXmlElement?.PointType?.Value);
  }
  
  private static void SetPointType(DXDrawDgms.Constraint openXmlElement, DMDrawsDgms.ElementKind? value)
  {
    openXmlElement.PointType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDrawsDgms.ElementKind>(value);
  }
  
  /// <summary>
  /// Reference Type
  /// </summary>
  private static DMDrawsDgms.ConstraintKind? GetReferenceType(DXDrawDgms.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DMDrawsDgms.ConstraintKind>(openXmlElement?.ReferenceType?.Value);
  }
  
  private static void SetReferenceType(DXDrawDgms.Constraint openXmlElement, DMDrawsDgms.ConstraintKind? value)
  {
    openXmlElement.ReferenceType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DMDrawsDgms.ConstraintKind>(value);
  }
  
  /// <summary>
  /// Reference For
  /// </summary>
  private static DMDrawsDgms.ConstraintRelationshipKind? GetReferenceFor(DXDrawDgms.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DMDrawsDgms.ConstraintRelationshipKind>(openXmlElement?.ReferenceFor?.Value);
  }
  
  private static void SetReferenceFor(DXDrawDgms.Constraint openXmlElement, DMDrawsDgms.ConstraintRelationshipKind? value)
  {
    openXmlElement.ReferenceFor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DMDrawsDgms.ConstraintRelationshipKind>(value);
  }
  
  /// <summary>
  /// Reference For Name
  /// </summary>
  private static String? GetReferenceForName(DXDrawDgms.Constraint openXmlElement)
  {
    return openXmlElement?.ReferenceForName?.Value;
  }
  
  private static void SetReferenceForName(DXDrawDgms.Constraint openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ReferenceForName = new StringValue { Value = value };
    else
      openXmlElement.ReferenceForName = null;
  }
  
  /// <summary>
  /// Reference Point Type
  /// </summary>
  private static DMDrawsDgms.ElementKind? GetReferencePointType(DXDrawDgms.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDrawsDgms.ElementKind>(openXmlElement?.ReferencePointType?.Value);
  }
  
  private static void SetReferencePointType(DXDrawDgms.Constraint openXmlElement, DMDrawsDgms.ElementKind? value)
  {
    openXmlElement.ReferencePointType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDrawsDgms.ElementKind>(value);
  }
  
  /// <summary>
  /// Operator
  /// </summary>
  private static DMDrawsDgms.BoolOperatorKind? GetOperator(DXDrawDgms.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.BoolOperatorValues, DMDrawsDgms.BoolOperatorKind>(openXmlElement?.Operator?.Value);
  }
  
  private static void SetOperator(DXDrawDgms.Constraint openXmlElement, DMDrawsDgms.BoolOperatorKind? value)
  {
    openXmlElement.Operator = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.BoolOperatorValues, DMDrawsDgms.BoolOperatorKind>(value);
  }
  
  /// <summary>
  /// Value
  /// </summary>
  private static Double? GetVal(DXDrawDgms.Constraint openXmlElement)
  {
    return openXmlElement.Val?.Value;
  }
  
  private static void SetVal(DXDrawDgms.Constraint openXmlElement, Double? value)
  {
    openXmlElement.Val = value;
  }
  
  /// <summary>
  /// Factor
  /// </summary>
  private static Double? GetFact(DXDrawDgms.Constraint openXmlElement)
  {
    return openXmlElement.Fact?.Value;
  }
  
  private static void SetFact(DXDrawDgms.Constraint openXmlElement, Double? value)
  {
    openXmlElement.Fact = value;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDrawsDgms.ExtensionList? GetExtensionList(DXDrawDgms.Constraint openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDrawDgms.Constraint openXmlElement, DMDrawsDgms.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.ExtensionListConverter.CreateOpenXmlElement<DXDrawDgms.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsDgms.Constraint? CreateModelElement(DXDrawDgms.Constraint? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.Constraint();
      value.Type = GetType(openXmlElement);
      value.For = GetFor(openXmlElement);
      value.ForName = GetForName(openXmlElement);
      value.PointType = GetPointType(openXmlElement);
      value.ReferenceType = GetReferenceType(openXmlElement);
      value.ReferenceFor = GetReferenceFor(openXmlElement);
      value.ReferenceForName = GetReferenceForName(openXmlElement);
      value.ReferencePointType = GetReferencePointType(openXmlElement);
      value.Operator = GetOperator(openXmlElement);
      value.Val = GetVal(openXmlElement);
      value.Fact = GetFact(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Constraint? value)
    where OpenXmlElementType: DXDrawDgms.Constraint, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetFor(openXmlElement, value?.For);
      SetForName(openXmlElement, value?.ForName);
      SetPointType(openXmlElement, value?.PointType);
      SetReferenceType(openXmlElement, value?.ReferenceType);
      SetReferenceFor(openXmlElement, value?.ReferenceFor);
      SetReferenceForName(openXmlElement, value?.ReferenceForName);
      SetReferencePointType(openXmlElement, value?.ReferencePointType);
      SetOperator(openXmlElement, value?.Operator);
      SetVal(openXmlElement, value?.Val);
      SetFact(openXmlElement, value?.Fact);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
