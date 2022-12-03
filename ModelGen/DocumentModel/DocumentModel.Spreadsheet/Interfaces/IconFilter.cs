namespace DocumentModel.Spreadsheet;

/// <summary>
/// Icon Filter.
/// </summary>
public interface IconFilter // : System.Boolean
{
  /// <summary>
  /// Icon Set
  /// </summary>
  public IconSetKind? IconSet { get ; set; }
  
  /// <summary>
  /// Icon Id
  /// </summary>
  public UInt32? IconId { get ; set; }
  
}
