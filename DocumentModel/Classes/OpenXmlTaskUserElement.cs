namespace DocumentModel;

/// <summary>
/// Defines the OpenXmlTaskUserElement Class.
/// </summary>
public partial class OpenXmlTaskUserElement
{
  /// <summary>
  /// userId, this property is only available in Office 2021 and later.
  /// </summary>
  public String? UserId { get; set; }
  
  /// <summary>
  /// userName, this property is only available in Office 2021 and later.
  /// </summary>
  public String? UserName { get; set; }
  
  /// <summary>
  /// userProvider, this property is only available in Office 2021 and later.
  /// </summary>
  public String? UserProvider { get; set; }
  
}
