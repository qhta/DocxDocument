namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Equation Array Properties.
/// </summary>
public static class EquationArrayPropertiesConverter
{
  /// <summary>
  /// Equation Array Base Justification.
  /// </summary>
  private static DMMath.VerticalAlignmentKind? GetBaseJustification(DXMath.EquationArrayProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DMMath.VerticalAlignmentKind>(openXmlElement.GetFirstChild<DXMath.BaseJustification>()?.Val?.Value);
  }
  
  private static bool CmpBaseJustification(DXMath.EquationArrayProperties openXmlElement, DMMath.VerticalAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DMMath.VerticalAlignmentKind>(openXmlElement.GetFirstChild<DXMath.BaseJustification>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBaseJustification(DXMath.EquationArrayProperties openXmlElement, DMMath.VerticalAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.BaseJustification>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.BaseJustification, DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DMMath.VerticalAlignmentKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Maximum Distribution.
  /// </summary>
  private static DMMath.BooleanKind? GetMaxDistribution(DXMath.EquationArrayProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.MaxDistribution>()?.Val?.Value);
  }
  
  private static bool CmpMaxDistribution(DXMath.EquationArrayProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.MaxDistribution>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMaxDistribution(DXMath.EquationArrayProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.MaxDistribution>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.MaxDistribution, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Object Distribution.
  /// </summary>
  private static DMMath.BooleanKind? GetObjectDistribution(DXMath.EquationArrayProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.ObjectDistribution>()?.Val?.Value);
  }
  
  private static bool CmpObjectDistribution(DXMath.EquationArrayProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.ObjectDistribution>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetObjectDistribution(DXMath.EquationArrayProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ObjectDistribution>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.ObjectDistribution, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Row Spacing Rule.
  /// </summary>
  private static Int64? GetRowSpacingRule(DXMath.EquationArrayProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXMath.RowSpacingRule>()?.Val?.Value;
  }
  
  private static bool CmpRowSpacingRule(DXMath.EquationArrayProperties openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.RowSpacingRule>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXMath.RowSpacingRule", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetRowSpacingRule(DXMath.EquationArrayProperties openXmlElement, Int64? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.RowSpacingRule>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.RowSpacingRule{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Row Spacing (Equation Array).
  /// </summary>
  private static UInt16? GetRowSpacing(DXMath.EquationArrayProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXMath.RowSpacing>()?.Val?.Value;
  }
  
  private static bool CmpRowSpacing(DXMath.EquationArrayProperties openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.RowSpacing>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXMath.RowSpacing", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetRowSpacing(DXMath.EquationArrayProperties openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.RowSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.RowSpacing{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.EquationArrayProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (element != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXMath.EquationArrayProperties openXmlElement, DMMath.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.ControlProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetControlProperties(DXMath.EquationArrayProperties openXmlElement, DMMath.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.ControlPropertiesConverter.CreateOpenXmlElement<DXMath.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.EquationArrayProperties? CreateModelElement(DXMath.EquationArrayProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.EquationArrayProperties();
      value.BaseJustification = GetBaseJustification(openXmlElement);
      value.MaxDistribution = GetMaxDistribution(openXmlElement);
      value.ObjectDistribution = GetObjectDistribution(openXmlElement);
      value.RowSpacingRule = GetRowSpacingRule(openXmlElement);
      value.RowSpacing = GetRowSpacing(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.EquationArrayProperties? openXmlElement, DMMath.EquationArrayProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBaseJustification(openXmlElement, value.BaseJustification, diffs, objName))
        ok = false;
      if (!CmpMaxDistribution(openXmlElement, value.MaxDistribution, diffs, objName))
        ok = false;
      if (!CmpObjectDistribution(openXmlElement, value.ObjectDistribution, diffs, objName))
        ok = false;
      if (!CmpRowSpacingRule(openXmlElement, value.RowSpacingRule, diffs, objName))
        ok = false;
      if (!CmpRowSpacing(openXmlElement, value.RowSpacing, diffs, objName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, value.ControlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.EquationArrayProperties? value)
    where OpenXmlElementType: DXMath.EquationArrayProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBaseJustification(openXmlElement, value?.BaseJustification);
      SetMaxDistribution(openXmlElement, value?.MaxDistribution);
      SetObjectDistribution(openXmlElement, value?.ObjectDistribution);
      SetRowSpacingRule(openXmlElement, value?.RowSpacingRule);
      SetRowSpacing(openXmlElement, value?.RowSpacing);
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}
