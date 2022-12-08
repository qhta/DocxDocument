namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MinValueColorEndPosition Class.
/// </summary>
public class MinValueColorEndPositionImpl: DocumentModel.Drawings.OpenXmlValueColorEndPositionElementImpl, MinValueColorEndPosition
{
  public new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinValueColorEndPosition? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinValueColorEndPosition?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override Boolean? ExtremeValueColorPosition
  {
    get;
    set;
  }
  
  public override Double? NumberColorPosition
  {
    get;
    set;
  }
  
  public override Double? PercentageColorPosition
  {
    get;
    set;
  }
  
}
