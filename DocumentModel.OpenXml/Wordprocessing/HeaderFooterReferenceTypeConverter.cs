using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using HeaderFooterReferenceType = DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the HeaderFooterReferenceType Class.
/// </summary>
public static class HeaderFooterReferenceTypeConverter
{
  /// <summary>
  ///   type
  /// </summary>
  public static HeaderFooterKind? GetType(HeaderFooterReferenceType? openXmlElement)
  {
    return EnumValueConverter.GetValue<HeaderFooterValues, HeaderFooterKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(HeaderFooterReferenceType? openXmlElement, HeaderFooterKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<HeaderFooterValues, HeaderFooterKind>(value);
  }

  /// <summary>
  ///   Relationship to Part
  /// </summary>
  public static String? GetId(HeaderFooterReferenceType? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(HeaderFooterReferenceType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  public static DocumentModel.Wordprocessing.HeaderFooterReferenceType? CreateModelElement(HeaderFooterReferenceType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.HeaderFooterReferenceType();
      value.Type = GetType(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.HeaderFooterReferenceType? value)
    where OpenXmlElementType : HeaderFooterReferenceType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}