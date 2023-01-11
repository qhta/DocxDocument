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
  public static Int64? GetRowSpacingRule(DocumentFormat.OpenXml.Math.EquationArrayProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Math.RowSpacingRule");
  }
  
  public static void SetRowSpacingRule(DocumentFormat.OpenXml.Math.EquationArrayProperties? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Math.RowSpacingRule");
  }
  
  /// <summary>
  /// Row Spacing (Equation Array).
  /// </summary>
  public static UInt16? GetRowSpacing(DocumentFormat.OpenXml.Math.EquationArrayProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Math.RowSpacing");
  }
  
  public static void SetRowSpacing(DocumentFormat.OpenXml.Math.EquationArrayProperties? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Math.RowSpacing");
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public static DocumentModel.Math.ControlProperties? GetControlProperties(DocumentFormat.OpenXml.Math.EquationArrayProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetControlProperties(DocumentFormat.OpenXml.Math.EquationArrayProperties? openXmlElement, DocumentModel.Math.ControlProperties? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
