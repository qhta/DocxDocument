using DocumentFormat.OpenXml.Wordprocessing;
using PreviousTableRowProperties = DocumentModel.Wordprocessing.PreviousTableRowProperties;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Revision Information for Table Row Properties.
/// </summary>
public static class TableRowPropertiesChangeConverter
{
  /// <summary>
  ///   author
  /// </summary>
  public static String? GetAuthor(TableRowPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }

  public static void SetAuthor(TableRowPropertiesChange? openXmlElement, String? value)
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
  public static DateTime? GetDate(TableRowPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }

  public static void SetDate(TableRowPropertiesChange? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Date = value;
  }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public static String? GetId(TableRowPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(TableRowPropertiesChange? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   Previous Table Row Properties.
  /// </summary>
  public static PreviousTableRowProperties? GetPreviousTableRowProperties(TableRowPropertiesChange? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties>();
    if (itemElement != null)
      return PreviousTableRowPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPreviousTableRowProperties(TableRowPropertiesChange? openXmlElement, PreviousTableRowProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PreviousTableRowPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.TableRowPropertiesChange? CreateModelElement(TableRowPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableRowPropertiesChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.PreviousTableRowProperties = GetPreviousTableRowProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableRowPropertiesChange? value)
    where OpenXmlElementType : TableRowPropertiesChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetPreviousTableRowProperties(openXmlElement, value?.PreviousTableRowProperties);
      return openXmlElement;
    }
    return default;
  }
}