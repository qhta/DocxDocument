using DocumentFormat.OpenXml.Wordprocessing;
using PreviousParagraphMarkRunProperties = DocumentModel.Wordprocessing.PreviousParagraphMarkRunProperties;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Revision Information for Run Properties on the Paragraph Mark.
/// </summary>
public static class ParagraphMarkRunPropertiesChangeConverter
{
  /// <summary>
  ///   author
  /// </summary>
  public static String? GetAuthor(ParagraphMarkRunPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }

  public static void SetAuthor(ParagraphMarkRunPropertiesChange? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Author = new StringValue { Value = value };
      else
        openXmlElement.Author = null;
  }

  /// <summary>
  ///   date
  /// </summary>
  public static DateTime? GetDate(ParagraphMarkRunPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }

  public static void SetDate(ParagraphMarkRunPropertiesChange? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Date = value;
  }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public static String? GetId(ParagraphMarkRunPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(ParagraphMarkRunPropertiesChange? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   Previous Run Properties for the Paragraph Mark.
  /// </summary>
  public static PreviousParagraphMarkRunProperties? GetPreviousParagraphMarkRunProperties(ParagraphMarkRunPropertiesChange? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousParagraphMarkRunProperties>();
    if (itemElement != null)
      return PreviousParagraphMarkRunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPreviousParagraphMarkRunProperties(ParagraphMarkRunPropertiesChange? openXmlElement, PreviousParagraphMarkRunProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousParagraphMarkRunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PreviousParagraphMarkRunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PreviousParagraphMarkRunProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.ParagraphMarkRunPropertiesChange? CreateModelElement(ParagraphMarkRunPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ParagraphMarkRunPropertiesChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.PreviousParagraphMarkRunProperties = GetPreviousParagraphMarkRunProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ParagraphMarkRunPropertiesChange? value)
    where OpenXmlElementType : ParagraphMarkRunPropertiesChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetPreviousParagraphMarkRunProperties(openXmlElement, value?.PreviousParagraphMarkRunProperties);
      return openXmlElement;
    }
    return default;
  }
}