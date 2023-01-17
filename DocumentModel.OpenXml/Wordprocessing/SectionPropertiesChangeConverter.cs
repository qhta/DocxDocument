namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Revision Information for Section Properties.
/// </summary>
public static class SectionPropertiesChangeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static void SetAuthor(DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static void SetDate(DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Previous Section Properties.
  /// </summary>
  private static DocumentModel.Wordprocessing.PreviousSectionProperties? GetPreviousSectionProperties(DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousSectionProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PreviousSectionPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPreviousSectionProperties(DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange openXmlElement, DocumentModel.Wordprocessing.PreviousSectionProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousSectionProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.PreviousSectionPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PreviousSectionProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.SectionPropertiesChange? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SectionPropertiesChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.PreviousSectionProperties = GetPreviousSectionProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SectionPropertiesChange? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.SectionPropertiesChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetPreviousSectionProperties(openXmlElement, value?.PreviousSectionProperties);
      return openXmlElement;
    }
    return default;
  }
}
