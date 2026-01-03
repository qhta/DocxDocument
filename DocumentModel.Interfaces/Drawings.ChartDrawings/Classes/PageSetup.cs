namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the PageSetup Class.
/// </summary>
public interface PageSetup: IModelElement
{
  /// <summary>
  ///   paperSize
  /// </summary>
  public UInt32? PaperSize { get; set; }
  /// <summary>
  ///   firstPageNumber
  /// </summary>
  public UInt32? FirstPageNumber { get; set; }
  /// <summary>
  ///   orientation
  /// </summary>
  public PageOrientation? Orientation { get; set; }
  /// <summary>
  ///   blackAndWhite
  /// </summary>
  public bool? BlackAndWhite { get; set; }
  /// <summary>
  ///   draft
  /// </summary>
  public bool? Draft { get; set; }
  /// <summary>
  ///   useFirstPageNumber
  /// </summary>
  public bool? UseFirstPageNumber { get; set; }
  /// <summary>
  ///   horizontalDpi
  /// </summary>
  public Int32? HorizontalDpi { get; set; }
  /// <summary>
  ///   verticalDpi
  /// </summary>
  public Int32? VerticalDpi { get; set; }
  /// <summary>
  ///   copies
  /// </summary>
  public UInt32? Copies { get; set; }
}