namespace DocumentModel.Wordprocessing;

/// <summary>
/// Freeze Document Layout.
/// </summary>
public interface IReadModeInkLockDown // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Use Actual Pages, Not Virtual Pages
  /// </summary>
  public bool? UseActualPages { get ; set; }
  
  /// <summary>
  /// Virtual Page Width
  /// </summary>
  public uint? Width { get ; set; }
  
  /// <summary>
  /// Virtual Page Height
  /// </summary>
  public uint? Height { get ; set; }
  
  /// <summary>
  /// Font Size Scaling
  /// </summary>
  public string? FontSize { get ; set; }
  
}
