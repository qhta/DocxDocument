namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the TextPath Class.
/// </summary>
public static class TextPathConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Vml.TextPath openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Vml.TextPath openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  private static String? GetStyle(DocumentFormat.OpenXml.Vml.TextPath openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }
  
  private static void SetStyle(DocumentFormat.OpenXml.Vml.TextPath openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Style = new StringValue { Value = value };
    else
      openXmlElement.Style = null;
  }
  
  /// <summary>
  /// Text Path Toggle
  /// </summary>
  private static Boolean? GetOn(DocumentFormat.OpenXml.Vml.TextPath openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static void SetOn(DocumentFormat.OpenXml.Vml.TextPath openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Shape Fit Toggle
  /// </summary>
  private static Boolean? GetFitShape(DocumentFormat.OpenXml.Vml.TextPath openXmlElement)
  {
    return openXmlElement?.FitShape?.Value;
  }
  
  private static void SetFitShape(DocumentFormat.OpenXml.Vml.TextPath openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FitShape = value;
    else
      openXmlElement.FitShape = null;
  }
  
  /// <summary>
  /// Path Fit Toggle
  /// </summary>
  private static Boolean? GetFitPath(DocumentFormat.OpenXml.Vml.TextPath openXmlElement)
  {
    return openXmlElement?.FitPath?.Value;
  }
  
  private static void SetFitPath(DocumentFormat.OpenXml.Vml.TextPath openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FitPath = value;
    else
      openXmlElement.FitPath = null;
  }
  
  /// <summary>
  /// Text Path Trim Toggle
  /// </summary>
  private static Boolean? GetTrim(DocumentFormat.OpenXml.Vml.TextPath openXmlElement)
  {
    return openXmlElement?.Trim?.Value;
  }
  
  private static void SetTrim(DocumentFormat.OpenXml.Vml.TextPath openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Trim = value;
    else
      openXmlElement.Trim = null;
  }
  
  /// <summary>
  /// Text X-Scaling
  /// </summary>
  private static Boolean? GetXScale(DocumentFormat.OpenXml.Vml.TextPath openXmlElement)
  {
    return openXmlElement?.XScale?.Value;
  }
  
  private static void SetXScale(DocumentFormat.OpenXml.Vml.TextPath openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.XScale = value;
    else
      openXmlElement.XScale = null;
  }
  
  /// <summary>
  /// Text Path Text
  /// </summary>
  private static String? GetString(DocumentFormat.OpenXml.Vml.TextPath openXmlElement)
  {
    return openXmlElement?.String?.Value;
  }
  
  private static void SetString(DocumentFormat.OpenXml.Vml.TextPath openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.String = new StringValue { Value = value };
    else
      openXmlElement.String = null;
  }
  
  public static DocumentModel.Vml.TextPath? CreateModelElement(DocumentFormat.OpenXml.Vml.TextPath? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.TextPath();
      value.Id = GetId(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.On = GetOn(openXmlElement);
      value.FitShape = GetFitShape(openXmlElement);
      value.FitPath = GetFitPath(openXmlElement);
      value.Trim = GetTrim(openXmlElement);
      value.XScale = GetXScale(openXmlElement);
      value.String = GetString(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.TextPath? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.TextPath, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetStyle(openXmlElement, value?.Style);
      SetOn(openXmlElement, value?.On);
      SetFitShape(openXmlElement, value?.FitShape);
      SetFitPath(openXmlElement, value?.FitPath);
      SetTrim(openXmlElement, value?.Trim);
      SetXScale(openXmlElement, value?.XScale);
      SetString(openXmlElement, value?.String);
      return openXmlElement;
    }
    return default;
  }
}
