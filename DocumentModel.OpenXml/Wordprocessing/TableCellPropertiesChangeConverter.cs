using DocumentFormat.OpenXml.Wordprocessing;
using PreviousTableCellProperties = DocumentModel.Wordprocessing.PreviousTableCellProperties;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Revision Information for Table Cell Properties.
/// </summary>
public static class TableCellPropertiesChangeConverter
{
  /// <summary>
  ///   author
  /// </summary>
  public static String? GetAuthor(TableCellPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }

  public static void SetAuthor(TableCellPropertiesChange? openXmlElement, String? value)
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
  public static DateTime? GetDate(TableCellPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }

  public static void SetDate(TableCellPropertiesChange? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Date = value;
  }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public static String? GetId(TableCellPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(TableCellPropertiesChange? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   Previous Table Cell Properties.
  /// </summary>
  public static PreviousTableCellProperties? GetPreviousTableCellProperties(TableCellPropertiesChange? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousTableCellProperties>();
    if (itemElement != null)
      return PreviousTableCellPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPreviousTableCellProperties(TableCellPropertiesChange? openXmlElement, PreviousTableCellProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousTableCellProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PreviousTableCellPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PreviousTableCellProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.TableCellPropertiesChange? CreateModelElement(TableCellPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableCellPropertiesChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.PreviousTableCellProperties = GetPreviousTableCellProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableCellPropertiesChange? value)
    where OpenXmlElementType : TableCellPropertiesChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetPreviousTableCellProperties(openXmlElement, value?.PreviousTableCellProperties);
      return openXmlElement;
    }
    return default;
  }
}