using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Category.
/// </summary>
public static class StyleDisplayCategoryConverter
{
  /// <summary>
  ///   Category Type
  /// </summary>
  public static String? GetType(StyleDisplayCategory? openXmlElement)
  {
    return openXmlElement?.Type?.Value;
  }

  public static void SetType(StyleDisplayCategory? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Type = new StringValue { Value = value };
      else
        openXmlElement.Type = null;
  }

  /// <summary>
  ///   Priority
  /// </summary>
  public static UInt32? GetPriority(StyleDisplayCategory? openXmlElement)
  {
    return openXmlElement?.Priority?.Value;
  }

  public static void SetPriority(StyleDisplayCategory? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Priority = value;
  }

  public static DocumentModel.Drawings.Diagrams.StyleDisplayCategory? CreateModelElement(StyleDisplayCategory? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.StyleDisplayCategory();
      value.Type = GetType(openXmlElement);
      value.Priority = GetPriority(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.StyleDisplayCategory? value)
    where OpenXmlElementType : StyleDisplayCategory, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetPriority(openXmlElement, value?.Priority);
      return openXmlElement;
    }
    return default;
  }
}