namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the PrintSettings Class.
/// </summary>
public class PrintSettings: ModelElement
{
  /// <summary>
  ///   Header and Footer.
  /// </summary>
  public HeaderFooter? HeaderFooter { get; set; }
  /// <summary>
  ///   Page Margins.
  /// </summary>
  public PageMargins? PageMargins { get; set; }
  /// <summary>
  ///   Page Setup.
  /// </summary>
  public PageSetup? PageSetup { get; set; }
  /// <summary>
  ///   Legacy Drawing for Headers and Footers.
  /// </summary>
  public RelationshipIdType? LegacyDrawingHeaderFooter { get; set; }
}