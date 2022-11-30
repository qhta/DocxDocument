namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the MinValueColorEndPosition Class.
/// </summary>
public interface IMinValueColorEndPosition // : DocumentModel.Office2016.Drawing.ChartDrawing.IOpenXmlValueColorEndPositionElement
{
  public System.Boolean? ExtremeValueColorPosition { get ; set; }
  
  public System.Double? NumberColorPosition { get ; set; }
  
  public System.Double? PercentageColorPosition { get ; set; }
  
}
