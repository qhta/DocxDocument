namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Rule.
/// </summary>
public static class RuleConverter
{
  /// <summary>
  /// Constraint Type
  /// </summary>
  private static DMDrawsDgms.ConstraintKind? GetType(DXDrawDgms.Rule openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DMDrawsDgms.ConstraintKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXDrawDgms.Rule openXmlElement, DMDrawsDgms.ConstraintKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DMDrawsDgms.ConstraintKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetType(DXDrawDgms.Rule openXmlElement, DMDrawsDgms.ConstraintKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues, DMDrawsDgms.ConstraintKind>(value);
  }
  
  /// <summary>
  /// For
  /// </summary>
  private static DMDrawsDgms.ConstraintRelationshipKind? GetFor(DXDrawDgms.Rule openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DMDrawsDgms.ConstraintRelationshipKind>(openXmlElement?.For?.Value);
  }
  
  private static bool CmpFor(DXDrawDgms.Rule openXmlElement, DMDrawsDgms.ConstraintRelationshipKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DMDrawsDgms.ConstraintRelationshipKind>(openXmlElement?.For?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFor(DXDrawDgms.Rule openXmlElement, DMDrawsDgms.ConstraintRelationshipKind? value)
  {
    openXmlElement.For = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues, DMDrawsDgms.ConstraintRelationshipKind>(value);
  }
  
  /// <summary>
  /// For Name
  /// </summary>
  private static String? GetForName(DXDrawDgms.Rule openXmlElement)
  {
    return openXmlElement?.ForName?.Value;
  }
  
  private static bool CmpForName(DXDrawDgms.Rule openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ForName?.Value == value;
  }
  
  private static void SetForName(DXDrawDgms.Rule openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ForName = new StringValue { Value = value };
    else
      openXmlElement.ForName = null;
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  private static DMDrawsDgms.ElementKind? GetPointType(DXDrawDgms.Rule openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDrawsDgms.ElementKind>(openXmlElement?.PointType?.Value);
  }
  
  private static bool CmpPointType(DXDrawDgms.Rule openXmlElement, DMDrawsDgms.ElementKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDrawsDgms.ElementKind>(openXmlElement?.PointType?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPointType(DXDrawDgms.Rule openXmlElement, DMDrawsDgms.ElementKind? value)
  {
    openXmlElement.PointType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDrawsDgms.ElementKind>(value);
  }
  
  /// <summary>
  /// Value
  /// </summary>
  private static Double? GetVal(DXDrawDgms.Rule openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static bool CmpVal(DXDrawDgms.Rule openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "Val", openXmlElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetVal(DXDrawDgms.Rule openXmlElement, Double? value)
  {
    openXmlElement.Val = value;
  }
  
  /// <summary>
  /// Factor
  /// </summary>
  private static Double? GetFact(DXDrawDgms.Rule openXmlElement)
  {
    return openXmlElement?.Fact?.Value;
  }
  
  private static bool CmpFact(DXDrawDgms.Rule openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Fact?.Value == value) return true;
    diffs?.Add(objName, "Fact", openXmlElement?.Fact?.Value, value);
    return false;
  }
  
  private static void SetFact(DXDrawDgms.Rule openXmlElement, Double? value)
  {
    openXmlElement.Fact = value;
  }
  
  /// <summary>
  /// Max Value
  /// </summary>
  private static Double? GetMax(DXDrawDgms.Rule openXmlElement)
  {
    return openXmlElement?.Max?.Value;
  }
  
  private static bool CmpMax(DXDrawDgms.Rule openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Max?.Value == value) return true;
    diffs?.Add(objName, "Max", openXmlElement?.Max?.Value, value);
    return false;
  }
  
  private static void SetMax(DXDrawDgms.Rule openXmlElement, Double? value)
  {
    openXmlElement.Max = value;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDrawsDgms.ExtensionList? GetExtensionList(DXDrawDgms.Rule openXmlElement)
  {
    return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDrawDgms.Rule openXmlElement, DMDrawsDgms.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawDgms.Rule openXmlElement, DMDrawsDgms.ExtensionList? value)
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
  
  public static DMDrawsDgms.Rule? CreateModelElement(DXDrawDgms.Rule? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.Rule();
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
  
  public static bool CompareModelElement(DXDrawDgms.Rule? openXmlElement, DMDrawsDgms.Rule? value, DiffList? diffs, string? objName)
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
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      if (!CmpFact(openXmlElement, value.Fact, diffs, objName))
        ok = false;
      if (!CmpMax(openXmlElement, value.Max, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Rule? value)
    where OpenXmlElementType: DXDrawDgms.Rule, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetFor(openXmlElement, value?.For);
      SetForName(openXmlElement, value?.ForName);
      SetPointType(openXmlElement, value?.PointType);
      SetVal(openXmlElement, value?.Val);
      SetFact(openXmlElement, value?.Fact);
      SetMax(openXmlElement, value?.Max);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
