namespace DocumentModel.Spreadsheet;

/// <summary>
/// Tuple.
/// </summary>
public interface Tuple // : System.Boolean
{
  /// <summary>
  /// Field Index
  /// </summary>
  public UInt32? Field { get ; set; }
  
  /// <summary>
  /// Hierarchy Index
  /// </summary>
  public UInt32? Hierarchy { get ; set; }
  
  /// <summary>
  /// Item Index
  /// </summary>
  public UInt32? Item { get ; set; }
  
}
