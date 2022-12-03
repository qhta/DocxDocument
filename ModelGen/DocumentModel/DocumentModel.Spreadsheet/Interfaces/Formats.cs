namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Formats Class.
/// </summary>
public interface Formats // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Formats Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<Format>? Formats { get ; set; }
  
}
