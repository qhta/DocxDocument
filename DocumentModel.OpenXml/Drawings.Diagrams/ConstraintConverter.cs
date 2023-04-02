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
  
  private static bool CmpType(DXDrawDgms.Constraint openXmlElement, DMDrawsDgms.ConstraintKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DMDrawsDgms.ConstraintKind>(openXmlElement?.Type?.Value, value, diffs, objName);
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
  
  private static bool CmpFor(DXDrawDgms.Constraint openXmlElement, DMDrawsDgms.ConstraintRelationshipKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DMDrawsDgms.ConstraintRelationshipKind>(openXmlElement?.For?.Value, value, diffs, objName);
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
    return StringValueConverter.GetValue(openXmlElement?.ForName);
  }
  
  private static bool CmpForName(DXDrawDgms.Constraint openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ForName, value, diffs, objName, "ForName");
  }
  
  private static void SetForName(DXDrawDgms.Constraint openXmlElement, String? value)
  {
    openXmlElement.ForName = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  private static DMDrawsDgms.ElementKind? GetPointType(DXDrawDgms.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDrawsDgms.ElementKind>(openXmlElement?.PointType?.Value);
  }
  
  private static bool CmpPointType(DXDrawDgms.Constraint openXmlElement, DMDrawsDgms.ElementKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDrawsDgms.ElementKind>(openXmlElement?.PointType?.Value, value, diffs, objName);
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
  
  private static bool CmpReferenceType(DXDrawDgms.Constraint openXmlElement, DMDrawsDgms.ConstraintKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DMDrawsDgms.ConstraintKind>(openXmlElement?.ReferenceType?.Value, value, diffs, objName);
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
  
  private static bool CmpReferenceFor(DXDrawDgms.Constraint openXmlElement, DMDrawsDgms.ConstraintRelationshipKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DMDrawsDgms.ConstraintRelationshipKind>(openXmlElement?.ReferenceFor?.Value, value, diffs, objName);
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
    return StringValueConverter.GetValue(openXmlElement?.ReferenceForName);
  }
  
  private static bool CmpReferenceForName(DXDrawDgms.Constraint openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ReferenceForName, value, diffs, objName, "ReferenceForName");
  }
  
  private static void SetReferenceForName(DXDrawDgms.Constraint openXmlElement, String? value)
  {
    openXmlElement.ReferenceForName = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Reference Point Type
  /// </summary>
  private static DMDrawsDgms.ElementKind? GetReferencePointType(DXDrawDgms.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDrawsDgms.ElementKind>(openXmlElement?.ReferencePointType?.Value);
  }
  
  private static bool CmpReferencePointType(DXDrawDgms.Constraint openXmlElement, DMDrawsDgms.ElementKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDrawsDgms.ElementKind>(openXmlElement?.ReferencePointType?.Value, value, diffs, objName);
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
  
  private static bool CmpOperator(DXDrawDgms.Constraint openXmlElement, DMDrawsDgms.BoolOperatorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.BoolOperatorValues, DMDrawsDgms.BoolOperatorKind>(openXmlElement?.Operator?.Value, value, diffs, objName);
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
    return openXmlElement?.Val?.Value;
  }
  
  private static bool CmpVal(DXDrawDgms.Constraint openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Val?.Value, value);
    return false;
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
    return openXmlElement?.Fact?.Value;
  }
  
  private static bool CmpFact(DXDrawDgms.Constraint openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Fact?.Value == value) return true;
    diffs?.Add(objName, "Fact", openXmlElement?.Fact?.Value, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (element != null)
      return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawDgms.Constraint openXmlElement, DMDrawsDgms.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>(), value, diffs, objName);
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
  
  public static DocumentModel.Drawings.Diagrams.Constraint? CreateModelElement(DXDrawDgms.Constraint? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Constraint();
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
  
  public static bool CompareModelElement(DXDrawDgms.Constraint? openXmlElement, DMDrawsDgms.Constraint? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpFor(openXmlElement, value.For, diffs, objName))
        ok = false;
      if (!CmpForName(openXmlElement, value.ForName, diffs, objName))
        ok = false;
      if (!CmpPointType(openXmlElement, value.PointType, diffs, objName))
        ok = false;
      if (!CmpReferenceType(openXmlElement, value.ReferenceType, diffs, objName))
        ok = false;
      if (!CmpReferenceFor(openXmlElement, value.ReferenceFor, diffs, objName))
        ok = false;
      if (!CmpReferenceForName(openXmlElement, value.ReferenceForName, diffs, objName))
        ok = false;
      if (!CmpReferencePointType(openXmlElement, value.ReferencePointType, diffs, objName))
        ok = false;
      if (!CmpOperator(openXmlElement, value.Operator, diffs, objName))
        ok = false;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      if (!CmpFact(openXmlElement, value.Fact, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Constraint value)
    where OpenXmlElementType: DXDrawDgms.Constraint, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.Constraint openXmlElement, DMDrawsDgms.Constraint value)
  {
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
  }
}
