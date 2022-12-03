namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Person Class.
/// </summary>
public interface Person // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  [Obsolete("This property will not persist to the document and will be removed in a future version")]
  public String? Contact { get ; set; }
  
  /// <summary>
  /// author, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Author { get ; set; }
  
  /// <summary>
  /// PresenceInfo.
  /// </summary>
  public PresenceInfo? PresenceInfo { get ; set; }
  
}
