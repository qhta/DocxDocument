namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Document Background.
/// </summary>
public static class BackgroundConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Vml.Background openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Vml.Background openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  private static Boolean? GetFilled(DocumentFormat.OpenXml.Vml.Background openXmlElement)
  {
    return openXmlElement?.Filled?.Value;
  }
  
  private static void SetFilled(DocumentFormat.OpenXml.Vml.Background openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Filled = value;
    else
      openXmlElement.Filled = null;
  }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  private static String? GetFillcolor(DocumentFormat.OpenXml.Vml.Background openXmlElement)
  {
    return openXmlElement?.Fillcolor?.Value;
  }
  
  private static void SetFillcolor(DocumentFormat.OpenXml.Vml.Background openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Fillcolor = new StringValue { Value = value };
    else
      openXmlElement.Fillcolor = null;
  }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  private static DocumentModel.Vml.BlackAndWhiteMode? GetBlackWhiteMode(DocumentFormat.OpenXml.Vml.Background openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  private static void SetBlackWhiteMode(DocumentFormat.OpenXml.Vml.Background openXmlElement, DocumentModel.Vml.BlackAndWhiteMode? value)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  private static DocumentModel.Vml.BlackAndWhiteMode? GetPureBlackWhiteMode(DocumentFormat.OpenXml.Vml.Background openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value);
  }
  
  private static void SetPureBlackWhiteMode(DocumentFormat.OpenXml.Vml.Background openXmlElement, DocumentModel.Vml.BlackAndWhiteMode? value)
  {
    openXmlElement.PureBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  private static DocumentModel.Vml.BlackAndWhiteMode? GetNormalBlackWhiteMode(DocumentFormat.OpenXml.Vml.Background openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value);
  }
  
  private static void SetNormalBlackWhiteMode(DocumentFormat.OpenXml.Vml.Background openXmlElement, DocumentModel.Vml.BlackAndWhiteMode? value)
  {
    openXmlElement.NormalBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Target Screen Size
  /// </summary>
  private static DocumentModel.Vml.ScreenSizeKind? GetTargetScreenSize(DocumentFormat.OpenXml.Vml.Background openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues, DocumentModel.Vml.ScreenSizeKind>(openXmlElement?.TargetScreenSize?.Value);
  }
  
  private static void SetTargetScreenSize(DocumentFormat.OpenXml.Vml.Background openXmlElement, DocumentModel.Vml.ScreenSizeKind? value)
  {
    openXmlElement.TargetScreenSize = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues, DocumentModel.Vml.ScreenSizeKind>(value);
  }
  
  /// <summary>
  /// Fill.
  /// </summary>
  private static DocumentModel.Vml.Fill? GetFill(DocumentFormat.OpenXml.Vml.Background openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Fill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.FillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFill(DocumentFormat.OpenXml.Vml.Background openXmlElement, DocumentModel.Vml.Fill? value)
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetFilled(openXmlElement, value?.Filled);
      SetFillcolor(openXmlElement, value?.Fillcolor);
      SetBlackWhiteMode(openXmlElement, value?.BlackWhiteMode);
      SetPureBlackWhiteMode(openXmlElement, value?.PureBlackWhiteMode);
      SetNormalBlackWhiteMode(openXmlElement, value?.NormalBlackWhiteMode);
      SetTargetScreenSize(openXmlElement, value?.TargetScreenSize);
      SetFill(openXmlElement, value?.Fill);
      return openXmlElement;
    }
    return default;
  }
}
