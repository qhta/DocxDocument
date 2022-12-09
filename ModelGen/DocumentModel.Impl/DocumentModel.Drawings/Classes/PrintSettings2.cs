namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public class PrintSettings2Impl: ModelElementImpl, PrintSettings2
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public HeaderFooter1? HeaderFooter
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PageMargins.
  /// </summary>
  public PageMargins2? PageMargins
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PageSetup.
  /// </summary>
  public PageSetup1? PageSetup
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
