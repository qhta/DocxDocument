namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MinorTickMarksTickMarks Class.
/// </summary>
public class MinorTickMarksTickMarksImpl: DocumentModel.Drawings.OpenXmlTickMarksElementImpl, MinorTickMarksTickMarks
{
  public new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorTickMarksTickMarks? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorTickMarksTickMarks?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
