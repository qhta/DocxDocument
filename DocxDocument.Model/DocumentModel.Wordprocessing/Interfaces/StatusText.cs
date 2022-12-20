namespace DocumentModel.Wordprocessing;

/// <summary>
/// Associated Status Text.
/// </summary>
public partial interface StatusText
{
  /// <summary>
  /// Status Text Type
  /// </summary>
  public DocumentModel.Wordprocessing.InfoTextKind? Type { get; set; }
  
  /// <summary>
  /// Status Text Value
  /// </summary>
  public String? Val { get; set; }
  
}
