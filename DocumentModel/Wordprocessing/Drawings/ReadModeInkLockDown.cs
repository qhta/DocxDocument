namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Freeze IDocument Layout.
/// </summary>
public class ReadModeInkLockDown: ModelElement
{
  /// <summary>
  ///   Use Actual IPages, Not Virtual IPages
  /// </summary>
  public bool? UseActualPages { get; set; }

  /// <summary>
  ///   Virtual IPage Width
  /// </summary>
  public UInt32? Width { get; set; }

  /// <summary>
  ///   Virtual IPage Height
  /// </summary>
  public UInt32? Height { get; set; }

  /// <summary>
  ///   IFont Size Scaling
  /// </summary>
  public string? FontSize { get; set; }
}
