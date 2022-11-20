namespace DocumentModel.Spreadsheet;

/// <summary>
/// Tuple.
/// </summary>
public class Tuple: ITuple
{
  /// <summary>
  /// Field Index
  /// </summary>
  public uint? Field
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hierarchy Index
  /// </summary>
  public uint? Hierarchy
  {
    get;
    set;
  }
  
  /// <summary>
  /// Item Index
  /// </summary>
  public uint? Item
  {
    get;
    set;
  }
  
}
