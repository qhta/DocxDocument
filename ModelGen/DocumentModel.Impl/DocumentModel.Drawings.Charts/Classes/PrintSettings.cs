namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public class PrintSettingsImpl: ModelElementImpl, PrintSettings
{
  public DocumentFormat.OpenXml.Drawing.Charts.PrintSettings? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PrintSettings?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PrintSettingsImpl(): base() {}
  
  public PrintSettingsImpl(DocumentFormat.OpenXml.Drawing.Charts.PrintSettings openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Header and Footer.
  /// </summary>
  public DocumentModel.Drawings.Charts.HeaderFooter? HeaderFooter
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Page Margins.
  /// </summary>
  public DocumentModel.Drawings.Charts.PageMargins? PageMargins
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Page Setup.
  /// </summary>
  public DocumentModel.Drawings.Charts.PageSetup? PageSetup
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Legacy Drawing for Headers and Footers.
  /// </summary>
  public DocumentModel.Drawings.Charts.RelationshipIdType? LegacyDrawingHeaderFooter
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
