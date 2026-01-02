namespace DocumentModel.Wordprocessing;

/// <summary>
///   Freeze Document Layout.
/// </summary>
public interface IReadModeInkLockDown: IModelElement
{
  /// <summary>
  ///   Use Actual Pages, Not Virtual Pages
  /// </summary>
  public bool? UseActualPages { get; set; }
  /// <summary>
  ///   Virtual Page Width
  /// </summary>
  public UInt32? Width { get; set; }
  /// <summary>
  ///   Virtual Page Height
  /// </summary>
  public UInt32? Height { get; set; }
  /// <summary>
  ///   Font Size Scaling
  /// </summary>
  public string? FontSize { get; set; }
}