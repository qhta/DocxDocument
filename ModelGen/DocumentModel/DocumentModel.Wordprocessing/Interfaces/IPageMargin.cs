namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageMargin Class.
/// </summary>
public interface IPageMargin // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Top Margin Spacing
  /// </summary>
  public Int32? Top { get ; set; }
  
  /// <summary>
  /// Right Margin Spacing
  /// </summary>
  public UInt32? Right { get ; set; }
  
  /// <summary>
  /// Page Bottom Spacing
  /// </summary>
  public Int32? Bottom { get ; set; }
  
  /// <summary>
  /// Left Margin Spacing
  /// </summary>
  public UInt32? Left { get ; set; }
  
  /// <summary>
  /// Spacing to Top of Header
  /// </summary>
  public UInt32? Header { get ; set; }
  
  /// <summary>
  /// Spacing to Bottom of Footer
  /// </summary>
  public UInt32? Footer { get ; set; }
  
  /// <summary>
  /// Page Gutter Spacing
  /// </summary>
  public UInt32? Gutter { get ; set; }
  
}
