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
  
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public String? Contact
  {
    get;
    set;
  }
  
  /// <summary>
  /// author, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Author
  {
    get;
    set;
  }
  
  /// <summary>
  /// PresenceInfo.
  /// </summary>
  public PresenceInfo? PresenceInfo
  {
    get;
    set;
  }
  
}
