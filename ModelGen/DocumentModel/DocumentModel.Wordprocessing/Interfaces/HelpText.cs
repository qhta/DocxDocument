namespace DocumentModel.Wordprocessing;

/// <summary>
/// Associated Help Text.
/// </summary>
public interface HelpText
{
  /// <summary>
  /// Help Text Type
  /// </summary>
  public DocumentModel.Wordprocessing.InfoTextKind? Type { get ; set; }
  
  /// <summary>
  /// Help Text Value
  /// </summary>
  public String? Val { get ; set; }
  
}
