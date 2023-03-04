namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the PageSetup Class.
/// </summary>
public class PageSetup
{
  /// <summary>
  ///   paperSize, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? PaperSize { get; set; }

  /// <summary>
  ///   firstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? FirstPageNumber { get; set; }

  /// <summary>
  ///   orientation, this property is only available in Office 2016 and later.
  /// </summary>
  public PageOrientation? Orientation { get; set; }

  /// <summary>
  ///   blackAndWhite, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? BlackAndWhite { get; set; }

  /// <summary>
  ///   draft, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Draft { get; set; }

  /// <summary>
  ///   useFirstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? UseFirstPageNumber { get; set; }

  /// <summary>
  ///   horizontalDpi, this property is only available in Office 2016 and later.
  /// </summary>
  public Int32? HorizontalDpi { get; set; }

  /// <summary>
  ///   verticalDpi, this property is only available in Office 2016 and later.
  /// </summary>
  public Int32? VerticalDpi { get; set; }

  /// <summary>
  ///   copies, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Copies { get; set; }
}