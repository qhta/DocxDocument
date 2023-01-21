namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Document Background.
/// </summary>
public static class BackgroundConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXVml.Background openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXVml.Background openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  private static Boolean? GetFilled(DXVml.Background openXmlElement)
  {
    return openXmlElement?.Filled?.Value;
  }
  
  private static void SetFilled(DXVml.Background openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Filled = value;
    else
      openXmlElement.Filled = null;
  }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  private static String? GetFillcolor(DXVml.Background openXmlElement)
  {
    return openXmlElement?.Fillcolor?.Value;
  }
  
  private static void SetFillcolor(DXVml.Background openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Fillcolor = new StringValue { Value = value };
    else
      openXmlElement.Fillcolor = null;
  }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  private static DMVml.BlackAndWhiteMode? GetBlackWhiteMode(DXVml.Background openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  private static void SetBlackWhiteMode(DXVml.Background openXmlElement, DMVml.BlackAndWhiteMode? value)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  private static DMVml.BlackAndWhiteMode? GetPureBlackWhiteMode(DXVml.Background openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value);
  }
  
  private static void SetPureBlackWhiteMode(DXVml.Background openXmlElement, DMVml.BlackAndWhiteMode? value)
  {
    openXmlElement.PureBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  private static DMVml.BlackAndWhiteMode? GetNormalBlackWhiteMode(DXVml.Background openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value);
  }
  
  private static void SetNormalBlackWhiteMode(DXVml.Background openXmlElement, DMVml.BlackAndWhiteMode? value)
  {
    openXmlElement.NormalBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Target Screen Size
  /// </summary>
  private static DMVml.ScreenSizeKind? GetTargetScreenSize(DXVml.Background openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues, DMVml.ScreenSizeKind>(openXmlElement?.TargetScreenSize?.Value);
  }
  
  private static void SetTargetScreenSize(DXVml.Background openXmlElement, DMVml.ScreenSizeKind? value)
  {
    openXmlElement.TargetScreenSize = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues, DMVml.ScreenSizeKind>(value);
  }
  
  /// <summary>
  /// Fill.
  /// </summary>
  private static DMVml.Fill? GetFill(DXVml.Background openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Fill>();
    if (itemElement != null)
      return DMXVml.FillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFill(DXVml.Background openXmlElement, DMVml.Fill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Fill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.FillConverter.CreateOpenXmlElement<DXVml.Fill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMVml.Background? CreateModelElement(DXVml.Background? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.Background();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.Background? value)
    where OpenXmlElementType: DXVml.Background, new()
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
