namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public class PrintSettings1Impl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.PrintSettings>, PrintSettings1
{
  /// <summary>
  /// Header and Footer.
  /// </summary>
  public HeaderFooter1? HeaderFooter
  {
    get;
    set;
  }
  
  /// <summary>
  /// Page Margins.
  /// </summary>
  public PageMargins1? PageMargins
  {
    get;
    set;
  }
  
  /// <summary>
  /// Page Setup.
  /// </summary>
  public PageSetup1? PageSetup
  {
    get;
    set;
  }
  
  /// <summary>
  /// Legacy Drawing for Headers and Footers.
  /// </summary>
  public Boolean? LegacyDrawingHeaderFooter
  {
    get;
    set;
  }
  
}
