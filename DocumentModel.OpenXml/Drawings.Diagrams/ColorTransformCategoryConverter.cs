using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Color Transform Category.
/// </summary>
public static class ColorTransformCategoryConverter
{
  /// <summary>
  ///   Category Type
  /// </summary>
  public static String? GetType(ColorTransformCategory? openXmlElement)
  {
    return openXmlElement?.Type?.Value;
  }

  public static void SetType(ColorTransformCategory? openXmlElement, String? value)
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
  public static UInt32? GetPriority(ColorTransformCategory? openXmlElement)
  {
    return openXmlElement?.Priority?.Value;
  }

  public static void SetPriority(ColorTransformCategory? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Priority = value;
  }

  public static DocumentModel.Drawings.Diagrams.ColorTransformCategory? CreateModelElement(ColorTransformCategory? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ColorTransformCategory();
      value.Type = GetType(openXmlElement);
      value.Priority = GetPriority(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.ColorTransformCategory? value)
    where OpenXmlElementType : ColorTransformCategory, new()
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