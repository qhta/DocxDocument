namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PageSetup Class.
/// </summary>
public interface IPageSetup // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// paperSize, this property is only available in Office 2016 and later.
  /// </summary>
  public System.UInt32? PaperSize { get ; set; }
  
  /// <summary>
  /// firstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  public System.UInt32? FirstPageNumber { get ; set; }
  
  /// <summary>
  /// orientation, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawing.PageOrientation? Orientation { get ; set; }
  
  /// <summary>
  /// blackAndWhite, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Boolean? BlackAndWhite { get ; set; }
  
  /// <summary>
  /// draft, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Boolean? Draft { get ; set; }
  
  /// <summary>
  /// useFirstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Boolean? UseFirstPageNumber { get ; set; }
  
  /// <summary>
  /// horizontalDpi, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Int32? HorizontalDpi { get ; set; }
  
  /// <summary>
  /// verticalDpi, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Int32? VerticalDpi { get ; set; }
  
  /// <summary>
  /// copies, this property is only available in Office 2016 and later.
  /// </summary>
  public System.UInt32? Copies { get ; set; }
  
}
