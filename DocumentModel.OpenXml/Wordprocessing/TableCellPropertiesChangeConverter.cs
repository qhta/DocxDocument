namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Revision Information for Table Cell Properties.
/// </summary>
public static class TableCellPropertiesChangeConverter
{
  /// <summary>
  /// author
  /// </summary>
  public static String? GetAuthor(DocumentFormat.OpenXml.Wordprocessing.TableCellPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  public static void SetAuthor(DocumentFormat.OpenXml.Wordprocessing.TableCellPropertiesChange? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Author = new StringValue { Value = value };
      else
        openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  public static DateTime? GetDate(DocumentFormat.OpenXml.Wordprocessing.TableCellPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  public static void SetDate(DocumentFormat.OpenXml.Wordprocessing.TableCellPropertiesChange? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Wordprocessing.TableCellPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.TableCellPropertiesChange? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Previous Table Cell Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.PreviousTableCellProperties? GetPreviousTableCellProperties(DocumentFormat.OpenXml.Wordprocessing.TableCellPropertiesChange? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousTableCellProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PreviousTableCellPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPreviousTableCellProperties(DocumentFormat.OpenXml.Wordprocessing.TableCellPropertiesChange? openXmlElement, DocumentModel.Wordprocessing.PreviousTableCellProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousTableCellProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.PreviousTableCellPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PreviousTableCellProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.TableCellPropertiesChange? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.TableCellPropertiesChange? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.TableCellPropertiesChange, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
