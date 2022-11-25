namespace DocumentModel.Wordprocessing;

/// <summary>
/// Freeze Document Layout.
/// </summary>
public interface IReadModeInkLockDown // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Use Actual Pages, Not Virtual Pages
  /// </summary>
  public System.Boolean? UseActualPages { get ; set; }
  
  /// <summary>
  /// Virtual Page Width
  /// </summary>
  public System.UInt32? Width { get ; set; }
  
  /// <summary>
  /// Virtual Page Height
  /// </summary>
  public System.UInt32? Height { get ; set; }
  
  /// <summary>
  /// Font Size Scaling
  /// </summary>
  public System.String? FontSize { get ; set; }
  
}
