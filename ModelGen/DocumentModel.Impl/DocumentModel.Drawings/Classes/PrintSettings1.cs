namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public class PrintSettings1Impl: ModelElementImpl, PrintSettings1
{
  public DocumentFormat.OpenXml.Drawing.Charts.PrintSettings? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PrintSettings?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  public PageMargins2? PageMargins
  {
    get;
    set;
  }
  
  /// <summary>
  /// Page Setup.
  /// </summary>
  public PageSetup2? PageSetup
  {
    get;
    set;
  }
  
  /// <summary>
  /// Legacy Drawing for Headers and Footers.
  /// </summary>
  public RelationshipIdType? LegacyDrawingHeaderFooter
  {
    get;
    set;
  }
  
}
