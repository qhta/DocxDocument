namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// UI Default Colors.
/// </summary>
public static class ColorMenuConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.ColorMenu openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static void SetExtension(DocumentFormat.OpenXml.Vml.Office.ColorMenu openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Default stroke color
  /// </summary>
  private static String? GetStrokeColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu openXmlElement)
  {
    return openXmlElement?.StrokeColor?.Value;
  }
  
  private static void SetStrokeColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.StrokeColor = new StringValue { Value = value };
    else
      openXmlElement.StrokeColor = null;
  }
  
  /// <summary>
  /// Default fill color
  /// </summary>
  private static String? GetFillColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu openXmlElement)
  {
    return openXmlElement?.FillColor?.Value;
  }
  
  private static void SetFillColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FillColor = new StringValue { Value = value };
    else
      openXmlElement.FillColor = null;
  }
  
  /// <summary>
  /// Default shadow color
  /// </summary>
  private static String? GetShadowColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu openXmlElement)
  {
    return openXmlElement?.ShadowColor?.Value;
  }
  
  private static void SetShadowColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ShadowColor = new StringValue { Value = value };
    else
      openXmlElement.ShadowColor = null;
  }
  
  /// <summary>
  /// Default extrusion color
  /// </summary>
  private static String? GetExtrusionColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu openXmlElement)
  {
    return openXmlElement?.ExtrusionColor?.Value;
  }
  
  private static void SetExtrusionColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ExtrusionColor = new StringValue { Value = value };
    else
      openXmlElement.ExtrusionColor = null;
  }
  
  public static DocumentModel.Vml.ColorMenu? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.ColorMenu, new()
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
