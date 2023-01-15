using DocumentFormat.OpenXml.Vml.Office;
using DocumentModel.Vml;
using Background = DocumentFormat.OpenXml.Vml.Background;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Document Background.
/// </summary>
public static class BackgroundConverter
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public static String? GetId(Background? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(Background? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  public static Boolean? GetFilled(Background? openXmlElement)
  {
    return openXmlElement?.Filled?.Value;
  }

  public static void SetFilled(Background? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Filled = value;
      else
        openXmlElement.Filled = null;
  }

  /// <summary>
  ///   Fill Color
  /// </summary>
  public static String? GetFillcolor(Background? openXmlElement)
  {
    return openXmlElement?.Fillcolor?.Value;
  }

  public static void SetFillcolor(Background? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Fillcolor = new StringValue { Value = value };
      else
        openXmlElement.Fillcolor = null;
  }

  /// <summary>
  ///   Black-and-White Mode
  /// </summary>
  public static BlackAndWhiteMode? GetBlackWhiteMode(Background? openXmlElement)
  {
    return EnumValueConverter.GetValue<BlackAndWhiteModeValues, BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }

  public static void SetBlackWhiteMode(Background? openXmlElement, BlackAndWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<BlackAndWhiteModeValues, BlackAndWhiteMode>(value);
  }

  /// <summary>
  ///   Pure Black-and-White Mode
  /// </summary>
  public static BlackAndWhiteMode? GetPureBlackWhiteMode(Background? openXmlElement)
  {
    return EnumValueConverter.GetValue<BlackAndWhiteModeValues, BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value);
  }

  public static void SetPureBlackWhiteMode(Background? openXmlElement, BlackAndWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.PureBlackWhiteMode = EnumValueConverter.CreateEnumValue<BlackAndWhiteModeValues, BlackAndWhiteMode>(value);
  }

  /// <summary>
  ///   Normal Black-and-White Mode
  /// </summary>
  public static BlackAndWhiteMode? GetNormalBlackWhiteMode(Background? openXmlElement)
  {
    return EnumValueConverter.GetValue<BlackAndWhiteModeValues, BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value);
  }

  public static void SetNormalBlackWhiteMode(Background? openXmlElement, BlackAndWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.NormalBlackWhiteMode = EnumValueConverter.CreateEnumValue<BlackAndWhiteModeValues, BlackAndWhiteMode>(value);
  }

  /// <summary>
  ///   Target Screen Size
  /// </summary>
  public static ScreenSizeKind? GetTargetScreenSize(Background? openXmlElement)
  {
    return EnumValueConverter.GetValue<ScreenSizeValues, ScreenSizeKind>(openXmlElement?.TargetScreenSize?.Value);
  }

  public static void SetTargetScreenSize(Background? openXmlElement, ScreenSizeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.TargetScreenSize = EnumValueConverter.CreateEnumValue<ScreenSizeValues, ScreenSizeKind>(value);
  }

  /// <summary>
  ///   Fill.
  /// </summary>
  public static Fill? GetFill(Background? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Fill>();
    if (itemElement != null)
      return FillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFill(Background? openXmlElement, Fill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Fill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Fill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Vml.Background? CreateModelElement(Background? openXmlElement)
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
    where OpenXmlElementType : Background, new()
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