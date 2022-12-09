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
  public HeaderFooter2? HeaderFooter
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Page Margins.
  /// </summary>
  public PageMargins1? PageMargins
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Page Setup.
  /// </summary>
  public PageSetup2? PageSetup
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Legacy Drawing for Headers and Footers.
  /// </summary>
  public RelationshipIdType? LegacyDrawingHeaderFooter
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
