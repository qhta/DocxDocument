namespace DocumentModel.Office2019.Excel.ThreadedComments;

/// <summary>
/// Defines the Person Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.ThreadedComments.IExtensionList))]
public class Person: IPerson
{
  /// <summary>
  /// displayName, this property is only available in Office 2019 and later.
  /// </summary>
  public string? DisplayName
  {
    get;
    set;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// userId, this property is only available in Office 2019 and later.
  /// </summary>
  public string? UserId
  {
    get;
    set;
  }
  
  /// <summary>
  /// providerId, this property is only available in Office 2019 and later.
  /// </summary>
  public string? ProviderId
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2019.Excel.ThreadedComments.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
