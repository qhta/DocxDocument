namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Equation Array Properties.
/// </summary>
public static class EquationArrayPropertiesConverter
{
  /// <summary>
  /// Equation Array Base Justification.
  /// </summary>
  public static DocumentModel.Math.VerticalAlignmentKind? GetBaseJustification(DocumentFormat.OpenXml.Math.EquationArrayProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BaseJustification>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DocumentModel.Math.VerticalAlignmentKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetBaseJustification(DocumentFormat.OpenXml.Math.EquationArrayProperties? openXmlElement, DocumentModel.Math.VerticalAlignmentKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Maximum Distribution.
  /// </summary>
  public static DocumentModel.Math.BooleanKind? GetMaxDistribution(DocumentFormat.OpenXml.Math.EquationArrayProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MaxDistribution>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetMaxDistribution(DocumentFormat.OpenXml.Math.EquationArrayProperties? openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Object Distribution.
  /// </summary>
  public static DocumentModel.Math.BooleanKind? GetObjectDistribution(DocumentFormat.OpenXml.Math.EquationArrayProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ObjectDistribution>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetObjectDistribution(DocumentFormat.OpenXml.Math.EquationArrayProperties? openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Row Spacing Rule.
  /// </summary>
  public static Int32? GetRowSpacingRule(DocumentFormat.OpenXml.Math.EquationArrayProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRowSpacingRule(DocumentFormat.OpenXml.Math.EquationArrayProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Row Spacing (Equation Array).
  /// </summary>
  public static UInt16? GetRowSpacing(DocumentFormat.OpenXml.Math.EquationArrayProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRowSpacing(DocumentFormat.OpenXml.Math.EquationArrayProperties? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public static DocumentModel.Math.ControlProperties? GetControlProperties(DocumentFormat.OpenXml.Math.EquationArrayProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetControlProperties(DocumentFormat.OpenXml.Math.EquationArrayProperties? openXmlElement, DocumentModel.Math.ControlProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
