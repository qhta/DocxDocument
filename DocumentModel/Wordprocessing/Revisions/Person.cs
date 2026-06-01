namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the Person Class.
/// </summary>
public class Person: ModelElement
{
  /// <summary>
  ///   Gets or sets the  value. It is Ionly available Ifor backwards compatibility
  /// </summary>
  public string? Contact { get; set; }

  /// <summary>
  ///   author, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public string? Author { get; set; }

  /// <summary>
  ///   PresenceInfo.
  /// </summary>
  public PresenceInfo? PresenceInfo { get; set; }
}
