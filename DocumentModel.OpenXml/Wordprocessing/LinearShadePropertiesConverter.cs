using DocumentFormat.OpenXml.Office2010.Word;
using DocumentModel.Wordprocessing;
using LinearShadeProperties = DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the LinearShadeProperties Class.
/// </summary>
public static class LinearShadePropertiesConverter
{
  /// <summary>
  ///   ang, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetAngle(LinearShadeProperties? openXmlElement)
  {
    return openXmlElement?.Angle?.Value;
  }

  public static void SetAngle(LinearShadeProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Angle = value;
  }

  /// <summary>
  ///   scaled, this property is only available in Office 2010 and later.
  /// </summary>
  public static OnOffKind? GetScaled(LinearShadeProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<OnOffValues, OnOffKind>(openXmlElement?.Scaled?.Value);
  }

  public static void SetScaled(LinearShadeProperties? openXmlElement, OnOffKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Scaled = EnumValueConverter.CreateEnumValue<OnOffValues, OnOffKind>(value);
  }

  public static DocumentModel.Wordprocessing.LinearShadeProperties? CreateModelElement(LinearShadeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.LinearShadeProperties();
      value.Angle = GetAngle(openXmlElement);
      value.Scaled = GetScaled(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.LinearShadeProperties? value)
    where OpenXmlElementType : LinearShadeProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAngle(openXmlElement, value?.Angle);
      SetScaled(openXmlElement, value?.Scaled);
      return openXmlElement;
    }
    return default;
  }
}