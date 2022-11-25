namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public interface IPrintSettings // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Header and Footer.
  /// </summary>
  public DocumentModel.Drawing.Charts.IHeaderFooter? HeaderFooter { get ; set; }
  
  /// <summary>
  /// Page Margins.
  /// </summary>
  public DocumentModel.Drawing.Charts.IPageMargins? PageMargins { get ; set; }
  
  /// <summary>
  /// Page Setup.
  /// </summary>
  public DocumentModel.Drawing.Charts.IPageSetup? PageSetup { get ; set; }
  
  /// <summary>
  /// Legacy Drawing for Headers and Footers.
  /// </summary>
  public DocumentModel.Drawing.Charts.IRelationshipIdType? LegacyDrawingHeaderFooter { get ; set; }
  
}
