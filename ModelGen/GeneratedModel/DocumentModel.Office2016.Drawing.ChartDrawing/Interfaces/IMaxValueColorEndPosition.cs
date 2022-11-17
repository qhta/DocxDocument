namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IMaxValueColorEndPosition // : DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlValueColorEndPositionElement
{
  public IExtremeValueColorPosition? ExtremeValueColorPosition { get ; set; }

  public INumberColorPosition? NumberColorPosition { get ; set; }

  public IPercentageColorPosition? PercentageColorPosition { get ; set; }

}
