namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public interface IPrintSettings // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public DocumentModel.Drawing.IHeaderFooter? HeaderFooter { get ; set; }
  
  /// <summary>
  /// PageMargins.
  /// </summary>
  public DocumentModel.Drawing.IPageMargins? PageMargins { get ; set; }
  
  /// <summary>
  /// PageSetup.
  /// </summary>
  public DocumentModel.Drawing.IPageSetup? PageSetup { get ; set; }
  
}
