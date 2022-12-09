namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MajorTickMarksTickMarks Class.
/// </summary>
public class MajorTickMarksTickMarksImpl: DocumentModel.Drawings.OpenXmlTickMarksElementImpl, MajorTickMarksTickMarks
{
  public new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorTickMarksTickMarks? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorTickMarksTickMarks?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override ExtensionList2? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
