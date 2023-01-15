using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the TextType Class.
/// </summary>
public static class TextTypeConverter
{
  /// <summary>
  ///   space
  /// </summary>
  public static SpaceProcessingMode? GetSpace(TextType? openXmlElement)
  {
    return EnumValueConverter.GetValue<SpaceProcessingModeValues, SpaceProcessingMode>(openXmlElement?.Space?.Value);
  }

  public static void SetSpace(TextType? openXmlElement, SpaceProcessingMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.Space = EnumValueConverter.CreateEnumValue<SpaceProcessingModeValues, SpaceProcessingMode>(value);
  }

  public static DocumentModel.Wordprocessing.TextType? CreateModelElement(TextType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TextType();
      value.Space = GetSpace(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TextType? value)
    where OpenXmlElementType : TextType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSpace(openXmlElement, value?.Space);
      return openXmlElement;
    }
    return default;
  }
}