namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MaxValueColorEndPosition Class.
/// </summary>
public class MaxValueColorEndPositionImpl: DocumentModel.Drawings.OpenXmlValueColorEndPositionElementImpl, MaxValueColorEndPosition
{
  public new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxValueColorEndPosition? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxValueColorEndPosition?)_OpenXmlElement;
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
