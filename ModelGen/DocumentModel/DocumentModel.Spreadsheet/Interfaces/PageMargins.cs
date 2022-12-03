namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Margins.
/// </summary>
public interface PageMargins // : System.Boolean
{
  /// <summary>
  /// Left Page Margin
  /// </summary>
  public Double? Left { get ; set; }
  
  /// <summary>
  /// Right Page Margin
  /// </summary>
  public Double? Right { get ; set; }
  
  /// <summary>
  /// Top Page Margin
  /// </summary>
  public Double? Top { get ; set; }
  
  /// <summary>
  /// Bottom Page Margin
  /// </summary>
  public Double? Bottom { get ; set; }
  
  /// <summary>
  /// Header Page Margin
  /// </summary>
  public Double? Header { get ; set; }
  
  /// <summary>
  /// Footer Page Margin
  /// </summary>
  public Double? Footer { get ; set; }
  
}
