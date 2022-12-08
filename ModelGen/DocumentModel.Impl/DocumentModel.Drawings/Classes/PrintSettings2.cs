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
  public HeaderFooter2? HeaderFooter
  {
    get;
    set;
  }
  
  /// <summary>
  /// PageMargins.
  /// </summary>
  public PageMargins1? PageMargins
  {
    get;
    set;
  }
  
  /// <summary>
  /// PageSetup.
  /// </summary>
  public PageSetup1? PageSetup
  {
    get;
    set;
  }
  
}
