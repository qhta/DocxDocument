namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Rule.
/// </summary>
public static class RuleConverter
{
  /// <summary>
  /// Constraint Type
  /// </summary>
  private static DMDD.ConstraintKind? GetType(DXDD.Rule openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DMDD.ConstraintKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXDD.Rule openXmlElement, DMDD.ConstraintKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DMDD.ConstraintKind>(openXmlElement?.Type?.Value, value, diffs, objName, propName);
  }
  
  private static void SetType(DXDD.Rule openXmlElement, DMDD.ConstraintKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DMDD.ConstraintKind>(value);
  }
  
  /// <summary>
  /// For
  /// </summary>
  private static DMDD.ConstraintRelationshipKind? GetFor(DXDD.Rule openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DMDD.ConstraintRelationshipKind>(openXmlElement?.For?.Value);
  }
  
  private static bool CmpFor(DXDD.Rule openXmlElement, DMDD.ConstraintRelationshipKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DMDD.ConstraintRelationshipKind>(openXmlElement?.For?.Value, value, diffs, objName, propName);
  }
  
  private static void SetFor(DXDD.Rule openXmlElement, DMDD.ConstraintRelationshipKind? value)
  {
    openXmlElement.For = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DMDD.ConstraintRelationshipKind>(value);
  }
  
  /// <summary>
  /// For Name
  /// </summary>
  private static String? GetForName(DXDD.Rule openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ForName);
  }
  
  private static bool CmpForName(DXDD.Rule openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ForName, value, diffs, objName, "ForName");
  }
  
  private static void SetForName(DXDD.Rule openXmlElement, String? value)
  {
    openXmlElement.ForName = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  private static DMDD.ElementKind? GetPointType(DXDD.Rule openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDD.ElementKind>(openXmlElement?.PointType?.Value);
  }
  
  private static bool CmpPointType(DXDD.Rule openXmlElement, DMDD.ElementKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDD.ElementKind>(openXmlElement?.PointType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetPointType(DXDD.Rule openXmlElement, DMDD.ElementKind? value)
  {
    openXmlElement.PointType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDD.ElementKind>(value);
  }
  
  /// <summary>
  /// Value
  /// </summary>
  private static Double? GetVal(DXDD.Rule openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static bool CmpVal(DXDD.Rule openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetVal(DXDD.Rule openXmlElement, Double? value)
  {
    openXmlElement.Val = value;
  }
  
  /// <summary>
  /// Factor
  /// </summary>
  private static Double? GetFact(DXDD.Rule openXmlElement)
  {
    return openXmlElement?.Fact?.Value;
  }
  
  private static bool CmpFact(DXDD.Rule openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Fact?.Value == value) return true;
    diffs?.Add(objName, "Fact", openXmlElement?.Fact?.Value, value);
    return false;
  }
  
  private static void SetFact(DXDD.Rule openXmlElement, Double? value)
  {
    openXmlElement.Fact = value;
  }
  
  /// <summary>
  /// Max Value
  /// </summary>
  private static Double? GetMax(DXDD.Rule openXmlElement)
  {
    return openXmlElement?.Max?.Value;
  }
  
  private static bool CmpMax(DXDD.Rule openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Max?.Value == value) return true;
    diffs?.Add(objName, "Max", openXmlElement?.Max?.Value, value);
    return false;
  }
  
  private static void SetMax(DXDD.Rule openXmlElement, Double? value)
  {
    openXmlElement.Max = value;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDD.ExtensionList? GetExtensionList(DXDD.Rule openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.ExtensionList>();
    if (element != null)
      return DMXDD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDD.Rule openXmlElement, DMDD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDD.Rule openXmlElement, DMDD.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Diagrams.Rule? CreateModelElement(DXDD.Rule? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Rule();
      value.Type = GetType(openXmlElement);
      value.For = GetFor(openXmlElement);
      value.ForName = GetForName(openXmlElement);
      value.PointType = GetPointType(openXmlElement);
      value.Val = GetVal(openXmlElement);
      value.Fact = GetFact(openXmlElement);
      value.Max = GetMax(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.Rule? openXmlElement, DMDD.Rule? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
      if (!CmpVal(openXmlElement, value.Val, diffs, objName, propName))
        ok = false;
      if (!CmpFact(openXmlElement, value.Fact, diffs, objName, propName))
        ok = false;
      if (!CmpMax(openXmlElement, value.Max, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.Rule value)
    where OpenXmlElementType: DXDD.Rule, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.Rule openXmlElement, DMDD.Rule value)
  {
    SetType(openXmlElement, value?.Type);
    SetFor(openXmlElement, value?.For);
    SetForName(openXmlElement, value?.ForName);
    SetPointType(openXmlElement, value?.PointType);
    SetVal(openXmlElement, value?.Val);
    SetFact(openXmlElement, value?.Fact);
    SetMax(openXmlElement, value?.Max);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
