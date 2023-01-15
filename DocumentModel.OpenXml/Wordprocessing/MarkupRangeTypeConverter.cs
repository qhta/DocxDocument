using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using MarkupRangeType = DocumentFormat.OpenXml.Wordprocessing.MarkupRangeType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the MarkupRangeType Class.
/// </summary>
public static class MarkupRangeTypeConverter
{
  /// <summary>
  ///   displacedByCustomXml
  /// </summary>
  public static DisplacedByCustomXmlKind? GetDisplacedByCustomXml(MarkupRangeType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DisplacedByCustomXmlValues, DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }

  public static void SetDisplacedByCustomXml(MarkupRangeType? openXmlElement, DisplacedByCustomXmlKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DisplacedByCustomXmlValues, DisplacedByCustomXmlKind>(value);
  }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public static String? GetId(MarkupRangeType? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(MarkupRangeType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  public static DocumentModel.Wordprocessing.MarkupRangeType? CreateModelElement(MarkupRangeType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.MarkupRangeType();
      value.DisplacedByCustomXml = GetDisplacedByCustomXml(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.MarkupRangeType? value)
    where OpenXmlElementType : MarkupRangeType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDisplacedByCustomXml(openXmlElement, value?.DisplacedByCustomXml);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}