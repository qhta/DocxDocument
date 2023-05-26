namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Constraint.
/// </summary>
public static class ConstraintConverter
{
  /// <summary>
  /// Constraint Type
  /// </summary>
  private static DMDD.ConstraintKind? GetType(DXDD.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DMDD.ConstraintKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXDD.Constraint openXmlElement, DMDD.ConstraintKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DMDD.ConstraintKind>(openXmlElement?.Type?.Value, value, diffs, objName, propName);
  }
  
  private static void SetType(DXDD.Constraint openXmlElement, DMDD.ConstraintKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DMDD.ConstraintKind>(value);
  }
  
  /// <summary>
  /// For
  /// </summary>
  private static DMDD.ConstraintRelationshipKind? GetFor(DXDD.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DMDD.ConstraintRelationshipKind>(openXmlElement?.For?.Value);
  }
  
  private static bool CmpFor(DXDD.Constraint openXmlElement, DMDD.ConstraintRelationshipKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DMDD.ConstraintRelationshipKind>(openXmlElement?.For?.Value, value, diffs, objName, propName);
  }
  
  private static void SetFor(DXDD.Constraint openXmlElement, DMDD.ConstraintRelationshipKind? value)
  {
    openXmlElement.For = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DMDD.ConstraintRelationshipKind>(value);
  }
  
