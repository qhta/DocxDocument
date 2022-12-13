namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the MinorTickMarksTickMarks Class.
/// </summary>
public class MinorTickMarksTickMarksImpl: DocumentModel.Drawings16.Charts.OpenXmlTickMarksElementImpl, MinorTickMarksTickMarks
{
  public new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorTickMarksTickMarks? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorTickMarksTickMarks?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MinorTickMarksTickMarksImpl(): base() {}
  
  public MinorTickMarksTickMarksImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorTickMarksTickMarks openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
