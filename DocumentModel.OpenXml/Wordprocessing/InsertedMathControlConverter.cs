namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the InsertedMathControl Class.
/// </summary>
public static class InsertedMathControlConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static void SetAuthor(DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static void SetDate(DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  private static DocumentModel.Wordprocessing.RunProperties? GetRunProperties(DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunProperties(DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl openXmlElement, DocumentModel.Wordprocessing.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.RunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.DeletedMathControl? GetDeletedMathControl(DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DeletedMathControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDeletedMathControl(DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl openXmlElement, DocumentModel.Wordprocessing.DeletedMathControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.DeletedMathControlConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.InsertedMathControl? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.InsertedMathControl();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.RunProperties = GetRunProperties(openXmlElement);
      value.DeletedMathControl = GetDeletedMathControl(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.InsertedMathControl? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetRunProperties(openXmlElement, value?.RunProperties);
      SetDeletedMathControl(openXmlElement, value?.DeletedMathControl);
      return openXmlElement;
    }
    return default;
  }
}
