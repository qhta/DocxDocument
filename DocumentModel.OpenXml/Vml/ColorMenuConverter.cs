using DocumentFormat.OpenXml.Vml;
using DocumentModel.Vml;
using ColorMenu = DocumentFormat.OpenXml.Vml.Office.ColorMenu;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   UI Default Colors.
/// </summary>
public static class ColorMenuConverter
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public static ExtensionHandlingBehaviorKind? GetExtension(ColorMenu? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }

  public static void SetExtension(ColorMenu? openXmlElement, ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(value);
  }

  /// <summary>
  ///   Default stroke color
  /// </summary>
  public static String? GetStrokeColor(ColorMenu? openXmlElement)
  {
    return openXmlElement?.StrokeColor?.Value;
  }

  public static void SetStrokeColor(ColorMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.StrokeColor = new StringValue { Value = value };
      else
        openXmlElement.StrokeColor = null;
  }

  /// <summary>
  ///   Default fill color
  /// </summary>
  public static String? GetFillColor(ColorMenu? openXmlElement)
  {
    return openXmlElement?.FillColor?.Value;
  }

  public static void SetFillColor(ColorMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FillColor = new StringValue { Value = value };
      else
        openXmlElement.FillColor = null;
  }

  /// <summary>
  ///   Default shadow color
  /// </summary>
  public static String? GetShadowColor(ColorMenu? openXmlElement)
  {
    return openXmlElement?.ShadowColor?.Value;
  }

  public static void SetShadowColor(ColorMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShadowColor = new StringValue { Value = value };
      else
        openXmlElement.ShadowColor = null;
  }

  /// <summary>
  ///   Default extrusion color
  /// </summary>
  public static String? GetExtrusionColor(ColorMenu? openXmlElement)
  {
    return openXmlElement?.ExtrusionColor?.Value;
  }

  public static void SetExtrusionColor(ColorMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ExtrusionColor = new StringValue { Value = value };
      else
        openXmlElement.ExtrusionColor = null;
  }

  public static DocumentModel.Vml.ColorMenu? CreateModelElement(ColorMenu? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.ColorMenu();
      value.Extension = GetExtension(openXmlElement);
      value.StrokeColor = GetStrokeColor(openXmlElement);
      value.FillColor = GetFillColor(openXmlElement);
      value.ShadowColor = GetShadowColor(openXmlElement);
      value.ExtrusionColor = GetExtrusionColor(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.ColorMenu? value)
    where OpenXmlElementType : ColorMenu, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetStrokeColor(openXmlElement, value?.StrokeColor);
      SetFillColor(openXmlElement, value?.FillColor);
      SetShadowColor(openXmlElement, value?.ShadowColor);
      SetExtrusionColor(openXmlElement, value?.ExtrusionColor);
      return openXmlElement;
    }
    return default;
  }
}