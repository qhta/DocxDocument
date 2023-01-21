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
    var itemElement = openXmlElement.GetFirstChild<DXMath.BaseJustification>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DMMath.VerticalAlignmentKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXMath.MaxDistribution>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXMath.ObjectDistribution>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.RowSpacingRule>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.RowSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (itemElement != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMMath.EquationArrayProperties? CreateModelElement(DXMath.EquationArrayProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.EquationArrayProperties();
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
