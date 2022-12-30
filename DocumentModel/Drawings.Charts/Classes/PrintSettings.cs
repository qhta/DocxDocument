namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public partial class PrintSettings
{
  /// <summary>
  /// Header and Footer.
  /// </summary>
  public DocumentModel.Drawings.Charts.HeaderFooter? HeaderFooter { get; set; }
  
  /// <summary>
  /// Page Margins.
  /// </summary>
  public DocumentModel.Drawings.Charts.PageMargins? PageMargins { get; set; }
  
  /// <summary>
  /// Page Setup.
  /// </summary>
  public DocumentModel.Drawings.Charts.PageSetup? PageSetup { get; set; }
  
  /// <summary>
  /// Legacy Drawing for Headers and Footers.
  /// </summary>
  public DocumentModel.Drawings.Charts.RelationshipIdType? LegacyDrawingHeaderFooter { get; set; }
  
}
