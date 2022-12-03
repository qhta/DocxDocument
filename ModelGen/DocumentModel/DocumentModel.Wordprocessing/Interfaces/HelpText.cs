namespace DocumentModel.Wordprocessing;

/// <summary>
/// Associated Help Text.
/// </summary>
public interface HelpText // : System.Boolean
{
  /// <summary>
  /// Help Text Type
  /// </summary>
  public InfoTextKind? Type { get ; set; }
  
  /// <summary>
  /// Help Text Value
  /// </summary>
  public String? Val { get ; set; }
  
}
