using DocumentFormat.OpenXml.Wordprocessing;
using PreviousTableProperties = DocumentModel.Wordprocessing.PreviousTableProperties;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Revision Information for Table Properties.
/// </summary>
public static class TablePropertiesChangeConverter
{
  /// <summary>
  ///   author
  /// </summary>
  public static String? GetAuthor(TablePropertiesChange? openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }

  public static void SetAuthor(TablePropertiesChange? openXmlElement, String? value)
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
  public static DateTime? GetDate(TablePropertiesChange? openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }

  public static void SetDate(TablePropertiesChange? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Date = value;
  }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public static String? GetId(TablePropertiesChange? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(TablePropertiesChange? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   Previous Table Properties.
  /// </summary>
  public static PreviousTableProperties? GetPreviousTableProperties(TablePropertiesChange? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousTableProperties>();
    if (itemElement != null)
      return PreviousTablePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPreviousTableProperties(TablePropertiesChange? openXmlElement, PreviousTableProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousTableProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PreviousTablePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PreviousTableProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.TablePropertiesChange? CreateModelElement(TablePropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TablePropertiesChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.PreviousTableProperties = GetPreviousTableProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TablePropertiesChange? value)
    where OpenXmlElementType : TablePropertiesChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetPreviousTableProperties(openXmlElement, value?.PreviousTableProperties);
      return openXmlElement;
    }
    return default;
  }
}