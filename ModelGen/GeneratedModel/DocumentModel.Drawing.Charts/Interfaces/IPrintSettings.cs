namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IHeaderFooter))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPageMargins))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPageSetup))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILegacyDrawingHeaderFooter))]
public interface IPrintSettings // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  public DocumentModel.Drawing.Charts.ILegacyDrawingHeaderFooter? LegacyDrawingHeaderFooter { get ; set; }
  
}
