using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using PermEnd = DocumentFormat.OpenXml.Wordprocessing.PermEnd;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the PermEnd Class.
/// </summary>
public static class PermEndConverter
{
  /// <summary>
  ///   Annotation ID
  /// </summary>
  public static Int32? GetId(PermEnd? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(PermEnd? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Id = value;
  }

  /// <summary>
  ///   Annotation Displaced By Custom XML Markup
  /// </summary>
  public static DisplacedByCustomXmlKind? GetDisplacedByCustomXml(PermEnd? openXmlElement)
  {
    return EnumValueConverter.GetValue<DisplacedByCustomXmlValues, DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }

  public static void SetDisplacedByCustomXml(PermEnd? openXmlElement, DisplacedByCustomXmlKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DisplacedByCustomXmlValues, DisplacedByCustomXmlKind>(value);
  }

  public static DocumentModel.Wordprocessing.PermEnd? CreateModelElement(PermEnd? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PermEnd();
      value.Id = GetId(openXmlElement);
      value.DisplacedByCustomXml = GetDisplacedByCustomXml(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PermEnd? value)
    where OpenXmlElementType : PermEnd, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetDisplacedByCustomXml(openXmlElement, value?.DisplacedByCustomXml);
      return openXmlElement;
    }
    return default;
  }
}