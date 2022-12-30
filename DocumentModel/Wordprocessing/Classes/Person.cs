namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Person Class.
/// </summary>
public partial class Person
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public String? Contact { get; set; }
  
  /// <summary>
  /// author, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Author { get; set; }
  
  /// <summary>
  /// PresenceInfo.
  /// </summary>
  public DocumentModel.Wordprocessing.PresenceInfo? PresenceInfo { get; set; }
  
}
