namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Delimiter Properties.
/// </summary>
public static class DelimiterPropertiesConverter
{
  /// <summary>
  /// Delimiter Beginning Character.
  /// </summary>
  public static String? GetBeginChar(DocumentFormat.OpenXml.Math.DelimiterProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Math.BeginChar");
  }
  
  public static void SetBeginChar(DocumentFormat.OpenXml.Math.DelimiterProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Math.BeginChar");
  }
  
  /// <summary>
  /// Delimiter Separator Character.
  /// </summary>
  public static String? GetSeparatorChar(DocumentFormat.OpenXml.Math.DelimiterProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Math.SeparatorChar");
  }
  
  public static void SetSeparatorChar(DocumentFormat.OpenXml.Math.DelimiterProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Math.SeparatorChar");
  }
  
  /// <summary>
  /// Delimiter Ending Character.
  /// </summary>
  public static String? GetEndChar(DocumentFormat.OpenXml.Math.DelimiterProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Math.EndChar");
  }
  
  public static void SetEndChar(DocumentFormat.OpenXml.Math.DelimiterProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Math.EndChar");
  }
  
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
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public static DocumentModel.Math.ControlProperties? GetControlProperties(DocumentFormat.OpenXml.Math.DelimiterProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetControlProperties(DocumentFormat.OpenXml.Math.DelimiterProperties? openXmlElement, DocumentModel.Math.ControlProperties? value)
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
  
  public static DocumentModel.Math.DelimiterProperties? CreateModelElement(DocumentFormat.OpenXml.Math.DelimiterProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.DelimiterProperties();
      value.BeginChar = GetBeginChar(openXmlElement);
      value.SeparatorChar = GetSeparatorChar(openXmlElement);
      value.EndChar = GetEndChar(openXmlElement);
      value.GrowOperators = GetGrowOperators(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.DelimiterProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.DelimiterProperties, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
