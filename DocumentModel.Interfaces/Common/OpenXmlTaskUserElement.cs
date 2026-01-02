namespace DocumentModel;

/// <summary>
///   Defines the OpenXmlTaskUserElement Class.
/// </summary>
public class OpenXmlTaskUserElement: ModelElement
{
  /// <summary>
  ///   userId, this property is only available in Office 2021 and later.
  /// </summary>
  public string? UserId { get; set; }
  /// <summary>
  ///   userName, this property is only available in Office 2021 and later.
  /// </summary>
  public string? UserName { get; set; }
  /// <summary>
  ///   userProvider, this property is only available in Office 2021 and later.
  /// </summary>
  public string? UserProvider { get; set; }
}