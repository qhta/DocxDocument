namespace DocumentModel;

/// <summary>
/// Defines the OpenXmlTaskUserElement Class.
/// </summary>
public interface IOpenXmlTaskUserElement // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// userId, this property is only available in Office 2021 and later.
  /// </summary>
  public System.String? UserId { get ; set; }
  
  /// <summary>
  /// userName, this property is only available in Office 2021 and later.
  /// </summary>
  public System.String? UserName { get ; set; }
  
  /// <summary>
  /// userProvider, this property is only available in Office 2021 and later.
  /// </summary>
  public System.String? UserProvider { get ; set; }
  
}
