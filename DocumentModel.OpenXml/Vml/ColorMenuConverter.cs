namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// UI Default Colors.
/// </summary>
public static class ColorMenuConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  public static void SetExtension(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Default stroke color
  /// </summary>
  public static String? GetStrokeColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement)
  {
    return openXmlElement?.StrokeColor?.Value;
  }
  
  public static void SetStrokeColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.StrokeColor = new StringValue { Value = value };
      else
        openXmlElement.StrokeColor = null;
  }
  
  /// <summary>
  /// Default fill color
  /// </summary>
  public static String? GetFillColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement)
  {
    return openXmlElement?.FillColor?.Value;
  }
  
  public static void SetFillColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FillColor = new StringValue { Value = value };
      else
        openXmlElement.FillColor = null;
  }
  
  /// <summary>
  /// Default shadow color
  /// </summary>
  public static String? GetShadowColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement)
  {
    return openXmlElement?.ShadowColor?.Value;
  }
  
  public static void SetShadowColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShadowColor = new StringValue { Value = value };
      else
        openXmlElement.ShadowColor = null;
  }
  
  /// <summary>
  /// Default extrusion color
  /// </summary>
  public static String? GetExtrusionColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement)
  {
    return openXmlElement?.ExtrusionColor?.Value;
  }
  
  public static void SetExtrusionColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
