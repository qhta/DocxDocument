namespace DocumentModel.Spreadsheet;

/// <summary>
/// Server Formats.
/// </summary>
public interface ServerFormats // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Format Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<ServerFormat>? ServerFormats { get ; set; }
  
}
