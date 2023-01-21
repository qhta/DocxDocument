namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the TextPath Class.
/// </summary>
public static class TextPathConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXVml.TextPath openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXVml.TextPath openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  private static String? GetStyle(DXVml.TextPath openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }
  
  private static void SetStyle(DXVml.TextPath openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Style = new StringValue { Value = value };
    else
      openXmlElement.Style = null;
  }
  
  /// <summary>
  /// Text Path Toggle
  /// </summary>
  private static Boolean? GetOn(DXVml.TextPath openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static void SetOn(DXVml.TextPath openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Shape Fit Toggle
  /// </summary>
  private static Boolean? GetFitShape(DXVml.TextPath openXmlElement)
  {
    return openXmlElement?.FitShape?.Value;
  }
  
  private static void SetFitShape(DXVml.TextPath openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FitShape = value;
    else
      openXmlElement.FitShape = null;
  }
  
  /// <summary>
  /// Path Fit Toggle
  /// </summary>
  private static Boolean? GetFitPath(DXVml.TextPath openXmlElement)
  {
    return openXmlElement?.FitPath?.Value;
  }
  
  private static void SetFitPath(DXVml.TextPath openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FitPath = value;
    else
      openXmlElement.FitPath = null;
  }
  
  /// <summary>
  /// Text Path Trim Toggle
  /// </summary>
  private static Boolean? GetTrim(DXVml.TextPath openXmlElement)
  {
    return openXmlElement?.Trim?.Value;
  }
  
  private static void SetTrim(DXVml.TextPath openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Trim = value;
    else
      openXmlElement.Trim = null;
  }
  
  /// <summary>
  /// Text X-Scaling
  /// </summary>
  private static Boolean? GetXScale(DXVml.TextPath openXmlElement)
  {
    return openXmlElement?.XScale?.Value;
  }
  
  private static void SetXScale(DXVml.TextPath openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.XScale = value;
    else
      openXmlElement.XScale = null;
  }
  
  /// <summary>
  /// Text Path Text
  /// </summary>
  private static String? GetString(DXVml.TextPath openXmlElement)
  {
    return openXmlElement?.String?.Value;
  }
  
  private static void SetString(DXVml.TextPath openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.String = new StringValue { Value = value };
    else
      openXmlElement.String = null;
  }
  
  public static DMVml.TextPath? CreateModelElement(DXVml.TextPath? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.TextPath();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.TextPath? value)
    where OpenXmlElementType: DXVml.TextPath, new()
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
