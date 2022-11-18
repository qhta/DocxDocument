namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the PageSetup Class.
/// </summary>
public interface IPageSetup // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// paperSize, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? PaperSize { get ; set; }
  
  /// <summary>
  /// firstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? FirstPageNumber { get ; set; }
  
  /// <summary>
  /// orientation, this property is only available in Office 2016 and later.
  /// </summary>
  public PageOrientation? Orientation { get ; set; }
  
  /// <summary>
  /// blackAndWhite, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? BlackAndWhite { get ; set; }
  
  /// <summary>
  /// draft, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Draft { get ; set; }
  
  /// <summary>
  /// useFirstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? UseFirstPageNumber { get ; set; }
  
  /// <summary>
  /// horizontalDpi, this property is only available in Office 2016 and later.
  /// </summary>
  public int? HorizontalDpi { get ; set; }
  
  /// <summary>
  /// verticalDpi, this property is only available in Office 2016 and later.
  /// </summary>
  public int? VerticalDpi { get ; set; }
  
  /// <summary>
  /// copies, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? Copies { get ; set; }
  
}