  /// <summary>
  /// For Name
  /// </summary>
  private static String? GetForName(DXDD.Constraint openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ForName);
  }
  
  private static bool CmpForName(DXDD.Constraint openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ForName, value, diffs, objName, "ForName");
  }
  
  private static void SetForName(DXDD.Constraint openXmlElement, String? value)
  {
    openXmlElement.ForName = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  private static DMDD.ElementKind? GetPointType(DXDD.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDD.ElementKind>(openXmlElement?.PointType?.Value);
  }
  
  private static bool CmpPointType(DXDD.Constraint openXmlElement, DMDD.ElementKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDD.ElementKind>(openXmlElement?.PointType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetPointType(DXDD.Constraint openXmlElement, DMDD.ElementKind? value)
  {
    openXmlElement.PointType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDD.ElementKind>(value);
  }
  
  /// <summary>
  /// Reference Type
  /// </summary>
  private static DMDD.ConstraintKind? GetReferenceType(DXDD.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DMDD.ConstraintKind>(openXmlElement?.ReferenceType?.Value);
  }
  
  private static bool CmpReferenceType(DXDD.Constraint openXmlElement, DMDD.ConstraintKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DMDD.ConstraintKind>(openXmlElement?.ReferenceType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetReferenceType(DXDD.Constraint openXmlElement, DMDD.ConstraintKind? value)
  {
    openXmlElement.ReferenceType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DMDD.ConstraintKind>(value);
  }
  
  /// <summary>
  /// Reference For
  /// </summary>
  private static DMDD.ConstraintRelationshipKind? GetReferenceFor(DXDD.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DMDD.ConstraintRelationshipKind>(openXmlElement?.ReferenceFor?.Value);
  }
  
  private static bool CmpReferenceFor(DXDD.Constraint openXmlElement, DMDD.ConstraintRelationshipKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DMDD.ConstraintRelationshipKind>(openXmlElement?.ReferenceFor?.Value, value, diffs, objName, propName);
  }
  
  private static void SetReferenceFor(DXDD.Constraint openXmlElement, DMDD.ConstraintRelationshipKind? value)
  {
    openXmlElement.ReferenceFor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DMDD.ConstraintRelationshipKind>(value);
  }
  
  /// <summary>
  /// Reference For Name
  /// </summary>
  private static String? GetReferenceForName(DXDD.Constraint openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ReferenceForName);
  }
  
  private static bool CmpReferenceForName(DXDD.Constraint openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ReferenceForName, value, diffs, objName, "ReferenceForName");
  }
  
  private static void SetReferenceForName(DXDD.Constraint openXmlElement, String? value)
  {
    openXmlElement.ReferenceForName = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Reference Point Type
  /// </summary>
  private static DMDD.ElementKind? GetReferencePointType(DXDD.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDD.ElementKind>(openXmlElement?.ReferencePointType?.Value);
  }
  
  private static bool CmpReferencePointType(DXDD.Constraint openXmlElement, DMDD.ElementKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDD.ElementKind>(openXmlElement?.ReferencePointType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetReferencePointType(DXDD.Constraint openXmlElement, DMDD.ElementKind? value)
  {
    openXmlElement.ReferencePointType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDD.ElementKind>(value);
  }
  
  /// <summary>
  /// Operator
  /// </summary>
  private static DMDD.BoolOperatorKind? GetOperator(DXDD.Constraint openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.BoolOperatorValues, DMDD.BoolOperatorKind>(openXmlElement?.Operator?.Value);
  }
  
  private static bool CmpOperator(DXDD.Constraint openXmlElement, DMDD.BoolOperatorKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.BoolOperatorValues, DMDD.BoolOperatorKind>(openXmlElement?.Operator?.Value, value, diffs, objName, propName);
  }
  
  private static void SetOperator(DXDD.Constraint openXmlElement, DMDD.BoolOperatorKind? value)
  {
    openXmlElement.Operator = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.BoolOperatorValues, DMDD.BoolOperatorKind>(value);
  }
  
  /// <summary>
  /// Value
  /// </summary>
  private static Double? GetVal(DXDD.Constraint openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static bool CmpVal(DXDD.Constraint openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetVal(DXDD.Constraint openXmlElement, Double? value)
  {
    openXmlElement.Val = value;
  }
  
  /// <summary>
  /// Factor
  /// </summary>
  private static Double? GetFact(DXDD.Constraint openXmlElement)
  {
    return openXmlElement?.Fact?.Value;
  }
  
  private static bool CmpFact(DXDD.Constraint openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Fact?.Value == value) return true;
    diffs?.Add(objName, "Fact", openXmlElement?.Fact?.Value, value);
    return false;
  }
  
  private static void SetFact(DXDD.Constraint openXmlElement, Double? value)
  {
    openXmlElement.Fact = value;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDD.ExtensionList? GetExtensionList(DXDD.Constraint openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.ExtensionList>();
    if (element != null)
      return DMXDD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDD.Constraint openXmlElement, DMDD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDD.Constraint openXmlElement, DMDD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ExtensionListConverter.CreateOpenXmlElement<DXDD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Constraint? CreateModelElement(DXDD.Constraint? openXmlElement)
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
  
  public static bool CompareModelElement(DXDD.Constraint? openXmlElement, DMDD.Constraint? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName, propName))
        ok = false;
      if (!CmpFor(openXmlElement, value.For, diffs, objName, propName))
        ok = false;
      if (!CmpForName(openXmlElement, value.ForName, diffs, objName, propName))
        ok = false;
      if (!CmpPointType(openXmlElement, value.PointType, diffs, objName, propName))
        ok = false;
      if (!CmpReferenceType(openXmlElement, value.ReferenceType, diffs, objName, propName))
        ok = false;
      if (!CmpReferenceFor(openXmlElement, value.ReferenceFor, diffs, objName, propName))
        ok = false;
      if (!CmpReferenceForName(openXmlElement, value.ReferenceForName, diffs, objName, propName))
        ok = false;
      if (!CmpReferencePointType(openXmlElement, value.ReferencePointType, diffs, objName, propName))
        ok = false;
      if (!CmpOperator(openXmlElement, value.Operator, diffs, objName, propName))
        ok = false;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName, propName))
        ok = false;
      if (!CmpFact(openXmlElement, value.Fact, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.Constraint value)
    where OpenXmlElementType: DXDD.Constraint, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.Constraint openXmlElement, DMDD.Constraint value)
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
