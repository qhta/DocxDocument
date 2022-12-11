namespace DocumentModel.Drawings;

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
  public HeaderFooter? HeaderFooter
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PageMargins.
  /// </summary>
  public PageMargins? PageMargins
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PageSetup.
  /// </summary>
  public PageSetup? PageSetup
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
