namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public interface IPrintSettings // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Header and Footer.
  /// </summary>
  public IHeaderFooter? HeaderFooter { get ; set; }
  
  /// <summary>
  /// Page Margins.
  /// </summary>
  public IPageMargins? PageMargins { get ; set; }
  
  /// <summary>
  /// Page Setup.
  /// </summary>
  public IPageSetup? PageSetup { get ; set; }
  
  /// <summary>
  /// Legacy Drawing for Headers and Footers.
  /// </summary>
  public ILegacyDrawingHeaderFooter? LegacyDrawingHeaderFooter { get ; set; }
  
}
