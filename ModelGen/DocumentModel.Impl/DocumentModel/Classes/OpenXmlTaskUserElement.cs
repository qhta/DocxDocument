namespace DocumentModel;

/// <summary>
/// Defines the OpenXmlTaskUserElement Class.
/// </summary>
public class OpenXmlTaskUserElementImpl: ModelElementImpl, OpenXmlTaskUserElement
{
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.OpenXmlTaskUserElement? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.OpenXmlTaskUserElement?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// userId, this property is only available in Office 2021 and later.
  /// </summary>
  public String? UserId
  {
    get;
    set;
  }
  
  /// <summary>
  /// userName, this property is only available in Office 2021 and later.
  /// </summary>
  public String? UserName
  {
    get;
    set;
  }
  
  /// <summary>
  /// userProvider, this property is only available in Office 2021 and later.
  /// </summary>
  public String? UserProvider
  {
    get;
    set;
  }
  
}
