namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public class PrintSettingsImpl: ModelElementImpl, PrintSettings
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PrintSettingsImpl(): base() {}
  
  public PrintSettingsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public DocumentModel.Drawings16.Charts.HeaderFooter? HeaderFooter
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PageMargins.
  /// </summary>
  public DocumentModel.Drawings16.Charts.PageMargins? PageMargins
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PageSetup.
  /// </summary>
  public DocumentModel.Drawings16.Charts.PageSetup? PageSetup
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
