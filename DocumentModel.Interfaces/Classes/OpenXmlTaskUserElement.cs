namespace DocumentModel;

/// <summary>
///   Defines the OpenXmlTaskUserElement Class.
/// </summary>
public interface OpenXmlTaskUserElement:
{
  /// <summary>
  ///   userId
  /// </summary>
  public string? UserId { get; set; }
  /// <summary>
  ///   userName
  /// </summary>
  public string? UserName { get; set; }
  /// <summary>
  ///   userProvider
  /// </summary>
  public string? UserProvider { get; set; }
}