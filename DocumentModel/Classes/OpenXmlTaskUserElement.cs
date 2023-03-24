namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the OpenXmlTaskUserElement Class.
/// </summary>
public class OpenXmlTaskUserElement: ModelElement
{
  /// <summary>
  ///   userId, this property is only available in Office 2021 and later.
  /// </summary>
  public String? UserId { get; set; }

  /// <summary>
  ///   userName, this property is only available in Office 2021 and later.
  /// </summary>
  public String? UserName { get; set; }

  /// <summary>
  ///   userProvider, this property is only available in Office 2021 and later.
  /// </summary>
  public String? UserProvider { get; set; }
}