namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Page Setup.
/// </summary>
public class PageSetup: ModelElement
{
  /// <summary>
  ///   Page Size
  /// </summary>
  public UInt32? PaperSize { get; set; }

  /// <summary>
  ///   First Page Number
  /// </summary>
  public Int32? FirstPageNumber { get; set; }

  /// <summary>
  ///   Orientation
  /// </summary>
  public PageSetupOrientationKind? Orientation { get; set; }

  /// <summary>
  ///   Black and White
  /// </summary>
  public Boolean? BlackAndWhite { get; set; }

  /// <summary>
  ///   Draft
  /// </summary>
  public Boolean? Draft { get; set; }

  /// <summary>
  ///   Use First Page Number
  /// </summary>
  public Boolean? UseFirstPageNumber { get; set; }

  /// <summary>
  ///   Horizontal DPI
  /// </summary>
  public Int32? HorizontalDpi { get; set; }

  /// <summary>
  ///   Vertical DPI
  /// </summary>
  public Int32? VerticalDpi { get; set; }

  /// <summary>
  ///   Copies
  /// </summary>
  public UInt32? Copies { get; set; }
}