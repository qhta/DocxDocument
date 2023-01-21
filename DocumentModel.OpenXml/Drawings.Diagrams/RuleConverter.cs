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
  
  private static void SetPointType(DXDrawDgms.Rule openXmlElement, DMDrawsDgms.ElementKind? value)
  {
    openXmlElement.PointType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues, DMDrawsDgms.ElementKind>(value);
  }
  
  /// <summary>
  /// Value
  /// </summary>
  private static Double? GetVal(DXDrawDgms.Rule openXmlElement)
  {
    return openXmlElement.Val?.Value;
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
    return openXmlElement.Fact?.Value;
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
    return openXmlElement.Max?.Value;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
