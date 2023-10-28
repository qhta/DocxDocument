namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the PrintSettings Class.
/// </summary>
public partial class PrintSettings
{
  
  /// <summary>
  ///   Header and Footer.
  /// </summary>
  public DMDC.HeaderFooter? HeaderFooter { get; set; }
  
  
  /// <summary>
  ///   Page Margins.
  /// </summary>
  public DMDC.PageMargins? PageMargins { get; set; }
  
  
  /// <summary>
  ///   Page Setup.
  /// </summary>
  public DMDC.PageSetup? PageSetup { get; set; }
  
  
  /// <summary>
  ///   Legacy Drawing for Headers and Footers.
  /// </summary>
  public DMDC.LegacyDrawingHeaderFooter? LegacyDrawingHeaderFooter { get; set; }
  
}
