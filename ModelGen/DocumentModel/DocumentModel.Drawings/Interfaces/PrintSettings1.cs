namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public interface PrintSettings1
{
  /// <summary>
  /// Header and Footer.
  /// </summary>
  public HeaderFooter2? HeaderFooter { get ; set; }
  
  /// <summary>
  /// Page Margins.
  /// </summary>
  public PageMargins1? PageMargins { get ; set; }
  
  /// <summary>
  /// Page Setup.
  /// </summary>
  public PageSetup2? PageSetup { get ; set; }
  
  /// <summary>
  /// Legacy Drawing for Headers and Footers.
  /// </summary>
  public RelationshipIdType? LegacyDrawingHeaderFooter { get ; set; }
  
}
