namespace DocumentModel;

/// <summary>
/// Defines the OpenXmlTaskUserElement Class.
/// </summary>
public partial class OpenXmlTaskUserElementImpl: ModelElementImpl, OpenXmlTaskUserElement
{
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.OpenXmlTaskUserElement? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.OpenXmlTaskUserElement?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public OpenXmlTaskUserElementImpl(): base() {}
  
  public OpenXmlTaskUserElementImpl(DocumentFormat.OpenXml.Office2021.DocumentTasks.OpenXmlTaskUserElement openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// userId, this property is only available in Office 2021 and later.
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
  
  /// <summary>
  /// userName, this property is only available in Office 2021 and later.
  /// </summary>
  public String? UserName
  {
    get => (System.String?)OpenXmlElement?.UserName?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UserName = (System.String?)value;
    }
  }
  
  /// <summary>
  /// userProvider, this property is only available in Office 2021 and later.
  /// </summary>
  public String? UserProvider
  {
    get => (System.String?)OpenXmlElement?.UserProvider?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UserProvider = (System.String?)value;
    }
  }
  
}
