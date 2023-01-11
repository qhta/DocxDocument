namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Document Background.
/// </summary>
public static class BackgroundConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Vml.Background? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Vml.Background? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public static Boolean? GetFilled(DocumentFormat.OpenXml.Vml.Background? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetFilled(DocumentFormat.OpenXml.Vml.Background? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  public static String? GetFillcolor(DocumentFormat.OpenXml.Vml.Background? openXmlElement)
  {
    return openXmlElement?.Fillcolor?.Value;
  }
  
  public static void SetFillcolor(DocumentFormat.OpenXml.Vml.Background? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Fillcolor = new StringValue { Value = value };
      else
        openXmlElement.Fillcolor = null;
  }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  public static DocumentModel.Vml.BlackAndWhiteMode? GetBlackWhiteMode(DocumentFormat.OpenXml.Vml.Background? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  public static void SetBlackWhiteMode(DocumentFormat.OpenXml.Vml.Background? openXmlElement, DocumentModel.Vml.BlackAndWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  public static DocumentModel.Vml.BlackAndWhiteMode? GetPureBlackWhiteMode(DocumentFormat.OpenXml.Vml.Background? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value);
  }
  
  public static void SetPureBlackWhiteMode(DocumentFormat.OpenXml.Vml.Background? openXmlElement, DocumentModel.Vml.BlackAndWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.PureBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  public static DocumentModel.Vml.BlackAndWhiteMode? GetNormalBlackWhiteMode(DocumentFormat.OpenXml.Vml.Background? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value);
  }
  
  public static void SetNormalBlackWhiteMode(DocumentFormat.OpenXml.Vml.Background? openXmlElement, DocumentModel.Vml.BlackAndWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.NormalBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Target Screen Size
  /// </summary>
  public static DocumentModel.Vml.ScreenSizeKind? GetTargetScreenSize(DocumentFormat.OpenXml.Vml.Background? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues, DocumentModel.Vml.ScreenSizeKind>(openXmlElement?.TargetScreenSize?.Value);
  }
  
  public static void SetTargetScreenSize(DocumentFormat.OpenXml.Vml.Background? openXmlElement, DocumentModel.Vml.ScreenSizeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.TargetScreenSize = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues, DocumentModel.Vml.ScreenSizeKind>(value);
  }
  
  /// <summary>
  /// Fill.
  /// </summary>
  public static DocumentModel.Vml.Fill? GetFill(DocumentFormat.OpenXml.Vml.Background? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Fill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.FillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFill(DocumentFormat.OpenXml.Vml.Background? openXmlElement, DocumentModel.Vml.Fill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Fill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.FillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Fill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.Background? CreateModelElement(DocumentFormat.OpenXml.Vml.Background? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Background();
      value.Id = GetId(openXmlElement);
      value.Filled = GetFilled(openXmlElement);
      value.Fillcolor = GetFillcolor(openXmlElement);
      value.BlackWhiteMode = GetBlackWhiteMode(openXmlElement);
      value.PureBlackWhiteMode = GetPureBlackWhiteMode(openXmlElement);
      value.NormalBlackWhiteMode = GetNormalBlackWhiteMode(openXmlElement);
      value.TargetScreenSize = GetTargetScreenSize(openXmlElement);
      value.Fill = GetFill(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Background? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Background, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
