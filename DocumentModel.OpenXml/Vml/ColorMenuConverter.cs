namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// UI Default Colors.
/// </summary>
public static class ColorMenuConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.ColorMenu openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static void SetExtension(DXVmlO.ColorMenu openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Default stroke color
  /// </summary>
  private static String? GetStrokeColor(DXVmlO.ColorMenu openXmlElement)
  {
    return openXmlElement?.StrokeColor?.Value;
  }
  
  private static void SetStrokeColor(DXVmlO.ColorMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.StrokeColor = new StringValue { Value = value };
    else
      openXmlElement.StrokeColor = null;
  }
  
  /// <summary>
  /// Default fill color
  /// </summary>
  private static String? GetFillColor(DXVmlO.ColorMenu openXmlElement)
  {
    return openXmlElement?.FillColor?.Value;
  }
  
  private static void SetFillColor(DXVmlO.ColorMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FillColor = new StringValue { Value = value };
    else
      openXmlElement.FillColor = null;
  }
  
  /// <summary>
  /// Default shadow color
  /// </summary>
  private static String? GetShadowColor(DXVmlO.ColorMenu openXmlElement)
  {
    return openXmlElement?.ShadowColor?.Value;
  }
  
  private static void SetShadowColor(DXVmlO.ColorMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ShadowColor = new StringValue { Value = value };
    else
      openXmlElement.ShadowColor = null;
  }
  
  /// <summary>
  /// Default extrusion color
  /// </summary>
  private static String? GetExtrusionColor(DXVmlO.ColorMenu openXmlElement)
  {
    return openXmlElement?.ExtrusionColor?.Value;
  }
  
  private static void SetExtrusionColor(DXVmlO.ColorMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ExtrusionColor = new StringValue { Value = value };
    else
      openXmlElement.ExtrusionColor = null;
  }
  
  public static DMVml.ColorMenu? CreateModelElement(DXVmlO.ColorMenu? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.ColorMenu();
      value.Extension = GetExtension(openXmlElement);
      value.StrokeColor = GetStrokeColor(openXmlElement);
      value.FillColor = GetFillColor(openXmlElement);
      value.ShadowColor = GetShadowColor(openXmlElement);
      value.ExtrusionColor = GetExtrusionColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.ColorMenu? value)
    where OpenXmlElementType: DXVmlO.ColorMenu, new()
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
