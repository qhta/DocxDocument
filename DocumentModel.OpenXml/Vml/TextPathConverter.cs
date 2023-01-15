using DocumentFormat.OpenXml.Vml;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Defines the TextPath Class.
/// </summary>
public static class TextPathConverter
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public static String? GetId(TextPath? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(TextPath? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   Shape Styling Properties
  /// </summary>
  public static String? GetStyle(TextPath? openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }

  public static void SetStyle(TextPath? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Style = new StringValue { Value = value };
      else
        openXmlElement.Style = null;
  }

  /// <summary>
  ///   Text Path Toggle
  /// </summary>
  public static Boolean? GetOn(TextPath? openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }

  public static void SetOn(TextPath? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.On = value;
      else
        openXmlElement.On = null;
  }

  /// <summary>
  ///   Shape Fit Toggle
  /// </summary>
  public static Boolean? GetFitShape(TextPath? openXmlElement)
  {
    return openXmlElement?.FitShape?.Value;
  }

  public static void SetFitShape(TextPath? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FitShape = value;
      else
        openXmlElement.FitShape = null;
  }

  /// <summary>
  ///   Path Fit Toggle
  /// </summary>
  public static Boolean? GetFitPath(TextPath? openXmlElement)
  {
    return openXmlElement?.FitPath?.Value;
  }

  public static void SetFitPath(TextPath? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FitPath = value;
      else
        openXmlElement.FitPath = null;
  }

  /// <summary>
  ///   Text Path Trim Toggle
  /// </summary>
  public static Boolean? GetTrim(TextPath? openXmlElement)
  {
    return openXmlElement?.Trim?.Value;
  }

  public static void SetTrim(TextPath? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Trim = value;
      else
        openXmlElement.Trim = null;
  }

  /// <summary>
  ///   Text X-Scaling
  /// </summary>
  public static Boolean? GetXScale(TextPath? openXmlElement)
  {
    return openXmlElement?.XScale?.Value;
  }

  public static void SetXScale(TextPath? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.XScale = value;
      else
        openXmlElement.XScale = null;
  }

  /// <summary>
  ///   Text Path Text
  /// </summary>
  public static String? GetString(TextPath? openXmlElement)
  {
    return openXmlElement?.String?.Value;
  }

  public static void SetString(TextPath? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.String = new StringValue { Value = value };
      else
        openXmlElement.String = null;
  }

  public static DocumentModel.Vml.TextPath? CreateModelElement(TextPath? openXmlElement)
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
    where OpenXmlElementType : TextPath, new()
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