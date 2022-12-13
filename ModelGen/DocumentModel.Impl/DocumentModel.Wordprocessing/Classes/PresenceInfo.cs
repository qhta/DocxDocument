namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PresenceInfo Class.
/// </summary>
public class PresenceInfoImpl: ModelElementImpl, PresenceInfo
{
  public DocumentFormat.OpenXml.Office2013.Word.PresenceInfo? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Word.PresenceInfo?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PresenceInfoImpl(): base() {}
  
  public PresenceInfoImpl(DocumentFormat.OpenXml.Office2013.Word.PresenceInfo openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// providerId, this property is only available in Office 2013 and later.
  /// </summary>
  public String? ProviderId
  {
    get => (System.String?)OpenXmlElement?.ProviderId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ProviderId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// userId, this property is only available in Office 2013 and later.
  /// </summary>
  public String? UserId
  {
    get => (System.String?)OpenXmlElement?.UserId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UserId = (System.String?)value;
    }
  }
  
}
