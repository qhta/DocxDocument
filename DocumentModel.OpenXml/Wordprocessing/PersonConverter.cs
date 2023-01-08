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
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetContact(DocumentFormat.OpenXml.Office2013.Word.Person? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// author, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetAuthor(DocumentFormat.OpenXml.Office2013.Word.Person? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetAuthor(DocumentFormat.OpenXml.Office2013.Word.Person? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// PresenceInfo.
  /// </summary>
  public static DocumentModel.Wordprocessing.PresenceInfo? GetPresenceInfo(DocumentFormat.OpenXml.Office2013.Word.Person? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPresenceInfo(DocumentFormat.OpenXml.Office2013.Word.Person? openXmlElement, DocumentModel.Wordprocessing.PresenceInfo? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
