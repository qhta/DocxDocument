using DocumentFormat.OpenXml.Vml.Office;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Shape Clipping Path.
/// </summary>
public static class ClipPathConverter
{
  /// <summary>
  ///   Path Definition
  /// </summary>
  public static String? GetValue(ClipPath? openXmlElement)
  {
    return openXmlElement?.Value?.Value;
  }

  public static void SetValue(ClipPath? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Value = new StringValue { Value = value };
      else
        openXmlElement.Value = null;
  }

  public static DocumentModel.Vml.ClipPath? CreateModelElement(ClipPath? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.ClipPath();
      value.Value = GetValue(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.ClipPath? value)
    where OpenXmlElementType : ClipPath, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetValue(openXmlElement, value?.Value);
      return openXmlElement;
    }
    return default;
  }
}