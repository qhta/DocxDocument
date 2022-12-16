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
    get => (System.String?)OpenXmlElement?.Contact?.Value;
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
    get => (System.String?)OpenXmlElement?.Author?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Author = (System.String?)value;
    }
  }
  
  /// <summary>
  /// PresenceInfo.
  /// </summary>
  public DocumentModel.Wordprocessing.PresenceInfo? PresenceInfo
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.PresenceInfo>();
        if (item != null)
          return new DocumentModel.Wordprocessing.PresenceInfoImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.PresenceInfo>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.PresenceInfoImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
