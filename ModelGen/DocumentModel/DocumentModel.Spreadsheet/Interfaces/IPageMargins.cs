namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Margins.
/// </summary>
public interface IPageMargins // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Left Page Margin
  /// </summary>
  public System.Double? Left { get ; set; }
  
  /// <summary>
  /// Right Page Margin
  /// </summary>
  public System.Double? Right { get ; set; }
  
  /// <summary>
  /// Top Page Margin
  /// </summary>
  public System.Double? Top { get ; set; }
  
  /// <summary>
  /// Bottom Page Margin
  /// </summary>
  public System.Double? Bottom { get ; set; }
  
  /// <summary>
  /// Header Page Margin
  /// </summary>
  public System.Double? Header { get ; set; }
  
  /// <summary>
  /// Footer Page Margin
  /// </summary>
  public System.Double? Footer { get ; set; }
  
}
