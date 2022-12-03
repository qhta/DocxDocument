namespace DocumentModel.Spreadsheet;

/// <summary>
/// Number Formats.
/// </summary>
public interface NumberingFormat // : System.Boolean
{
  /// <summary>
  /// Number Format Id
  /// </summary>
  public UInt32? NumberFormatId { get ; set; }
  
  /// <summary>
  /// Number Format Code
  /// </summary>
  public String? FormatCode { get ; set; }
  
}
