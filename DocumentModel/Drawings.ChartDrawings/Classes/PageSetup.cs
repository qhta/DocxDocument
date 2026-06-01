namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the IPageSetup Class.
/// </summary>
public class IPageSetup: ModelElement
{
  /// <summary>
  ///   paperSize, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public UInt32? PaperSize { get; set; }

  /// <summary>
  ///   firstPageNumber, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public UInt32? FirstPageNumber { get; set; }

  /// <summary>
  ///   orientation, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public PageOrientation? Orientation { get; set; }

  /// <summary>
  ///   blackAndWhite, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public bool? BlackAndWhite { get; set; }

  /// <summary>
  ///   draft, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public bool? Draft { get; set; }

  /// <summary>
  ///   useFirstPageNumber, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public bool? UseFirstPageNumber { get; set; }

  /// <summary>
  ///   horizontalDpi, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public Int32? HorizontalDpi { get; set; }

  /// <summary>
  ///   verticalDpi, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public Int32? VerticalDpi { get; set; }

  /// <summary>
  ///   copies, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public UInt32? Copies { get; set; }
}
