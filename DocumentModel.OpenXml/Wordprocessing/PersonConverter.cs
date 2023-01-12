namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Person Class.
/// </summary>
public static class PersonConverter
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public static String? GetContact(DocumentFormat.OpenXml.Office2013.Word.Person? openXmlElement)
  {
    return openXmlElement?.Contact?.Value;
  }
  
  public static void SetContact(DocumentFormat.OpenXml.Office2013.Word.Person? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Contact = new StringValue { Value = value };
      else
        openXmlElement.Contact = null;
  }
  
  /// <summary>
  /// author, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetAuthor(DocumentFormat.OpenXml.Office2013.Word.Person? openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  public static void SetAuthor(DocumentFormat.OpenXml.Office2013.Word.Person? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Author = new StringValue { Value = value };
      else
        openXmlElement.Author = null;
  }
  
  /// <summary>
  /// PresenceInfo.
  /// </summary>
  public static DocumentModel.Wordprocessing.PresenceInfo? GetPresenceInfo(DocumentFormat.OpenXml.Office2013.Word.Person? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.PresenceInfo>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PresenceInfoConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPresenceInfo(DocumentFormat.OpenXml.Office2013.Word.Person? openXmlElement, DocumentModel.Wordprocessing.PresenceInfo? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.PresenceInfo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.PresenceInfoConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Word.PresenceInfo>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Person? CreateModelElement(DocumentFormat.OpenXml.Office2013.Word.Person? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Person();
      value.Contact = GetContact(openXmlElement);
      value.Author = GetAuthor(openXmlElement);
      value.PresenceInfo = GetPresenceInfo(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Person? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Word.Person, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetContact(openXmlElement, value?.Contact);
      SetAuthor(openXmlElement, value?.Author);
      SetPresenceInfo(openXmlElement, value?.PresenceInfo);
      return openXmlElement;
    }
    return default;
  }
}
