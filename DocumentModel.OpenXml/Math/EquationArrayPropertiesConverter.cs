namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Equation Array Properties.
/// </summary>
public static class EquationArrayPropertiesConverter
{
  /// <summary>
  /// Equation Array Base Justification.
  /// </summary>
  private static DocumentModel.Math.VerticalAlignmentKind? GetBaseJustification(DocumentFormat.OpenXml.Math.EquationArrayProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BaseJustification>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DocumentModel.Math.VerticalAlignmentKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetBaseJustification(DocumentFormat.OpenXml.Math.EquationArrayProperties openXmlElement, DocumentModel.Math.VerticalAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BaseJustification>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.BaseJustification, DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DocumentModel.Math.VerticalAlignmentKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Maximum Distribution.
  /// </summary>
  private static DocumentModel.Math.BooleanKind? GetMaxDistribution(DocumentFormat.OpenXml.Math.EquationArrayProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MaxDistribution>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetMaxDistribution(DocumentFormat.OpenXml.Math.EquationArrayProperties openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MaxDistribution>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.MaxDistribution, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Object Distribution.
  /// </summary>
  private static DocumentModel.Math.BooleanKind? GetObjectDistribution(DocumentFormat.OpenXml.Math.EquationArrayProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ObjectDistribution>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetObjectDistribution(DocumentFormat.OpenXml.Math.EquationArrayProperties openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ObjectDistribution>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ObjectDistribution, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Row Spacing Rule.
  /// </summary>
  private static Int64? GetRowSpacingRule(DocumentFormat.OpenXml.Math.EquationArrayProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.RowSpacingRule>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetRowSpacingRule(DocumentFormat.OpenXml.Math.EquationArrayProperties openXmlElement, Int64? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.RowSpacingRule>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Math.RowSpacingRule{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Row Spacing (Equation Array).
  /// </summary>
  private static UInt16? GetRowSpacing(DocumentFormat.OpenXml.Math.EquationArrayProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.RowSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetRowSpacing(DocumentFormat.OpenXml.Math.EquationArrayProperties openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.RowSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Math.RowSpacing{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DocumentModel.Math.ControlProperties? GetControlProperties(DocumentFormat.OpenXml.Math.EquationArrayProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetControlProperties(DocumentFormat.OpenXml.Math.EquationArrayProperties openXmlElement, DocumentModel.Math.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.ControlPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.EquationArrayProperties? CreateModelElement(DocumentFormat.OpenXml.Math.EquationArrayProperties? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.EquationArrayProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.EquationArrayProperties, new()
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
