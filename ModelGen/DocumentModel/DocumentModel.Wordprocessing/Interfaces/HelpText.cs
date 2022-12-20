namespace DocumentModel.Wordprocessing;

/// <summary>
/// Associated Help Text.
/// </summary>
public partial interface HelpText
{
  /// <summary>
  /// Help Text Type
  /// </summary>
  public DocumentModel.Wordprocessing.InfoTextKind? Type { get; set; }
  
  /// <summary>
  /// Help Text Value
  /// </summary>
  public String? Val { get; set; }
  
}
