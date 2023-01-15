using DocumentModel.Wordprocessing;
using ParagraphPropertiesDefault = DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Default Paragraph Properties.
/// </summary>
public static class ParagraphPropertiesDefaultConverter
{
  /// <summary>
  ///   Paragraph Properties.
  /// </summary>
  public static ParagraphPropertiesBaseStyle? GetParagraphPropertiesBaseStyle(ParagraphPropertiesDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesBaseStyle>();
    if (itemElement != null)
      return ParagraphPropertiesBaseStyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetParagraphPropertiesBaseStyle(ParagraphPropertiesDefault? openXmlElement, ParagraphPropertiesBaseStyle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesBaseStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ParagraphPropertiesBaseStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesBaseStyle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.ParagraphPropertiesDefault? CreateModelElement(ParagraphPropertiesDefault? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ParagraphPropertiesDefault();
      value.ParagraphPropertiesBaseStyle = GetParagraphPropertiesBaseStyle(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ParagraphPropertiesDefault? value)
    where OpenXmlElementType : ParagraphPropertiesDefault, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetParagraphPropertiesBaseStyle(openXmlElement, value?.ParagraphPropertiesBaseStyle);
      return openXmlElement;
    }
    return default;
  }
}