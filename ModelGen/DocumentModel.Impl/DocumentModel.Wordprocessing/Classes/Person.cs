namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Person Class.
/// </summary>
public class PersonImpl: ModelElementImpl, Person
{
  public DocumentFormat.OpenXml.Office2013.Word.Person? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Word.Person?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PersonImpl(): base() {}
  
  public PersonImpl(DocumentFormat.OpenXml.Office2013.Word.Person openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public String? Contact
  {
    get => (String?)OpenXmlElement?.Contact?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Contact = (System.String?)value;
    }
  }
  
  /// <summary>
  /// author, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Author
  {
    get => (String?)OpenXmlElement?.Author?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Author = (System.String?)value;
    }
  }
  
  /// <summary>
  /// PresenceInfo.
  /// </summary>
  public PresenceInfo? PresenceInfo
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
