namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Delimiter Properties.
/// </summary>
public static class DelimiterPropertiesConverter
{
  /// <summary>
  /// Delimiter Grow.
  /// </summary>
  public static DocumentModel.Math.BooleanKind? GetGrowOperators(DocumentFormat.OpenXml.Math.DelimiterProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.GrowOperators>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetGrowOperators(DocumentFormat.OpenXml.Math.DelimiterProperties? openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.GrowOperators>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.GrowOperators, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Shape (Delimiters).
  /// </summary>
  public static DocumentModel.Math.ShapeDelimiterKind? GetShape(DocumentFormat.OpenXml.Math.DelimiterProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Shape>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues, DocumentModel.Math.ShapeDelimiterKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetShape(DocumentFormat.OpenXml.Math.DelimiterProperties? openXmlElement, DocumentModel.Math.ShapeDelimiterKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Shape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Shape, DocumentFormat.OpenXml.Math.ShapeDelimiterValues, DocumentModel.Math.ShapeDelimiterKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
