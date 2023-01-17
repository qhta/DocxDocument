namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Revision Information for Table Properties.
/// </summary>
public static class TablePropertiesChangeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DocumentFormat.OpenXml.Wordprocessing.TablePropertiesChange openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static void SetAuthor(DocumentFormat.OpenXml.Wordprocessing.TablePropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DocumentFormat.OpenXml.Wordprocessing.TablePropertiesChange openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static void SetDate(DocumentFormat.OpenXml.Wordprocessing.TablePropertiesChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Wordprocessing.TablePropertiesChange openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.TablePropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Previous Table Properties.
  /// </summary>
  private static DocumentModel.Wordprocessing.PreviousTableProperties? GetPreviousTableProperties(DocumentFormat.OpenXml.Wordprocessing.TablePropertiesChange openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousTableProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PreviousTablePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPreviousTableProperties(DocumentFormat.OpenXml.Wordprocessing.TablePropertiesChange openXmlElement, DocumentModel.Wordprocessing.PreviousTableProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousTableProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.PreviousTablePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PreviousTableProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.TablePropertiesChange? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.TablePropertiesChange? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.TablePropertiesChange, new()
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
