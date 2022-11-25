namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Page Margins.
/// </summary>
public interface IPageMargins // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Left
  /// </summary>
  public System.Double? Left { get ; set; }
  
  /// <summary>
  /// Right
  /// </summary>
  public System.Double? Right { get ; set; }
  
  /// <summary>
  /// Top
  /// </summary>
  public System.Double? Top { get ; set; }
  
  /// <summary>
  /// Bottom
  /// </summary>
  public System.Double? Bottom { get ; set; }
  
  /// <summary>
  /// Header
  /// </summary>
  public System.Double? Header { get ; set; }
  
  /// <summary>
  /// Footer
  /// </summary>
  public System.Double? Footer { get ; set; }
  
}
