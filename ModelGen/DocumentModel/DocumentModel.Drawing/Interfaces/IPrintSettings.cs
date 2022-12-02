namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public interface IPrintSettings // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public IHeaderFooter? HeaderFooter { get ; set; }
  
  /// <summary>
  /// PageMargins.
  /// </summary>
  public IPageMargins? PageMargins { get ; set; }
  
  /// <summary>
  /// PageSetup.
  /// </summary>
  public IPageSetup? PageSetup { get ; set; }
  
}
