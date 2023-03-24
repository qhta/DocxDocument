namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Freeze Document Layout.
/// </summary>
public class ReadModeInkLockDown: ModelElement
{
  /// <summary>
  ///   Use Actual Pages, Not Virtual Pages
  /// </summary>
  public Boolean? UseActualPages { get; set; }

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
  public String? FontSize { get; set; }
}