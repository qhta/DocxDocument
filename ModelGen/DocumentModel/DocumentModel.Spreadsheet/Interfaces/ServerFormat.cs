namespace DocumentModel.Spreadsheet;

/// <summary>
/// Server Format.
/// </summary>
public interface ServerFormat // : System.Boolean
{
  /// <summary>
  /// Culture
  /// </summary>
  public String? Culture { get ; set; }
  
  /// <summary>
  /// Format
  /// </summary>
  public String? Format { get ; set; }
  
}
