namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Person Class.
/// </summary>
public class Person: ModelElement
{
  /// <summary>
  ///   Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public string? Contact { get; set; }

  /// <summary>
  ///   author, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Author { get; set; }

  /// <summary>
  ///   PresenceInfo.
  /// </summary>
  public PresenceInfo? PresenceInfo { get; set; }
}