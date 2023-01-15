using DocumentFormat.OpenXml.Math;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Text.
/// </summary>
public static class TextConverter
{
  /// <summary>
  ///   space
  /// </summary>
  public static SpaceProcessingMode? GetSpace(Text? openXmlElement)
  {
    return EnumValueConverter.GetValue<SpaceProcessingModeValues, SpaceProcessingMode>(openXmlElement?.Space?.Value);
  }

  public static void SetSpace(Text? openXmlElement, SpaceProcessingMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.Space = EnumValueConverter.CreateEnumValue<SpaceProcessingModeValues, SpaceProcessingMode>(value);
  }

  public static DocumentModel.Math.Text? CreateModelElement(Text? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Text();
      value.Space = GetSpace(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Text? value)
    where OpenXmlElementType : Text, new()
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