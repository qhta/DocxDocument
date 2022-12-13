namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the MajorTickMarksTickMarks Class.
/// </summary>
public class MajorTickMarksTickMarksImpl: DocumentModel.Drawings16.Charts.OpenXmlTickMarksElementImpl, MajorTickMarksTickMarks
{
  public new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorTickMarksTickMarks? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorTickMarksTickMarks?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MajorTickMarksTickMarksImpl(): base() {}
  
  public MajorTickMarksTickMarksImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorTickMarksTickMarks openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
